#pragma checksum "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d28c219d1736dfcd15afce03d092975858200e9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PublicFeature_BlogDetail), @"mvc.1.0.view", @"/Views/PublicFeature/BlogDetail.cshtml")]
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
#nullable restore
#line 1 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d28c219d1736dfcd15afce03d092975858200e9f", @"/Views/PublicFeature/BlogDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c9951c871a9a9c6c6157a81cfd4964aa953896a", @"/Views/_ViewImports.cshtml")]
    public class Views_PublicFeature_BlogDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SWP391_OnlineLearning_Platform.Models.Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog-single"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("resp-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pull-left profile-usertitle-name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto;height:150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PublicFeature", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "bloglist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("recent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pull-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 70px; height: 70px; object-fit: cover; object-position: 50% 50%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "publicfeature", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlogDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
  
    ViewData["Title"] = "Blog Detail";
    var count = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<main>\r\n    <div class=\"page-heading text-center\">\r\n        <div class=\"container\">\r\n            <hr>\r\n        </div>\r\n    </div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-9\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d28c219d1736dfcd15afce03d092975858200e9f8551", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 501, "~/img/", 501, 6, true);
#nullable restore
#line 24 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
AddHtmlAttributeValue("", 507, Html.DisplayFor(model => model.Thumbnail), 507, 42, false);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                <h3>");
#nullable restore
#line 25 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
               Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <div class=\"author\">\r\n                    <a href=\"#\">");
#nullable restore
#line 27 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                           Write(Html.DisplayFor(model => model.Category.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><span> - 4 JANUARY 2016 BY ");
#nullable restore
#line 27 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                                                                                                         Write(Html.DisplayFor(model => model.User.Full_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <p class=\"abs\">\r\n                    ");
#nullable restore
#line 30 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
               Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
                <p class=""abs"">

                </p>
                <p class=""abs"">

                </p>
                <div class=""about-author"">
                    <ul class=""social pull-right"">
                        <li><a href=""#""><i class=""zmdi zmdi-facebook""></i></a></li>
                        <li>
                            <a href=""#""><i class=""zmdi zmdi-twitter""></i></a>
                        </li>
                        <li>
                            <a href=""#""><i class=""zmdi zmdi-google-old""></i></a>
                        </li>
                        <li>
                            <a href=""#""><i class=""zmdi zmdi-pinterest""></i></a>
                        </li>
                        <li>
                            <a href=""#""><i class=""zmdi zmdi-email""></i></a>
                        </li>
                        <li>
                            <a href=""#""><i class=""zmdi zmdi-globe-alt""></i></a>
                        </li>
");
            WriteLiteral("                    </ul>\r\n                    <br>\r\n                    <h4>ABOUT THE AUTHOR</h4>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d28c219d1736dfcd15afce03d092975858200e9f13123", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2128, "~/img/", 2128, 6, true);
#nullable restore
#line 59 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
AddHtmlAttributeValue("", 2134, Html.DisplayFor(model => model.User.Avatar_Url), 2134, 48, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <p style=\"font-weight: bold; text-transform: uppercase;\">");
#nullable restore
#line 60 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                                                                        Write(Html.DisplayFor(model => model.User.Full_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <p class=""abs"">
                        Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo
                        consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore
                        eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit
                        augue duis dolore te feugait nulla facilisi.
                    </p>
                </div>
                <br/>


");
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"col-lg-3 blog-sidebar\">\r\n");
            WriteLiteral("                <div class=\"search-something\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d28c219d1736dfcd15afce03d092975858200e9f16269", async() => {
                WriteLiteral(@"
                        <div class=""search-something"">
                            <input type=""text"" name=""keyWord"" placeholder=""search for something"">
                            <input type=""button"" value=""Search"">
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <h4>RECENT POSTS</h4>\r\n\r\n");
#nullable restore
#line 142 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                 foreach (var item in ViewData["recentBlogs"] as List<Blog>)
                {
                    ++count;
                    if (count <= 5)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"recent-post clearfix\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d28c219d1736dfcd15afce03d092975858200e9f18796", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6894, "~/img/", 6894, 6, true);
#nullable restore
#line 148 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
AddHtmlAttributeValue("", 6900, Html.DisplayFor(modelItem => item.Thumbnail), 6900, 45, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d28c219d1736dfcd15afce03d092975858200e9f20650", async() => {
#nullable restore
#line 149 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                                                                                                         Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 149 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                            <div class=\"author\">\r\n                                <a href=\"#\">");
#nullable restore
#line 151 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Category.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><span> ");
#nullable restore
#line 151 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                                                                                                    Write(Html.DisplayFor(modelItem => item.Date_Create));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>");
#nullable restore
#line 153 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                              }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <div class=\"categories\">\r\n                    <h6>CATEGORIES</h6>\r\n                    <ul>\r\n");
#nullable restore
#line 160 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                         foreach (var item in ViewData["category"] as List<Category>)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d28c219d1736dfcd15afce03d092975858200e9f25259", async() => {
#nullable restore
#line 162 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                                                                                                              Write(Html.DisplayFor(modelItem => item.Value));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-CatID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 162 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CatID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-CatID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CatID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 163 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SWP391_OnlineLearning_Platform.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
