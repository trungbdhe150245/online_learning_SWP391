#pragma checksum "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "debb5078c6ec53a33c643cb10beb5ccb06c34aa7"
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
#line 1 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"debb5078c6ec53a33c643cb10beb5ccb06c34aa7", @"/Views/PublicFeature/BlogDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6a837e61f6c7e2776282f86d4e5ffaad8856c29", @"/Views/_ViewImports.cshtml")]
    public class Views_PublicFeature_BlogDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SWP391_OnlineLearning_Platform.Models.ViewModels.Blog_Elements>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog-single"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("resp-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pull-left profile-usertitle-name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto;height:150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("my_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PublicFeature", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "bloglist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("recent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pull-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 70px; height: 70px; object-fit: cover; object-position: 50% 50%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "publicfeature", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlogDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 7 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
  
    ViewData["Title"] = "Blog Detail";
    var count = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<main>\r\n    <div class=\"page-heading text-center\">\r\n        <div class=\"container\">\r\n            <hr>\r\n        </div>\r\n    </div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-9\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "debb5078c6ec53a33c643cb10beb5ccb06c34aa79172", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 521, "~/img/", 521, 6, true);
#nullable restore
#line 24 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
AddHtmlAttributeValue("", 527, Html.DisplayFor(model => model.blog.Thumbnail), 527, 47, false);

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
#line 25 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
               Write(Html.DisplayFor(model => model.blog.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <div class=\"author\">\r\n                    <a href=\"#\">");
#nullable restore
#line 27 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                           Write(Html.DisplayFor(model => model.blog.Category.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><span> - 4 JANUARY 2016 BY ");
#nullable restore
#line 27 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                                                                                                              Write(Html.DisplayFor(model => model.blog.User.Full_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <p class=\"abs\">\r\n                    ");
#nullable restore
#line 30 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
               Write(Html.DisplayFor(model => model.blog.Content));

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "debb5078c6ec53a33c643cb10beb5ccb06c34aa713659", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2173, "~/img/", 2173, 6, true);
#nullable restore
#line 59 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
AddHtmlAttributeValue("", 2179, Html.DisplayFor(model => model.blog.User.Avatar_Url), 2179, 53, false);

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
#line 60 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                                                                        Write(Html.DisplayFor(model => model.blog.User.Full_Name));

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
                <h4>COMMENTS</h4>
                <div class=""comment clearfix"">
                    <img src=""http://placehold.it/65x65"" alt=""Avatar"" class=""pull-left"">
                    <a href=""#"">Jack Porter</a>
                    <span class=""postedon"">14 JANUARY 2016 AT 12:24 AM</span>
                    <p class=""abs"">
                        Nam liber tempor cum soluta nobis eleifend opti");
            WriteLiteral(@"on congue nihil imperdiet doming id quod mazim placerat
                        facer possim assum. Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh
                        euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.
                    </p>
                    <a href=""#"" class=""pull-right greybutton"">REPLY</a>
                </div>
                <div class=""comment subcomment clearfix"">
                    <img src=""http://placehold.it/65x65"" alt=""Avatar"" class=""pull-left"">
                    <a href=""#"">Mark Terrenzi</a>
                    <span class=""postedon"">14 JANUARY 2016 AT 12:35 AM</span>
                    <p class=""abs"">
                        Ivel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui
                        blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.
                    </p>
                    <a href=""#"" class=""pull-right grey");
            WriteLiteral("button\">REPLY</a>\r\n                </div>\r\n                <h4>LEAVE A REPLY</h4>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "debb5078c6ec53a33c643cb10beb5ccb06c34aa718169", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <label class=""req"">NAME</label>
                            <input type=""text"" name=""name"" placeholder=""enter your name"" required>
                        </div>
                        <div class=""col-sm-4"">
                            <label class=""req"">E-MAIL ADDRESS</label>
                            <input type=""text"" name=""email"" placeholder=""enter e-mail address"" required>
                        </div>
                        <div class=""col-sm-4"">
                            <label>WEBSITE</label>
                            <input type=""text"" name=""site"" placeholder=""https://"">
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-sm-12"">
                            <label class=""req"">MESSAGE</label>
                            <textarea name=""name"" placeholder=""type in a message"" require");
                WriteLiteral(@"d></textarea>
                        </div>
                    </div>
                    <div class=""row clearfix"">
                        <div class=""col-sm-12"">
                            <div class=""pull-right"">
                                <button class=""greybutton"">SUBMIT</button>
                            </div>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"col-lg-3 blog-sidebar\">\r\n");
            WriteLiteral("                <div class=\"search-something\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "debb5078c6ec53a33c643cb10beb5ccb06c34aa721193", async() => {
                WriteLiteral(@"
                        <a class=""search"" onclick=""document.getElementById('my_form').submit();""><i class=""zmdi zmdi-search zmdi-hc-lg""></i></a>
                        <div class=""search-something"">
                            <input type=""text"" name=""searchString"" placeholder=""search for something"">
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <h4>RECENT POSTS</h4>\r\n\r\n");
#nullable restore
#line 137 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                 foreach (var item in Model.blogs)
                {
                    ++count;
                    if (count <= 5)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"recent-post clearfix\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "debb5078c6ec53a33c643cb10beb5ccb06c34aa723841", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7007, "~/img/", 7007, 6, true);
#nullable restore
#line 143 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
AddHtmlAttributeValue("", 7013, Html.DisplayFor(modelItem => item.Thumbnail), 7013, 45, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "debb5078c6ec53a33c643cb10beb5ccb06c34aa725674", async() => {
#nullable restore
#line 144 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                                                                                                         Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 144 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
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
#line 146 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Category.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><span> ");
#nullable restore
#line 146 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                                                                                                    Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>");
#nullable restore
#line 148 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                              }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <div class=\"categories\">\r\n                    <h6>CATEGORIES</h6>\r\n                    <ul>\r\n");
#nullable restore
#line 155 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                         foreach (var item in Model.category)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a href=\"#\">");
#nullable restore
#line 157 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 158 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\PublicFeature\BlogDetail.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SWP391_OnlineLearning_Platform.Models.ViewModels.Blog_Elements> Html { get; private set; }
    }
}
#pragma warning restore 1591
