using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;

namespace crimes.Pages
{
    public class IndexModel : PageModel
    {
        public int numHomicide { get; set; }
        public int numRobbery { get; set; }
        public int numAssault { get; set; }
        public int numStalking { get; set; }
        public int numBurglary { get; set; }
        public int numSexOffense { get; set; }
        
        public Exception EX { get; set; }
        
        public void OnGet()
        {
        
            // clear exception:
            EX = null;
            
            // try query
            try {
                string sql = string.Format(@"
                DECLARE @numHomicide INT = (SELECT Count(*) FROM Codes WHERE PrimaryDesc='HOMICIDE')
                DECLARE @numRobbery INT = (SELECT Count(*) FROM Codes WHERE PrimaryDesc='ROBBERY')
                DECLARE @numAssault INT = (SELECT Count(*) FROM Codes WHERE PrimaryDesc='ASSAULT')
                DECLARE @numStalking INT = (SELECT Count(*) FROM Codes WHERE PrimaryDesc='STALKING')
                DECLARE @numBurglary INT = (SELECT Count(*) FROM Codes WHERE PrimaryDesc='BURGLARY')
                DECLARE @numSexOffense INT = (SELECT Count(*) FROM Codes WHERE PrimaryDesc='SEX OFFENSE')
                SELECT @numHomicide as homicide, @numRobbery as robbery, @numAssault as assault, @numStalking as stalking, @numBurglary as burglary, @numSexOffense as sexOffense; 
                ");
                
                DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

                foreach (DataRow row in ds.Tables["TABLE"].Rows) 
                {
                    numHomicide = System.Convert.ToInt32( row["homicide"] );
                    numRobbery = System.Convert.ToInt32( row["robbery"] );
                    numAssault = System.Convert.ToInt32( row["assault"] );
                    numStalking = System.Convert.ToInt32( row["stalking"] );
                    numBurglary = System.Convert.ToInt32( row["burglary"] );
                    numSexOffense = System.Convert.ToInt32( row["sexOffense"] );
                }
            } // end try
            catch(Exception ex) 
            {
                EX = ex;
            }
        }
    } // class
} // namespace
