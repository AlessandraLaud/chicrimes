using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;

namespace crimes.Pages
{
    public class MonthlyCrimesModel : PageModel
    {
        public Exception EX { get; set; }
        public List<int> Months { get; set; }
        
        public void OnGet()
        {
            List<int> months = new List<int>();
        
            // clear exception:
            EX = null;
            
            // try query
            try {
                string sql = string.Format(@"
                SELECT COUNT(IUCR) as numCrimes, MONTH(CrimeDate) as month
                FROM Crimes
                GROUP BY month(CrimeDate)
                ORDER BY month;
                ");
                 
                DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

                foreach (DataRow row in ds.Tables["TABLE"].Rows) 
                {
                    int numCrimes = System.Convert.ToInt32( row["numCrimes"] );
                    months.Add(numCrimes);
                }
            } // end try
            catch(Exception ex) 
            {
                EX = ex;
            }
            finally
            {
              Months = months;
            }
        }
    } // class
} // namespace