using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace crimes.Pages
{
    public class TopTenCrimesModel : PageModel
    {
        public List<Models.Crime> TopTenList { get; set; }
        public Exception EX { get; set; }

        public void OnGet()
        {
            List<Models.Crime> topTen = new List<Models.Crime>();
            
            // clear exception:
            EX = null;
            
            // try query
            try {
                string sql = string.Format(@"
                DECLARE @totalNumCrimes INT = (SELECT Count(*) FROM Crimes)
                SELECT TOP 10 Crimes.IUCR, Codes.PrimaryDesc, Codes.SecondaryDesc, Count(*) AS TotalNumTimes,
                       CONVERT(decimal(3,2), ( CONVERT( float, COUNT(Crimes.IUCR))/@totalNumCrimes ) * 100 ) AS CrimePercentage,
                       CONVERT(decimal(5,2), ( CONVERT( float, SUM( CONVERT(float, Crimes.Arrested) ) ) / CONVERT( float, Count(Crimes.IUCR)) ) * 100 ) AS ArrestPercentage 
                FROM Crimes
                INNER JOIN Codes ON Codes.IUCR = Crimes.IUCR
                INNER JOIN Areas ON Areas.Area = Crimes.Area
                GROUP BY Crimes.IUCR, Codes.PrimaryDesc, Codes.SecondaryDesc
                ORDER BY TotalNumTimes DESC;
                ");
                
                DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

                foreach (DataRow row in ds.Tables["TABLE"].Rows) 
                {
                    Models.Crime c = new Models.Crime();
                    
                    c.IUCR = Convert.ToString(row["IUCR"]);
                    c.PrimaryDesc = Convert.ToString(row["PrimaryDesc"]);
                    c.SecondaryDesc = Convert.ToString(row["SecondaryDesc"]);
                    c.NumTimes = Convert.ToInt32(row["TotalNumTimes"]);
                    c.CrimePercentage = Convert.ToSingle(row["CrimePercentage"]);
                    c.ArrestPercentage = Convert.ToSingle(row["ArrestPercentage"]);
                    
                    topTen.Add(c);
                }
            } // end try
            catch(Exception ex) {
                EX = ex;
            }
            finally
            {
                TopTenList = topTen;  
            }
        }
    }
}

  