#pragma checksum "/home/codio/workspace/web/Views/UserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28f610b9bfcc01d3d501388270e26cfbbb3bb475"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(program.Pages.Views_UserInfo), @"mvc.1.0.razor-page", @"/Views/UserInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/UserInfo.cshtml", typeof(program.Pages.Views_UserInfo), null)]
namespace program.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/codio/workspace/web/Views/_ViewImports.cshtml"
using program;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28f610b9bfcc01d3d501388270e26cfbbb3bb475", @"/Views/UserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a87352ab55936b7625448d2e9155e1658af919", @"/Views/_ViewImports.cshtml")]
    public class Views_UserInfo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/codio/workspace/web/Views/UserInfo.cshtml"
  
  ViewData["Title"] = "User Information";

#line default
#line hidden
            BeginContext(74, 58, true);
            WriteLiteral("\n<h2>User Information</h2>  \n\n<br />\nYour search string: \"");
            EndContext();
            BeginContext(133, 11, false);
#line 10 "/home/codio/workspace/web/Views/UserInfo.cshtml"
                Write(Model.Input);

#line default
#line hidden
            EndContext();
            BeginContext(144, 27, true);
            WriteLiteral("\"\n<br />\n# of users found: ");
            EndContext();
            BeginContext(172, 14, false);
#line 12 "/home/codio/workspace/web/Views/UserInfo.cshtml"
             Write(Model.NumUsers);

#line default
#line hidden
            EndContext();
            BeginContext(186, 15, true);
            WriteLiteral("\n<br />\n<br />\n");
            EndContext();
#line 15 "/home/codio/workspace/web/Views/UserInfo.cshtml"
  
   if (@Model.EX != null)
	 {

#line default
#line hidden
            BeginContext(234, 16, true);
            WriteLiteral("\t\t <h3>**ERROR: ");
            EndContext();
            BeginContext(251, 16, false);
#line 18 "/home/codio/workspace/web/Views/UserInfo.cshtml"
                 Write(Model.EX.Message);

#line default
#line hidden
            EndContext();
            BeginContext(267, 46, true);
            WriteLiteral("</h3>\n\t\t <br />\n\t\t <hr />\n\t\t <br />\n\t\t <br />\n");
            EndContext();
#line 23 "/home/codio/workspace/web/Views/UserInfo.cshtml"
	 }

#line default
#line hidden
            BeginContext(319, 410, true);
            WriteLiteral(@"
<table class=""table"">  
    <thead>  
        <tr>   
            <th>  
                ID
            </th>  
						<th>  
                Name
            </th>  
		        <th>  
                Occupation 
            </th>  
            <th>  
                AvgRating
            </th>  
            <th>  
                NumReviews 
            </th>  

        </tr>  
    </thead>  
    <tbody>  
");
            EndContext();
#line 48 "/home/codio/workspace/web/Views/UserInfo.cshtml"
         foreach (var item in Model.UserList)  
        {  

#line default
#line hidden
            BeginContext(789, 52, true);
            WriteLiteral("            <tr>  \n                <td>  \n\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(842, 11, false);
#line 52 "/home/codio/workspace/web/Views/UserInfo.cshtml"
                                   Write(item.UserID);

#line default
#line hidden
            EndContext();
            BeginContext(853, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(922, 13, false);
#line 55 "/home/codio/workspace/web/Views/UserInfo.cshtml"
               Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(935, 59, true);
            WriteLiteral("\n                </td> \n\t\t\t\t\t\t\t\t<td>  \n                    ");
            EndContext();
            BeginContext(995, 15, false);
#line 58 "/home/codio/workspace/web/Views/UserInfo.cshtml"
               Write(item.Occupation);

#line default
#line hidden
            EndContext();
            BeginContext(1010, 59, true);
            WriteLiteral("\n                </td> \n\t\t\t\t\t\t\t\t<td>  \n                    ");
            EndContext();
            BeginContext(1070, 14, false);
#line 61 "/home/codio/workspace/web/Views/UserInfo.cshtml"
               Write(item.AvgRating);

#line default
#line hidden
            EndContext();
            BeginContext(1084, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1153, 15, false);
#line 64 "/home/codio/workspace/web/Views/UserInfo.cshtml"
               Write(item.NumReviews);

#line default
#line hidden
            EndContext();
            BeginContext(1168, 45, true);
            WriteLiteral("\n                </td>  \n            </tr>  \n");
            EndContext();
#line 67 "/home/codio/workspace/web/Views/UserInfo.cshtml"
        }  

#line default
#line hidden
            BeginContext(1225, 26, true);
            WriteLiteral("    </tbody>  \n</table> \n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserInfoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UserInfoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UserInfoModel>)PageContext?.ViewData;
        public UserInfoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
