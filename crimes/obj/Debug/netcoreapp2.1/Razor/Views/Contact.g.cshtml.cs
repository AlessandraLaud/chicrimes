#pragma checksum "/Users/sandra/Documents/Fall 2018/CS 341/project07-crimes-web/crimes/Views/Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "878038baf37e1f48d51f1125c3c946f869912ca1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(crimes.Pages.Views_Contact), @"mvc.1.0.razor-page", @"/Views/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/Contact.cshtml", typeof(crimes.Pages.Views_Contact), null)]
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
#line 1 "/Users/sandra/Documents/Fall 2018/CS 341/project07-crimes-web/crimes/Views/_ViewImports.cshtml"
using crimes;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"878038baf37e1f48d51f1125c3c946f869912ca1", @"/Views/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f842f8255da31aa43ed40deaf7f18adbc89934f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/sandra/Documents/Fall 2018/CS 341/project07-crimes-web/crimes/Views/Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(66, 315, true);
            WriteLiteral(@"
<div class=""container-fluid"" style=""padding: 40px; height: -webkit-fill-available;>  
    <div id=""searchCardContainer"" class=""row"">  
        <div class=""col-md-4"" style=""width: 800px; height: 400px;"">
             <div id=""searchCard"" class=""card"">
                  <div>
                    <h2 align=""center"">");
            EndContext();
            BeginContext(382, 17, false);
#line 12 "/Users/sandra/Documents/Fall 2018/CS 341/project07-crimes-web/crimes/Views/Contact.cshtml"
                                  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(399, 948, true);
            WriteLiteral(@"</h2> 
                    <hr style=""border-top: 1px solid #d8d8d8;"" />
                    <ul class=""contact-list"">
                      <li>
                          <i class=""glyphicon glyphicon-user icon""></i>
                          <span class=""contact-list-item"">Alessandra Laudando</span>
                      </li>
                      <li>
                          <i class=""glyphicon glyphicon-phone icon""></i>  
                          <span class=""contact-list-item""><a href=""mailto:Support@example.com"">630-873-0681</a></span>
                      </li>
                      <li>
                          <i class=""glyphicon glyphicon-envelope icon""></i>  
                          <span class=""contact-list-item""><a href=""mailto:Support@example.com"">alauda2@uic.edu</a></span>
                      </li>
                    </ul>
                  </div>
             </div>
        </div>  
    </div>   			
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel>)PageContext?.ViewData;
        public ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
