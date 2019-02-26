using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace crimes.Pages
{
    public class SearchCrimeYearModel : PageModel
    {
        public List<Models.Crime> CrimeYearList { get; set; }
        public string Input { get; set; }
        public Exception EX { get; set; }
        public string ErrorMsg { get; set; }
        public string NoResultMsg { get; set; }

        public void OnGet(string input)
        {
            List<Models.Crime> crimeYearList = new List<Models.Crime>();
            
            // clear exception:
            EX = null;
            
            // initialize messages
            ErrorMsg = " ";
            NoResultMsg = " ";
            
            // make input available to web page:
            Input = input;
            
            try
            {
                // No input 
                if (input == null)
                {
                    // there's no page argument, perhaps user surfed to the page directly?  
                    // In this case, nothing to do.
                    NoResultMsg = "Search results are empty.";
                }
                // User input exists 
                else  
                {
                    // Lookup crime(s) based on input, which could be area number or area name:
                    int id;
                    string sql;

                    // lookup crime by yea:
                    if (System.Int32.TryParse(input, out id))
                    {
                        sql = string.Format(@"
                        SELECT Crimes.IUCR, Codes.PrimaryDesc, Crimes.Year, Areas.Area, Areas.AreaName 
                        FROM Crimes
                        INNER JOIN Codes ON Codes.IUCR = Crimes.IUCR
                        INNER JOIN Areas ON Areas.Area = Crimes.Area
                        WHERE Crimes.Year = {0}
                        GROUP BY Crimes.IUCR, Codes.PrimaryDesc, Crimes.Year, Areas.Area, Areas.AreaName ; 
                        ", id);
                    }
                    else {
                        sql = " ";
                    }
                    
                    
                    DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);
                    
                    if(ds.Tables[0].Rows.Count == 0) {
                        NoResultMsg = "Search results are empty.";
                    }
                    else {
                        foreach (DataRow row in ds.Tables["TABLE"].Rows)
                        {
                            Models.Crime c = new Models.Crime();

                            c.IUCR = Convert.ToString(row["IUCR"]);
                            c.PrimaryDesc = Convert.ToString(row["PrimaryDesc"]);
                            c.Year = Convert.ToInt32(row["Year"]);
                            c.AreaName = Convert.ToString(row["AreaName"]);
                            c.AreaNum = Convert.ToInt32(row["Area"]);

                            crimeYearList.Add(c);
                        }
                    } 
                }
            } // end try
            catch(Exception ex)
            {
              EX = ex;
              ErrorMsg = "Something went wrong. Could not find search results. Please try again.";
            }
            finally
            {
              CrimeYearList = crimeYearList;
            }
        } // end onGet()
    } // end class
} // end namespace