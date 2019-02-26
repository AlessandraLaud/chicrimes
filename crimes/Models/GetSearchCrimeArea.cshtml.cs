using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
  
namespace crimes.Pages  
{  
    public class GetSearchCrimeAreaModel : PageModel  
    {  
		  public string Input { get; set; }
			
      public void OnGet()  
      {  
				// no data needed for initial view:
	  }
			
    }//class  
}//namespace