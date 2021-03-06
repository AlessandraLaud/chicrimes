#pragma checksum "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/TopTenCrimes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd63f9ffb16665de48effe55661962a015588841"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(crimes.Pages.Views_TopTenCrimes), @"mvc.1.0.razor-page", @"/Views/TopTenCrimes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/TopTenCrimes.cshtml", typeof(crimes.Pages.Views_TopTenCrimes), null)]
namespace crimes.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/_ViewImports.cshtml"
using crimes;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd63f9ffb16665de48effe55661962a015588841", @"/Views/TopTenCrimes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f842f8255da31aa43ed40deaf7f18adbc89934f4", @"/Views/_ViewImports.cshtml")]
    public class Views_TopTenCrimes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/TopTenCrimes.cshtml"
  
  ViewData["Title"] = "Top-10 Crimes";

#line default
#line hidden
            BeginContext(75, 135, true);
            WriteLiteral("\n<div style=\"padding: 40px 80px 40px 80px; height: -webkit-fill-available;\">\n    <h2 style=\"margin-bottom: 40px\">Top-10 Crimes</h2>  \n\n");
            EndContext();
#line 10 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/TopTenCrimes.cshtml"
      
         if (@Model.EX != null)
         {

#line default
#line hidden
            BeginContext(260, 82, true);
            WriteLiteral("           <br />\n             <br />\n             <h3 style=\"color:red\">**ERROR: ");
            EndContext();
            BeginContext(343, 16, false);
#line 15 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/TopTenCrimes.cshtml"
                                       Write(Model.EX.Message);

#line default
#line hidden
            EndContext();
            BeginContext(359, 26, true);
            WriteLiteral("</h3>\n             <br />\n");
            EndContext();
#line 17 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/TopTenCrimes.cshtml"
         }
         else
         {

#line default
#line hidden
            BeginContext(421, 550, true);
            WriteLiteral(@"            <table class=""table"" >  
                <thead style=""color: #1b7ef7; font-size: 17px;"">  
                    <tr>  
                        <th>Rank</th> 
                        <th>IUCR</th>  
                        <th>Primary Description</th>  
                        <th>Secondary Description</th>  
                        <th>Frequency</th>  
                        <th>Crime Percentage</th>
                        <th>Arrest Perecentage</th>
                    </tr>  
                </thead>  
                <tbody>  
");
            EndContext();
#line 33 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/TopTenCrimes.cshtml"
                      
                       int rank = 1;
                     

#line default
#line hidden
            BeginContext(1054, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 36 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/TopTenCrimes.cshtml"
                     foreach (var item in Model.TopTenList)  
                    {  

#line default
#line hidden
            BeginContext(1140, 63, true);
            WriteLiteral("                        <tr>  \n                            <td>");
            EndContext();
            BeginContext(1204, 4, false);
#line 39 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/TopTenCrimes.cshtml"
                           Write(rank);

#line default
#line hidden
            EndContext();
            BeginContext(1208, 40, true);
            WriteLiteral("</td>  \n                            <td>");
            EndContext();
            BeginContext(1249, 9, false);
#line 40 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/TopTenCrimes.cshtml"
                           Write(item.IUCR);

#line default
#line hidden
            EndContext();
            BeginContext(1258, 40, true);
            WriteLiteral("</td>  \n                            <td>");
            EndContext();
            BeginContext(1299, 16, false);
#line 41 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/TopTenCrimes.cshtml"
                           Write(item.PrimaryDesc);

#line default
#line hidden
            EndContext();
            BeginContext(1315, 40, true);
            WriteLiteral("</td>  \n                            <td>");
            EndContext();
            BeginContext(1356, 18, false);
#line 42 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/TopTenCrimes.cshtml"
                           Write(item.SecondaryDesc);

#line default
#line hidden
            EndContext();
            BeginContext(1374, 40, true);
            WriteLiteral("</td>  \n                            <td>");
            EndContext();
            BeginContext(1415, 13, false);
#line 43 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/TopTenCrimes.cshtml"
                           Write(item.NumTimes);

#line default
#line hidden
            EndContext();
            BeginContext(1428, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1467, 20, false);
#line 44 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/TopTenCrimes.cshtml"
                           Write(item.CrimePercentage);

#line default
#line hidden
            EndContext();
            BeginContext(1487, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1526, 21, false);
#line 45 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/TopTenCrimes.cshtml"
                           Write(item.ArrestPercentage);

#line default
#line hidden
            EndContext();
            BeginContext(1547, 39, true);
            WriteLiteral("</td>\n                        </tr> \t\t\n");
            EndContext();
#line 47 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/TopTenCrimes.cshtml"
                        rank++;
                    }  

#line default
#line hidden
            BeginContext(1642, 49, true);
            WriteLiteral("                </tbody>  \n            </table> \n");
            EndContext();
#line 51 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/TopTenCrimes.cshtml"
         }
    

#line default
#line hidden
            BeginContext(1708, 6, true);
            WriteLiteral("</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopTenCrimesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopTenCrimesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopTenCrimesModel>)PageContext?.ViewData;
        public TopTenCrimesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
