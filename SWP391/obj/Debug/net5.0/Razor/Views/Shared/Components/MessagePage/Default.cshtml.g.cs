#pragma checksum "D:\FPTLearning\Spring2022\SWP391\Week 9\Source Code\online_learning_SWP391\SWP391\Views\Shared\Components\MessagePage\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06d33903efd45cc6c0093eff0e1fb6c2f6ebf972"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MessagePage_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MessagePage/Default.cshtml")]
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
#line 1 "D:\FPTLearning\Spring2022\SWP391\Week 9\Source Code\online_learning_SWP391\SWP391\Views\_ViewImports.cshtml"
using SWP391;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FPTLearning\Spring2022\SWP391\Week 9\Source Code\online_learning_SWP391\SWP391\Views\_ViewImports.cshtml"
using SWP391.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06d33903efd45cc6c0093eff0e1fb6c2f6ebf972", @"/Views/Shared/Components/MessagePage/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54e882c67d784dd57ad5d07672f78e3d5358b785", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MessagePage_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<XTLASPNET.MessagePage.Message>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\FPTLearning\Spring2022\SWP391\Week 9\Source Code\online_learning_SWP391\SWP391\Views\Shared\Components\MessagePage\Default.cshtml"
  
    Layout = "~/Views/Shared/CustomLayout/_LayoutRedirect.cshtml";
    ViewData["Title"] = @Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 6 "D:\FPTLearning\Spring2022\SWP391\Week 9\Source Code\online_learning_SWP391\SWP391\Views\Shared\Components\MessagePage\Default.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            WriteLiteral("<p>");
#nullable restore
#line 9 "D:\FPTLearning\Spring2022\SWP391\Week 9\Source Code\online_learning_SWP391\SWP391\Views\Shared\Components\MessagePage\Default.cshtml"
Write(Html.Raw(Model.HtmlContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n<p>Go to <a");
            BeginWriteAttribute("href", " href=\"", 312, "\"", 337, 1);
#nullable restore
#line 10 "D:\FPTLearning\Spring2022\SWP391\Week 9\Source Code\online_learning_SWP391\SWP391\Views\Shared\Components\MessagePage\Default.cshtml"
WriteAttributeValue("", 319, Model.UrlRedirect, 319, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 10 "D:\FPTLearning\Spring2022\SWP391\Week 9\Source Code\online_learning_SWP391\SWP391\Views\Shared\Components\MessagePage\Default.cshtml"
                                 Write(Model.UrlRedirect);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<XTLASPNET.MessagePage.Message> Html { get; private set; }
    }
}
#pragma warning restore 1591
