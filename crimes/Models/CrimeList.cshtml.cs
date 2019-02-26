using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;

namespace crimes.Pages
{
    public class CrimeListModel : PageModel
    {

        public List<Models.Crime> CrimeList { get; set; }
        public Exception EX { get; set; }
        
        public void OnGet()
        {
            List<Models.Crime> crimeList = new List<Models.Crime>();
            
            // clear exception:
            EX = null;
            
            // try query
            try {
                string sql = string.Format(@"
                SELECT Codes.IUCR, PrimaryDesc, SecondaryDesc, COUNT(Codes.IUCR) AS Frequency
                FROM Codes
                FULL OUTER JOIN Crimes ON Crimes.IUCR = Codes.IUCR
                GROUP BY Codes.IUCR, PrimaryDesc, SecondaryDesc
                ORDER BY PrimaryDesc ASC, SecondaryDesc ASC;
                ");
                
                DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

                foreach (DataRow row in ds.Tables["TABLE"].Rows) 
                {
                    Models.Crime c = new Models.Crime();
                    
                    c.IUCR = Convert.ToString(row["IUCR"]);
                    c.PrimaryDesc = Convert.ToString(row["PrimaryDesc"]);
                    c.SecondaryDesc = Convert.ToString(row["SecondaryDesc"]);
                    c.NumTimes = Convert.ToInt32(row["Frequency"]);
                    
                    crimeList.Add(c);
                }
            } // end try
            catch(Exception ex) {
                EX = ex;
            }
            finally
            {
                CrimeList = crimeList;  
            }
        } // end OnGet()
    } // class
} // namespace
