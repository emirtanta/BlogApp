#pragma checksum "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "011a6962f6f7ca403d1ae6249a975bbacfe8e0d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_List), @"mvc.1.0.view", @"/Views/Blog/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/List.cshtml", typeof(AspNetCore.Views_Blog_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"011a6962f6f7ca403d1ae6249a975bbacfe8e0d5", @"/Views/Blog/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fff6f22e2e75899ad76955e5f59007642ec0eac", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aps-controller", new global::Microsoft.AspNetCore.Html.HtmlString("Blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(118, 220, true);
            WriteLiteral("\r\n<div class=\"container mt-3\">\r\n    <h2>Blog list</h2>\r\n    <hr />\r\n    <div>\r\n        <a href=\"/Blog/Create\" class=\"btn btn-primary\">Create</a>\r\n    </div>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n");
            EndContext();
#line 16 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
             if (Model.Count()>0)
            {

#line default
#line hidden
            BeginContext(388, 570, true);
            WriteLiteral(@"                <table class=""table table-striped table-bordered"">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Image</th>
                            <th>Title</th>
                            <th>Date</th>
                            <th>Is Approved</th>
                            <th>IsHome</th>
                            <th>IsSlider</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 32 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1039, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1136, 11, false);
#line 36 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                           Write(item.BlogId);

#line default
#line hidden
            EndContext();
            BeginContext(1147, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1250, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ecb44db961f642ef855ae5f898c8a8a7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1260, "~/img/", 1260, 6, true);
#line 39 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
AddHtmlAttributeValue("", 1266, item.Image, 1266, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1304, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1408, 10, false);
#line 42 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                           Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1418, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1522, 9, false);
#line 45 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                           Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1531, 71, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 48 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                 if (item.isApproved)
                                {

#line default
#line hidden
            BeginContext(1692, 82, true);
            WriteLiteral("                                    <span class=\"glyphicon glyphicon-ok\"></span>\r\n");
            EndContext();
#line 51 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1882, 86, true);
            WriteLiteral("                                    <span class=\"glyphicon glyphicon-remove\"></span>\r\n");
            EndContext();
#line 55 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                }

#line default
#line hidden
            BeginContext(2003, 69, true);
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 58 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                 if (item.isHome)
                                {

#line default
#line hidden
            BeginContext(2158, 91, true);
            WriteLiteral("                                    <span class=\"glyphicon glyphicon-ok\">Onaylandı</span>\r\n");
            EndContext();
#line 61 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2357, 97, true);
            WriteLiteral("                                    <span class=\"glyphicon glyphicon-remove\">Onaylanmadı</span>\r\n");
            EndContext();
#line 65 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                }

#line default
#line hidden
            BeginContext(2489, 69, true);
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 68 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                 if (item.isSlider)
                                {

#line default
#line hidden
            BeginContext(2646, 91, true);
            WriteLiteral("                                    <span class=\"glyphicon glyphicon-ok\">Onaylandı</span>\r\n");
            EndContext();
#line 71 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2845, 97, true);
            WriteLiteral("                                    <span class=\"glyphicon glyphicon-remove\">Onaylanmadı</span>\r\n");
            EndContext();
#line 75 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                }

#line default
#line hidden
            BeginContext(2977, 101, true);
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3078, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feee21171a56462b8122f286645a187a", async() => {
                BeginContext(3180, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                                                                                            WriteLiteral(item.BlogId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3188, 36, true);
            WriteLiteral("\r\n\r\n                                ");
            EndContext();
            BeginContext(3224, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09ac2f3ab26f40b192fda269b515753d", async() => {
                BeginContext(3333, 11, true);
                WriteLiteral("Add Or Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                                                                                                   WriteLiteral(item.BlogId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3348, 36, true);
            WriteLiteral("\r\n\r\n                                ");
            EndContext();
            BeginContext(3384, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2afca0a8260944c892c1439cb539dab2", async() => {
                BeginContext(3487, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                                                                                             WriteLiteral(item.BlogId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3497, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 85 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                        }

#line default
#line hidden
            BeginContext(3592, 82, true);
            WriteLiteral("                        \r\n                    </tbody>\r\n                </table>\r\n");
            EndContext();
#line 89 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3722, 111, true);
            WriteLiteral("                <div class=\"alert alert-danger\">\r\n                    Blog Eklenmemiş\r\n                </div>\r\n");
            EndContext();
#line 95 "C:\Users\emirt\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
            }

#line default
#line hidden
            BeginContext(3848, 38, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
