#pragma checksum "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efa5f503b1ced11847826b28be7d1462a180e629"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Slider), @"mvc.1.0.view", @"/Views/Shared/_Slider.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Slider.cshtml", typeof(AspNetCore.Views_Shared__Slider))]
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
#line 1 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.WebUI;

#line default
#line hidden
#line 2 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.Entity;

#line default
#line hidden
#line 3 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efa5f503b1ced11847826b28be7d1462a180e629", @"/Views/Shared/_Slider.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fff6f22e2e75899ad76955e5f59007642ec0eac", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Slider : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 127, true);
            WriteLiteral("\r\n<div id=\"carouselExampleIndicators\" class=\"carousel slide mb-3\" data-ride=\"carousel\">\r\n    <ol class=\"carousel-indicators\">\r\n");
            EndContext();
#line 5 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
         for (int i = 0; i < Model.Count(); i++)
        {
            if (i == 0)
            {

#line default
#line hidden
            BeginContext(254, 76, true);
            WriteLiteral("                <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
            EndContext();
            BeginContext(331, 1, false);
#line 9 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                                                                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(332, 24, true);
            WriteLiteral("\" class=\"active\"></li>\r\n");
            EndContext();
#line 10 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
            }

            else
            {

#line default
#line hidden
            BeginContext(406, 76, true);
            WriteLiteral("                <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
            EndContext();
            BeginContext(483, 1, false);
#line 14 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                                                                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(484, 9, true);
            WriteLiteral("\"></li>\r\n");
            EndContext();
#line 15 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
            }

        }

#line default
#line hidden
            BeginContext(521, 62, true);
            WriteLiteral("    </ol>\r\n    <div class=\"carousel-inner\" role=\"listbox\">\r\n\r\n");
            EndContext();
#line 21 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
           var index = 0;

#line default
#line hidden
            BeginContext(611, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 22 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
         foreach (var item in Model)
        {
            if (index == 0)
            {

#line default
#line hidden
            BeginContext(704, 72, true);
            WriteLiteral("                <div class=\"carousel-item active\">\r\n                    ");
            EndContext();
            BeginContext(776, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "172e4d5bb3e2404cbe9c3633be960aa3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 812, "~/img/", 812, 6, true);
#line 27 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
AddHtmlAttributeValue("", 818, item.Image, 818, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
AddHtmlAttributeValue("", 836, item.Title, 836, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(849, 100, true);
            WriteLiteral("\r\n                    <div class=\"carousel-caption d-none d-md-block\">\r\n                        <h3>");
            EndContext();
            BeginContext(950, 10, false);
#line 29 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(960, 34, true);
            WriteLiteral("</h3>\r\n                        <p>");
            EndContext();
            BeginContext(995, 16, false);
#line 30 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                      Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1011, 58, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 33 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"

                index++;
            }

            else
            {

#line default
#line hidden
            BeginContext(1147, 65, true);
            WriteLiteral("                <div class=\"carousel-item\">\r\n                    ");
            EndContext();
            BeginContext(1212, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9823620fb67d4da38b6f941ca2225f20", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1248, "~/img/", 1248, 6, true);
#line 40 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
AddHtmlAttributeValue("", 1254, item.Image, 1254, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 40 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
AddHtmlAttributeValue("", 1272, item.Title, 1272, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1285, 100, true);
            WriteLiteral("\r\n                    <div class=\"carousel-caption d-none d-md-block\">\r\n                        <h3>");
            EndContext();
            BeginContext(1386, 10, false);
#line 42 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1396, 34, true);
            WriteLiteral("</h3>\r\n                        <p>");
            EndContext();
            BeginContext(1431, 16, false);
#line 43 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                      Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1447, 58, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 46 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
            }

        }

#line default
#line hidden
            BeginContext(1533, 498, true);
            WriteLiteral(@"
    </div>

    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
