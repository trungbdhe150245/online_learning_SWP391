#pragma checksum "C:\Users\trung\Desktop\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\CourseView\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df487a805597f4d4cea1dafaae097e5938fd194e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CourseView_Index), @"mvc.1.0.view", @"/Views/CourseView/Index.cshtml")]
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
#line 1 "C:\Users\trung\Desktop\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\trung\Desktop\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df487a805597f4d4cea1dafaae097e5938fd194e", @"/Views/CourseView/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cc414232cb72a548af1b9bdfef0c3bcad4d1fc", @"/Views/_ViewImports.cshtml")]
    public class Views_CourseView_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SWP391_OnlineLearning_Platform.Models.Role>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\trung\Desktop\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\CourseView\Index.cshtml"
  
    Layout = "~/Views/Shared/_SharedLayout.cshtml";
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-heading text-center\">\r\n    <div class=\"container\">\r\n        <div>\r\n            \r\n            <h1>Index</h1>\r\n");
#nullable restore
#line 12 "C:\Users\trung\Desktop\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\CourseView\Index.cshtml"
             if (Model.Count() > 0)
            {
                foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
#nullable restore
#line 16 "C:\Users\trung\Desktop\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\CourseView\Index.cshtml"
                  Write(item.Role_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 17 "C:\Users\trung\Desktop\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\CourseView\Index.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Nothing here</p>\r\n");
#nullable restore
#line 22 "C:\Users\trung\Desktop\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\CourseView\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>

        <h2>SINGLE COURSE</h2>
        <p class=""breadcrumbs"">
            <a href=""#"">Home</a>
            <i class=""zmdi zmdi-chevron-right""></i>
            <a href=""#"">Courses</a>
            <i class=""zmdi zmdi-chevron-right""></i>
            <a href=""#"">Adobe Photoshop</a>
            <i class=""zmdi zmdi-chevron-right""></i>
            <span>Adobe Photoshop CC for Professionals</span>
        </p>
    </div>
</div>
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-9"">
            <img src=""http://placehold.it/871x401"" alt=""Course"" class=""resp-img course-preview"">
            <h3>Adobe Photoshop CC for Professionals</h3>
            <p class=""class-details"">
                <span class=""lessons""><i class=""zmdi zmdi-assignment""></i>12 LESSONS</span>
                <span class=""duration""><i class=""zmdi zmdi-time""></i>3:15h</span>
                <span class=""views""><i class=""zmdi zmdi-eye""></i>2241 VIEWS</span>
                <span class=""tag""");
            WriteLiteral(@"><i class=""zmdi zmdi-label""></i>ADOBE PHOTOSHOP</span>
            </p>
            <h4>COURSE DETAILS</h4>
            <p class=""abs"">
                Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore
                eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum
                zzril delenit augue duis dolore te feugait nulla facilisi. Lorem ipsum dolor sit amet, consectetuer adipiscing
                elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.
            </p>
            <h5>What does this course include?</h5>
            <ul class=""includes"">
                <li>Lorem ipsum dolor sit amet, consectetuer adipisc.</li>
                <li>Aliquam tincidunt mauris eu risus.</li>
                <li>Vestibulum auctor dapibus neque.</li>
                <li>Nunc dignissim risus id metus.</li>
                <li>Cras ornare tristique");
            WriteLiteral(" elit.</li>\r\n                <li>Vivamus vestibulum nulla nec ante.</li>\r\n            </ul>\r\n            <h4>COURSE CONTENT</h4>\r\n            <ul class=\"course-accordion\">\r\n                \r\n");
#nullable restore
#line 67 "C:\Users\trung\Desktop\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\CourseView\Index.cshtml"
         for (int i = 0; i < 4; i++)
        {

        
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""accordion-option"">
                    <div class=""option-title"">Section #1: Tools in Photoshop <span>(4 videos)</span></div>
                    <div class=""option-wrapper"">
                        <ul class=""option-items"">
                            <li class=""option-item"">
                                <div class=""pull-right"">
                                    <span class=""duration"">0.15 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                </div>
                                <a href=""#"">Epsum factorial non deposit quid.</a>
                            </li>
                            <li class=""option-item"">
                                <div class=""pull-right"">
                                    <span class=""duration"">0.31 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                </div>
                                <a href=""#"">Pro quo hic escorol olypian.</a>
                            ");
            WriteLiteral(@"</li>
                            <li class=""option-item"">
                                <div class=""pull-right"">
                                    <span class=""duration"">1.29 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                </div>
                                <a href=""#"">Et gorilla congolium sic.</a>
                            </li>
                            <li class=""option-item"">
                                <div class=""pull-right"">
                                    <span class=""duration"">1.29 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                </div>
                                <a href=""#"">Ad nauseum souvlaki ignitus carborundum.</a>
                            </li>
                        </ul>
                    </div>
                </li>
");
#nullable restore
#line 103 "C:\Users\trung\Desktop\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\CourseView\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n\r\n            </ul>\r\n            <h4>COMMENTS</h4>\r\n            <div class=\"fb-comments\" data-href=\"https://localhost:44389/\" data-width=\"100%\" data-numposts=\"5\"></div>\r\n\r\n            <h4>LEAVE A REPLY</h4>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df487a805597f4d4cea1dafaae097e5938fd194e10476", async() => {
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
                        <label>Description</label>
                        <input type=""text"" name=""site"" placeholder=""description"">
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-sm-12"">
                        <label class=""req"">MESSAGE</label>
                        <textarea name=""name"" placeholder=""type in a message"" required></textarea>
                    </div>
                </div>");
                WriteLiteral(@"
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
            <div class=""col-md-3"">
                <div class=""order text-center"">
                    <p class=""price"">59</p>
                    <p>SINGLE PRICE</p>
                    <a href=""#"" class=""blueplay"">BUY THIS COURSE</a>
                    <p class=""order-or""><span>OR</span></p>
                    <p>SIGN UP FOR</p>
                    <a href=""#"" class=""greybutton"">PREMIUM MEMBERSHIP</a>
                </div>
                <div class=""pros"">
                    <h4>ABOUT THE TEACHER</h4>
                    <div class=""teacher text-center"">
                        <div class=""imgcontainer"">
                            <img src=""http://placehold.it/130x130"" alt=""Avatar"">
                            <div class=""overlay"">
                                <img src=""http://placehold.it/18x17"" alt=""Profile"">
                                <p>8 VIDEOS</p>
                            </div>
                        </div>
                        <a href=""#"">Jon");
            WriteLiteral(@"athan Creon</a>
                        <p>DESINGER</p>
                        <ul class=""social"">
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
                        </ul>
                    </div>
        ");
            WriteLiteral(@"        </div>
                <div class=""ratings"">
                    <h4>COURSE RATINGS</h4>
                    <div class=""rating"">
                        <a href=""#"" class=""on""><i class=""zmdi zmdi-star zmdi-hc-2x""></i></a>
                        <a href=""#"" class=""on""><i class=""zmdi zmdi-star zmdi-hc-2x""></i></a>
                        <a href=""#"" class=""on""><i class=""zmdi zmdi-star zmdi-hc-2x""></i></a>
                        <a href=""#"" class=""on""><i class=""zmdi zmdi-star zmdi-hc-2x""></i></a>
                        <a href=""#""><i class=""zmdi zmdi-star zmdi-hc-2x""></i></a>
                    </div>
                    <p>(37 votes, average: <strong>4.8</strong> out of 5)</p>
                </div>
                <div class=""popular-courses index-3-categories"">
                    <h4>POPULAR COURSES</h4>
                    <div class=""courses-side-slick"">
                        <div class=""category-with-bg text-center cat1"">
                            <h5>Content-Management-Sy");
            WriteLiteral(@"stems</h5>
                            <p>IT-Service for CMS like WordPress</p>
                            <a href=""#"" class=""goto""><i class=""zmdi zmdi-long-arrow-right""></i></a>
                        </div>
                        <div class=""category-with-bg text-center cat2"">
                            <h5>User Experience / UX Design</h5>
                            <p>Workshop for UX Design</p>
                            <a href=""#"" class=""goto""><i class=""zmdi zmdi-long-arrow-right""></i></a>
                        </div>
                        <div class=""category-with-bg text-center cat3"">
                            <h5>Typography &amp; Writing</h5>
                            <p>Work with InDesign</p>
                            <a href=""#"" class=""goto""><i class=""zmdi zmdi-long-arrow-right""></i></a>
                        </div>
                    </div>
                </div>
                <div class=""categories"">
                    <h6>CATEGORIES</h6>
                   ");
            WriteLiteral(@" <ul>
                        <li><a href=""#"">Business (18)</a></li>
                        <li><a href=""#"">CMS (14)</a></li>
                        <li><a href=""#"">Design (17)</a></li>
                        <li><a href=""#"">Development (23)</a></li>
                        <li><a href=""#"">Humanities (17)</a></li>
                        <li><a href=""#"">Mecidine (8)</a></li>
                        <li><a href=""#"">Music (47)</a></li>
                        <li><a href=""#"">Photography (68)</a></li>
                        <li><a href=""#"">Photoshop (87)</a></li>
                        <li><a href=""#"">IT &amp; Software (41)</a></li>
                        <li><a href=""#"">Lifestyle (54)</a></li>
                        <li><a href=""#"">Languages (83)</a></li>
                        <li><a href=""#"">SEO (39)</a></li>
                        <li><a href=""#"">Marketing (44)</a></li>
                        <li><a href=""#"">Video Production (33)</a></li>
                    </ul>
                <");
            WriteLiteral("/div>\r\n            </div>\r\n        </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SWP391_OnlineLearning_Platform.Models.Role>> Html { get; private set; }
    }
}
#pragma warning restore 1591
