#pragma checksum "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c39cdf29e7bdf9b3bb8fab68d5a562a5062d805e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
#line 1 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\_ViewImports.cshtml"
using SWP391;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\_ViewImports.cshtml"
using SWP391.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c39cdf29e7bdf9b3bb8fab68d5a562a5062d805e", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec3be411a2a9623845ef9e0a4ca5737761f0f38c", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/lesson.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Course\Index.cshtml"
  
    ViewData["Title"] = "LESSON";
    Layout = "~/Views/Shared/_LayoutNoContainer.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""lesson-container"">
    <main role=""main"" class=""pb-3"">
        <div class=""row lesson-main"">
            <h1>Course Name</h1>
        </div>
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""video"">
                    <video src=""https://www.html5rocks.com/en/tutorials/video/basics/devstories.mp4"" width=""100%"" muted autoplay controls></video>
                    <h3 class=""title"">Title</h3>
                </div>
                    <div class=""row lesson-main"">
                        <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                            <button onclick=""scriptToggle()"" class=""btn btn-outline-info"" type=""button"" data-toggle=""collapse"" data-target=""#collapseExample"" aria-expanded=""false"" aria-controls=""collapseExample"">
                                Script
                            </button>
                            <button onclick=""noteToggle()"" class=""btn btn-outline-info"" type=""button"" data-");
            WriteLiteral(@"toggle=""collapse"" data-target=""#collapseExample2"" aria-expanded=""false"" aria-controls=""collapseExample"">
                                Note
                            </button>
                        <button type=""button"" class=""btn btn-outline-danger"">Report</button>
                    </div>
                </div>
                        
            <div class=""collapse"" id=""collapseExample"">
              <div class=""card card-body"">
                Transcript
              </div>
            </div>
                        <div class=""collapse"" id=""collapseExample2"">
              <div class=""card card-body"">
                <h4 >Note here<br/><small");
            BeginWriteAttribute("class", " class=\"", 1928, "\"", 1936, 0);
            EndWriteAttribute();
            WriteLiteral(@">You can download your note</small></h4>


                    


                    <textarea class=""text_mop"" style=""margin-bottom:10px"" rows=5></textarea>
                    
                    <input type=""button"" class=""btn_mop btn-primary btn"" style=""margin-left:78%;text-align:center;"" value=""Download"" aria-hidden=""true""/>

              </div>
            </div>
            </div>
           

            <div class=""col-md-4"">

                <div class=""accordion"" id=""accordionExample"">
");
#nullable restore
#line 58 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Course\Index.cshtml"
                     for (var i = 0; i < 4; i++)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("<div class=\"card\">\r\n                        <div class=\"card-header\"");
            BeginWriteAttribute("id", " id=\"", 2626, "\"", 2650, 1);
#nullable restore
#line 61 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Course\Index.cshtml"
WriteAttributeValue("", 2631, "headingOne" + i, 2631, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h2 class=\"mb-0\">\r\n                                <button class=\"btn btn-link\" type=\"button\" data-toggle=\"collapse\" data-target=\"");
#nullable restore
#line 63 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Course\Index.cshtml"
                                                                                                           Write("#collapseOne" + i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"true\" aria-controls=\"collapseOne\">\r\n                                    ");
#nullable restore
#line 64 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Course\Index.cshtml"
                                Write("Topic #" + i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </button>\r\n                            </h2>\r\n                        </div>\r\n");
            WriteLiteral("                        ");
            WriteLiteral("<div id=\"");
#nullable restore
#line 69 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Course\Index.cshtml"
                               Write("collapseOne" + i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"collapse\" aria-labelledby=\"headingOne\" data-parent=\"#accordionExample\">\r\n                           ");
            WriteLiteral("<div class=\"card-body\">\r\n                                ");
            WriteLiteral("<ul class=\"list-group\">\r\n");
#nullable restore
#line 72 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Course\Index.cshtml"
                                     for (var x = 0; x < 4; x++)
                                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"list-group-item\">\r\n                                        <p style=\"margin-bottom:0\"><i class=\"far fa-play-circle\"></i> ");
#nullable restore
#line 75 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Course\Index.cshtml"
                                                                                                  Write("Vid" + x);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p class=\"title-vid\" hidden>");
#nullable restore
#line 76 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Course\Index.cshtml"
                                                                Write("Title" + x);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3722, "\"", 3729, 0);
            EndWriteAttribute();
            WriteLiteral(" hidden></a>\r\n                                    </li>\r\n");
#nullable restore
#line 79 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Course\Index.cshtml"
                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            WriteLiteral("</ul>\r\n                                <br/>\r\n                                <div class=\"list-group\">\r\n");
#nullable restore
#line 83 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Course\Index.cshtml"
                                     for (var j = 0; j < 2; j++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                      <a href=\"/Lesson/Attempt\" class=\"list-group-item list-group-item-warning\">\r\n                                        Quiz\r\n                                    </a>\r\n");
#nullable restore
#line 88 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Course\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            ");
            WriteLiteral("</div>\r\n                        ");
            WriteLiteral("</div>\r\n                    ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 94 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Course\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </main>
</div>


<style>
    .accordion .collapse .card-body .vid video {
        width: 100px;
        border-radius: 5px;
    }
</style>

<style>
    .lesson-container {
        margin: 0 5%;
    }

    .lesson-main {
        margin: 0 0 10px 0;
    }
</style>

<script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" ");
            WriteLiteral(" crossorigin=\"anonymous\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c39cdf29e7bdf9b3bb8fab68d5a562a5062d805e12532", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 121 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Course\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script src=\"https://kit.fontawesome.com/a076d05399.js\" crossorigin=\"anonymous\"></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
