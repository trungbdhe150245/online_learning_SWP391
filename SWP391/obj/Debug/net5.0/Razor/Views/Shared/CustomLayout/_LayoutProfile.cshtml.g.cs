#pragma checksum "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Shared\CustomLayout\_LayoutProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fdd1e6dc6b839192b7620e910c46d7fb2516e60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_CustomLayout__LayoutProfile), @"mvc.1.0.view", @"/Views/Shared/CustomLayout/_LayoutProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fdd1e6dc6b839192b7620e910c46d7fb2516e60", @"/Views/Shared/CustomLayout/_LayoutProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec3be411a2a9623845ef9e0a4ca5737761f0f38c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_CustomLayout__LayoutProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fdd1e6dc6b839192b7620e910c46d7fb2516e603785", async() => {
                WriteLiteral("\r\n\r\n\t<!-- META ============================================= -->\r\n\t<meta charset=\"utf-8\">\r\n\t<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n\t<meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 212, "\"", 222, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t<meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 248, "\"", 258, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t<meta name=\"robots\"");
                BeginWriteAttribute("content", " content=\"", 284, "\"", 294, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
	
	<!-- DESCRIPTION -->
	<meta name=""description"" content=""EduChamp : Education HTML Template"" />
	
	<!-- OG -->
	<meta property=""og:title"" content=""EduChamp : Education HTML Template"" />
	<meta property=""og:description"" content=""EduChamp : Education HTML Template"" />
	<meta property=""og:image""");
                BeginWriteAttribute("content", " content=\"", 602, "\"", 612, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
	<meta name=""format-detection"" content=""telephone=no"">
	
	<!-- FAVICONS ICON ============================================= -->
	<link rel=""icon"" href=""assets/images/favicon.ico"" type=""image/x-icon"" />
	<link rel=""shortcut icon"" type=""image/x-icon"" href=""assets/images/favicon.png"" />
	
	<!-- PAGE TITLE HERE ============================================= -->
	<title>");
#nullable restore
#line 27 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Shared\CustomLayout\_LayoutProfile.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
	
	<!-- MOBILE SPECIFIC ============================================= -->
	<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
	
	<!--[if lt IE 9]>
	<script src=""assets/js/html5shiv.min.js""></script>
	<script src=""assets/js/respond.min.js""></script>
	<![endif]-->
	
	<!-- All PLUGINS CSS ============================================= -->
	<link rel=""stylesheet"" type=""text/css"" href=""assets/css/assets.css"">
	
	<!-- TYPOGRAPHY ============================================= -->
	<link rel=""stylesheet"" type=""text/css"" href=""assets/css/typography.css"">
	
	<!-- SHORTCODES ============================================= -->
	<link rel=""stylesheet"" type=""text/css"" href=""assets/css/shortcodes/shortcodes.css"">
	
	<!-- STYLESHEETS ============================================= -->
	<link rel=""stylesheet"" type=""text/css"" href=""assets/css/style.css"">
	<link class=""skin"" rel=""stylesheet"" type=""text/css"" href=""assets/css/color/color-1.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fdd1e6dc6b839192b7620e910c46d7fb2516e607637", async() => {
                WriteLiteral("\r\n    <div>\r\n        ");
#nullable restore
#line 52 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Shared\CustomLayout\_LayoutProfile.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<!-- External JavaScripts -->
<script src=""assets/js/jquery.min.js""></script>
<script src=""assets/vendors/bootstrap/js/popper.min.js""></script>
<script src=""assets/vendors/bootstrap/js/bootstrap.min.js""></script>
<script src=""assets/vendors/bootstrap-select/bootstrap-select.min.js""></script>
<script src=""assets/vendors/bootstrap-touchspin/jquery.bootstrap-touchspin.js""></script>
<script src=""assets/vendors/magnific-popup/magnific-popup.js""></script>
<script src=""assets/vendors/counter/waypoints-min.js""></script>
<script src=""assets/vendors/counter/counterup.min.js""></script>
<script src=""assets/vendors/imagesloaded/imagesloaded.js""></script>
<script src=""assets/vendors/masonry/masonry.js""></script>
<script src=""assets/vendors/masonry/filter.js""></script>
<script src=""assets/vendors/owl-carousel/owl.carousel.js""></script>
<script src=""assets/js/functions.js""></script>
<script src=""assets/js/contact.js""></script>
<script src='assets/vendors/switcher/switcher.js'></script>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 72 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Shared\CustomLayout\_LayoutProfile.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("</html>\r\n");
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