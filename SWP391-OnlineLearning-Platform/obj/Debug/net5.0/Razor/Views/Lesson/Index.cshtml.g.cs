#pragma checksum "E:\FPTLearning\Spring2022\SWP391\Week3\SourceCode\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Lesson\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c50d43d800ffe09a508545c67af54b1301eb75ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lesson_Index), @"mvc.1.0.view", @"/Views/Lesson/Index.cshtml")]
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
#line 1 "E:\FPTLearning\Spring2022\SWP391\Week3\SourceCode\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\FPTLearning\Spring2022\SWP391\Week3\SourceCode\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c50d43d800ffe09a508545c67af54b1301eb75ac", @"/Views/Lesson/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cc414232cb72a548af1b9bdfef0c3bcad4d1fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Lesson_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\FPTLearning\Spring2022\SWP391\Week3\SourceCode\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Lesson\Index.cshtml"
  
    Layout = "~/Views/Shared/_SharedLayout.cshtml";
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<style>
    video {
        width: 100%;
        max-height: 100%;
    }
</style>
<div class=""page-heading text-center"">
    <h2>SINGLE COURSE</h2>
</div>
<div class=""container-fluid"">
    <div class=""col-md-9"">
        <div class=""embed-responsive-item"">
");
            WriteLiteral(@"            <video id=""my-video""
                   class=""video-js""
                   controls
                   preload=""auto""
                   width=""full""
                   height=""full""
                   poster=""MY_VIDEO_POSTER.jpg""
                   data-setup=""{}"">
                <source src=""https://drive.google.com/u/0/uc?id=1Fs7-iicL37cLXndyMEO7vi4wP66J0nai&export=download"" type=""video/mp4"" />
                <source src=""MY_VIDEO.webm"" type=""video/webm"" />
                <p class=""vjs-no-js"">
                    To view this video please enable JavaScript, and consider upgrading to a
                    web browser that
                    <a href=""https://drive.google.com/file/d/1gvv9KhO42kNGxS_uRSKKPDP9SIoFTC2h/preview"" target=""_blank"">supports HTML5 video</a>
                </p>
            </video>

        </div>
        <p class=""class-details"">
            <span class=""lessons""><i class=""zmdi zmdi-assignment""></i>12 LESSONS</span>
            <span class=""durati");
            WriteLiteral(@"on""><i class=""zmdi zmdi-time""></i>3:15h</span>
            <span class=""views""><i class=""zmdi zmdi-eye""></i>2241 VIEWS</span>
            <span class=""tag""><i class=""zmdi zmdi-label""></i>ADOBE PHOTOSHOP</span>
        </p>
        <h3 class=""text-left"">lmao</h3>
    </div>
    <div class=""col-md-3"">
        <div class=""categories"">
            <ul>
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
                <li><a href=""#"">Language");
            WriteLiteral("s (83)</a></li>\r\n                <li><a href=\"#\">SEO (39)</a></li>\r\n                <li><a href=\"#\">Marketing (44)</a></li>\r\n                <li><a href=\"#\">Video Production (33)</a></li>\r\n            </ul>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
