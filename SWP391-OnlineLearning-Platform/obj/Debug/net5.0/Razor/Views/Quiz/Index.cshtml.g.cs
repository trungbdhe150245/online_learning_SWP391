#pragma checksum "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Quiz\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f97ec7e870eb30b6fd3bf586c69f293f04faea8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_Index), @"mvc.1.0.view", @"/Views/Quiz/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f97ec7e870eb30b6fd3bf586c69f293f04faea8e", @"/Views/Quiz/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6a837e61f6c7e2776282f86d4e5ffaad8856c29", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/timer.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Quiz\Index.cshtml"
  
    Layout = "~/Views/Shared/_QuizLayout.cshtml";
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .pull-left {
        float: left!important;
    }
    #topbar > .pull-left {
        line-height: 98px;
    }
    .container {
        width: 2000px;
    }
    .quiz-nav {
        background-color: white;
        padding: 9px 10px;
        margin-right: 24px;
        font-family: ""Montserrat"", sans-serif;
        font-size: 11px;
        color: black;
        transition: background-color 0.5s ease;
        border-radius: 3px;
    }
    .title {
        color: white;
        text-align: center;
        padding: 20px 10px;
    }
    .wrapper {
        vertical-align: top;
        margin-left: auto;
        margin-right: auto;
        width: 960px;
    }
</style>
<header>
    <div class=""container"">
        <div id=""topbar"">
            <div class=""navigation wrapper pull-left"">
                <a href=""#"" class=""quiz-nav"">BACK</a>
                <a href=""#"" class=""quiz-nav"">SUBMIT</a>
            </div>
            <div class=""navigation title"">
                <h1>lmao</h1>
                <p id=""");
            WriteLiteral("demo\"></p>\n            </div>\n        </div>\n\n        </div>\n</header>\n\n<h1>Header</h1>\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f97ec7e870eb30b6fd3bf586c69f293f04faea8e5135", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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