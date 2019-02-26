using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace crimes.Pages
{
    public class SearchCrimeAreaModel : PageModel
    {
        public List<Models.Crime> CrimeAreaList { get; set; }
        public string Input { get; set; }
        public Exception EX { get; set; }
        public string ErrorMsg { get; set; }
        public string NoResultMsg { get; set; }

        public void OnGet(string input)
        {
            List<Models.Crime> crimeList = new List<Models.Crime>();
            
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

                    // lookup crime by id:
                    if (System.Int32.TryParse(input, out id))
                    {
                        sql = string.Format(@"
                        DECLARE @totalNumCrimes INT = (SELECT Count(*) FROM Crimes WHERE Crimes.Area = {0})
 
                        SELECT TOP 10 Crimes.IUCR, Codes.PrimaryDesc, Codes.SecondaryDesc, COUNT(Crimes.IUCR) AS TotalNumTimes, Areas.Area, AreaName,
                               CONVERT(decimal(3,2), ( CONVERT( float, COUNT(Crimes.IUCR))/@totalNumCrimes ) * 100 ) AS CrimePercentage,
                               CONVERT(decimal(5,2), ( CONVERT( float, SUM( CONVERT(float, Crimes.Arrested) ) ) / CONVERT( float, Count(Crimes.IUCR)) ) * 100 ) AS ArrestPercentage 
                        FROM Crimes
                        FULL OUTER JOIN Codes ON Codes.IUCR = Crimes.IUCR
                        FULL OUTER JOIN Areas ON Areas.Area = Crimes.Area
                        WHERE Crimes.Area = {0}
                        GROUP BY Crimes.IUCR, Codes.PrimaryDesc, Codes.SecondaryDesc, Areas.Area, AreaName
                        ORDER BY TotalNumTimes desc;
                        ", id);
                    }
                    // lookup crime by name:
                    else
                    {
                        sql = string.Format(@"
                        DECLARE @totalNumCrimes INT = (SELECT Count(*) FROM Crimes INNER JOIN Areas ON Crimes.Area = Areas.Area WHERE Areas.AreaName = '{0}')
 
                        SELECT TOP 10 Crimes.IUCR, Codes.PrimaryDesc, Codes.SecondaryDesc, COUNT(Crimes.IUCR) AS TotalNumTimes, Areas.Area, AreaName,
                               CONVERT(decimal(3,2), ( CONVERT( float, COUNT(Crimes.IUCR))/@totalNumCrimes ) * 100 ) AS CrimePercentage,
                               CONVERT(decimal(5,2), ( CONVERT( float, SUM( CONVERT(float, Crimes.Arrested) ) ) / CONVERT( float, Count(Crimes.IUCR)) ) * 100 ) AS ArrestPercentage 
                        FROM Crimes
                        FULL OUTER JOIN Codes ON Codes.IUCR = Crimes.IUCR
                        FULL OUTER JOIN Areas ON Areas.Area = Crimes.Area
                        WHERE Areas.AreaName = '{0}'
                        GROUP BY Crimes.IUCR, Codes.PrimaryDesc, Codes.SecondaryDesc, Areas.Area, AreaName
                        ORDER BY TotalNumTimes desc;
                        ", input);
                    }
                    
                    DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);
                    
                    // check if query results are empty
                    if(ds.Tables[0].Rows.Count == 0) {
                        NoResultMsg = "Search results are empty.";
                    }
                    else {
                        foreach (DataRow row in ds.Tables["TABLE"].Rows)
                        {
                            Models.Crime c = new Models.Crime();

                            c.IUCR = Convert.ToString(row["IUCR"]);
                            c.PrimaryDesc = Convert.ToString(row["PrimaryDesc"]);
                            c.SecondaryDesc = Convert.ToString(row["SecondaryDesc"]);
                            c.NumTimes = Convert.ToInt32(row["TotalNumTimes"]);
                            c.CrimePercentage = Convert.ToSingle(row["CrimePercentage"]);
                            c.ArrestPercentage = Convert.ToSingle(row["ArrestPercentage"]);
                            c.AreaName = Convert.ToString(row["AreaName"]);
                            c.AreaNum = Convert.ToInt32(row["Area"]);

                            crimeList.Add(c);
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
              CrimeAreaList = crimeList;
            }
        } // end onGet()
    } // end class
} // end namespace