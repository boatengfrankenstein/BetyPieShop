#pragma checksum "/home/daniel/Documents/ASPCORE/boakyepieshop/Views/Pie/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7d33394563d13fdef96953ea77e9ebcd36c4bb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pie_List), @"mvc.1.0.view", @"/Views/Pie/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pie/List.cshtml", typeof(AspNetCore.Views_Pie_List))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/daniel/Documents/ASPCORE/boakyepieshop/Views/_ViewImports.cshtml"
using boakyepieshop;

#line default
#line hidden
#line 2 "/home/daniel/Documents/ASPCORE/boakyepieshop/Views/_ViewImports.cshtml"
using boakyepieshop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7d33394563d13fdef96953ea77e9ebcd36c4bb8", @"/Views/Pie/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bec450b2ef706df0bffa476b3f87bb447ba107e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pie_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<boakyepieshop.ViewModels.PiesListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 9, true);
            WriteLiteral("\n    <h1>");
            EndContext();
            BeginContext(60, 21, false);
#line 3 "/home/daniel/Documents/ASPCORE/boakyepieshop/Views/Pie/List.cshtml"
   Write(Model.CurrentCategory);

#line default
#line hidden
            EndContext();
            BeginContext(81, 6, true);
            WriteLiteral("</h1>\n");
            EndContext();
#line 4 "/home/daniel/Documents/ASPCORE/boakyepieshop/Views/Pie/List.cshtml"
         foreach (var pie in Model.Pies)
        {
          

#line default
#line hidden
            BeginContext(283, 93, true);
            WriteLiteral("    <div class=\"col-sm-4 col-lg-4 col-md-4\">\n        <div class=\"thumbnail\">\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 376, "\"", 404, 1);
#line 14 "/home/daniel/Documents/ASPCORE/boakyepieshop/Views/Pie/List.cshtml"
WriteAttributeValue("", 382, pie.ImageThumbnailUrl, 382, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(405, 82, true);
            WriteLiteral(" alt=\"\">\n            <div class=\"caption\">\n                <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(488, 23, false);
#line 16 "/home/daniel/Documents/ASPCORE/boakyepieshop/Views/Pie/List.cshtml"
                                  Write(pie.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(511, 50, true);
            WriteLiteral("</h3>\n                <h3>\n                    <a>");
            EndContext();
            BeginContext(562, 8, false);
#line 18 "/home/daniel/Documents/ASPCORE/boakyepieshop/Views/Pie/List.cshtml"
                  Write(pie.Name);

#line default
#line hidden
            EndContext();
            BeginContext(570, 46, true);
            WriteLiteral("</a>\n                </h3>\n                <p>");
            EndContext();
            BeginContext(617, 20, false);
#line 20 "/home/daniel/Documents/ASPCORE/boakyepieshop/Views/Pie/List.cshtml"
              Write(pie.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(637, 50, true);
            WriteLiteral("</p>\n            </div>\n        </div>\n    </div>\n");
            EndContext();
#line 24 "/home/daniel/Documents/ASPCORE/boakyepieshop/Views/Pie/List.cshtml"
        }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<boakyepieshop.ViewModels.PiesListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
