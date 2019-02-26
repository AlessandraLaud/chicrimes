using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;

namespace crimes.Pages
{
    public class AreaListModel : PageModel
    {

        public List<Models.Area> AreaList { get; set; }
        public Exception EX { get; set; }
        
        public void OnGet()
        {
            List<Models.Area> areaList = new List<Models.Area>();
            
            // clear exception:
            EX = null;
            
            // try query
            try {
                string sql = string.Format(@"
                DECLARE @totalNumCrimes INT = (SELECT Count(*) FROM Crimes)

                SELECT Areas.AreaName, Areas.Area, COUNT(IUCR) AS numCrimes, 
                       CONVERT(decimal(4,2), ( CONVERT( float, COUNT(IUCR))/@totalNumCrimes ) * 100 ) AS crimePercentage
                FROM Areas
                FULL OUTER JOIN Crimes ON Crimes.Area = Areas.Area
                GROUP BY Areas.AreaName, Areas.Area
                ORDER BY Areas.AreaName ASC;
                ");
                
                DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

                foreach (DataRow row in ds.Tables["TABLE"].Rows) 
                {
                    Models.Area a = new Models.Area();
                    
                    a.AreaName = Convert.ToString(row["AreaName"]);
                    a.AreaNum = Convert.ToInt32(row["Area"]);
                    a.NumCrimes = Convert.ToInt32(row["numCrimes"]);
                    a.CrimePercentage = Convert.ToSingle(row["crimePercentage"]);
                    
                    areaList.Add(a);
                }
            } // end try
            catch(Exception ex) {
                EX = ex;
            }
            finally
            {
                AreaList = areaList;  
            }
        } // end OnGet()
    } // class
} // namespace
