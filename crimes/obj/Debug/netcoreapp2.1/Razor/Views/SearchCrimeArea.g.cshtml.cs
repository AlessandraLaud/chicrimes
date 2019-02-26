#pragma checksum "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9fb880ed5c93328b8434d8a29c381fe3f457b5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(crimes.Pages.Views_SearchCrimeArea), @"mvc.1.0.razor-page", @"/Views/SearchCrimeArea.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/SearchCrimeArea.cshtml", typeof(crimes.Pages.Views_SearchCrimeArea), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9fb880ed5c93328b8434d8a29c381fe3f457b5f", @"/Views/SearchCrimeArea.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f842f8255da31aa43ed40deaf7f18adbc89934f4", @"/Views/_ViewImports.cshtml")]
    public class Views_SearchCrimeArea : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
  
  ViewData["Title"] = "Search Area";

#line default
#line hidden
            BeginContext(76, 122, true);
            WriteLiteral("\n<div style=\"padding: 40px; height: -webkit-fill-available;\">\n    <h2 style=\"margin-bottom: 30px\">Search Crime Area</h2> \n");
            EndContext();
#line 9 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
      
         if (@Model.EX != null)
         {

#line default
#line hidden
            BeginContext(248, 64, true);
            WriteLiteral("             <hr />\n             <h3 style=\"color:red\">**ERROR: ");
            EndContext();
            BeginContext(313, 14, false);
#line 13 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
                                       Write(Model.ErrorMsg);

#line default
#line hidden
            EndContext();
            BeginContext(327, 46, true);
            WriteLiteral("</h3>\n             <br />\n             <hr />\n");
            EndContext();
#line 16 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
         }
         else if (@Model.NoResultMsg != " ")
         {

#line default
#line hidden
            BeginContext(440, 75, true);
            WriteLiteral("             <hr />\n             <br />\n             <h3 style=\"color:red\">");
            EndContext();
            BeginContext(516, 17, false);
#line 21 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
                              Write(Model.NoResultMsg);

#line default
#line hidden
            EndContext();
            BeginContext(533, 26, true);
            WriteLiteral("</h3>\n             <br />\n");
            EndContext();
#line 23 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
         }
         else
         {

#line default
#line hidden
            BeginContext(595, 617, true);
            WriteLiteral(@"            <table class=""table"">  
                <thead style=""color: #1b7ef7; font-size: 17px;"">  
                    <tr>  
                        <th>Rank</th>
                        <th>Area Number</th>
                        <th>Area Name</th>
                        <th>IUCR</th>  
                        <th>PrimaryDesc</th>  
                        <th>SecondaryDesc</th>  
                        <th>NumTimes</th>  
                        <th>Crime Percentage</th>
                        <th>Arrest Perecentage</th>
                    </tr>  
                </thead>  
                <tbody>
");
            EndContext();
#line 41 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
                      
                       int rank = 1;
                     

#line default
#line hidden
            BeginContext(1295, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 44 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
                     foreach (var item in Model.CrimeAreaList)  
                    {  

#line default
#line hidden
            BeginContext(1384, 63, true);
            WriteLiteral("                        <tr>  \n                            <td>");
            EndContext();
            BeginContext(1448, 4, false);
#line 47 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
                           Write(rank);

#line default
#line hidden
            EndContext();
            BeginContext(1452, 39, true);
            WriteLiteral("</td> \n                            <td>");
            EndContext();
            BeginContext(1492, 12, false);
#line 48 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
                           Write(item.AreaNum);

#line default
#line hidden
            EndContext();
            BeginContext(1504, 39, true);
            WriteLiteral("</td> \n                            <td>");
            EndContext();
            BeginContext(1544, 13, false);
#line 49 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
                           Write(item.AreaName);

#line default
#line hidden
            EndContext();
            BeginContext(1557, 39, true);
            WriteLiteral("</td> \n                            <td>");
            EndContext();
            BeginContext(1597, 9, false);
#line 50 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
                           Write(item.IUCR);

#line default
#line hidden
            EndContext();
            BeginContext(1606, 40, true);
            WriteLiteral("</td>  \n                            <td>");
            EndContext();
            BeginContext(1647, 16, false);
#line 51 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
                           Write(item.PrimaryDesc);

#line default
#line hidden
            EndContext();
            BeginContext(1663, 40, true);
            WriteLiteral("</td>  \n                            <td>");
            EndContext();
            BeginContext(1704, 18, false);
#line 52 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
                           Write(item.SecondaryDesc);

#line default
#line hidden
            EndContext();
            BeginContext(1722, 40, true);
            WriteLiteral("</td>  \n                            <td>");
            EndContext();
            BeginContext(1763, 13, false);
#line 53 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
                           Write(item.NumTimes);

#line default
#line hidden
            EndContext();
            BeginContext(1776, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1815, 20, false);
#line 54 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
                           Write(item.CrimePercentage);

#line default
#line hidden
            EndContext();
            BeginContext(1835, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1874, 21, false);
#line 55 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
                           Write(item.ArrestPercentage);

#line default
#line hidden
            EndContext();
            BeginContext(1895, 39, true);
            WriteLiteral("</td>\n                        </tr> \t\t\n");
            EndContext();
#line 57 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
                        rank++;
                    } 

#line default
#line hidden
            BeginContext(1989, 48, true);
            WriteLiteral("                </tbody> \n            </table> \n");
            EndContext();
#line 61 "/Users/sandra/Code/Projects/ChiCrimes/crimes/Views/SearchCrimeArea.cshtml"
         }

#line default
#line hidden
            BeginContext(2048, 83, true);
            WriteLiteral("         <a class=\"btn btn-default\" href=\"/GetSearchCrimeArea\">Back To Search</a> \n");
            EndContext();
            BeginContext(2137, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchCrimeAreaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SearchCrimeAreaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SearchCrimeAreaModel>)PageContext?.ViewData;
        public SearchCrimeAreaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
