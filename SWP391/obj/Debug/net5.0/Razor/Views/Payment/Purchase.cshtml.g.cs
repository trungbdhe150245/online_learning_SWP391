#pragma checksum "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Payment\Purchase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9357879eb36db04eb2c943c8201c41bb133acc85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Purchase), @"mvc.1.0.view", @"/Views/Payment/Purchase.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9357879eb36db04eb2c943c8201c41bb133acc85", @"/Views/Payment/Purchase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28373cf24ff85914d872a3f8f52a8e9604e8c163", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_Purchase : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SWP391.Models.Package>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("payment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Payment\Purchase.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-content bg-white"">
        <!-- inner page banner -->
        <div class=""page-banner ovbl-dark"" style=""background-image:url(assets/images/banner/banner1.jpg);"">
            <div class=""container"">
                <div class=""page-banner-entry"">
                    <h1 class=""text-white"">Payment</h1>
				 </div>
            </div>
        </div>
		<!-- Breadcrumb row -->
		<div class=""breadcrumb-row"">
			<div class=""container"">
				<ul class=""list-inline"">
					<li><a href=""#"">Home</a></li>
					<li>Payment</li>
				</ul>
			</div>
		</div>
		<!-- Breadcrumb row END -->
        <!-- inner page banner END -->
		<div class=""content-block"">
            <!-- About Us -->
			<div class=""section-area section-sp1"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9357879eb36db04eb2c943c8201c41bb133acc855596", async() => {
                WriteLiteral("\r\n                <div class=\"container\">\r\n                    <h2 class=\"title\">Complete Payment</h2>\r\n\t\t\t\t\t <div class=\"row\">\r\n                         \r\n\t\t\t\t\t\t<div class=\"col-lg-8 col-md-7 col-sm-12\">\r\n");
                WriteLiteral("                            <div class=\"braintree-placeholder\">&nbsp;</div>\r\n                            ");
#nullable restore
#line 51 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Payment\Purchase.cshtml"
                       Write(Html.HiddenFor(n => n.PackageId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"card\" style=\"margin-top:-5px\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 54 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Payment\Purchase.cshtml"
                                      Write(Model.PackageName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 55 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Payment\Purchase.cshtml"
                                    Write(Model.PackageDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
                WriteLiteral("                    <p class=\"card-text\"><small class=\"text-muted\">Price: ");
#nullable restore
#line 57 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Payment\Purchase.cshtml"
                                                                     Write(Model.PackagePrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small></p>\r\n                </div>\r\n");
                WriteLiteral("            </div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-lg-4 col-md-5 col-sm-12 m-b30\">\r\n");
                WriteLiteral(@"                                <section>
                                <div class=""bt-drop-in-wrapper"">
                                <div id=""bt-dropin""></div>
                                </div>
                                </section>
                                <button class=""btn btn-success"" style=""display:flex"" type=""submit""><span>Confirm payment - $");
#nullable restore
#line 85 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Payment\Purchase.cshtml"
                                                                                                                       Write(Model.PackagePrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></button></div>\r\n                                <div>\r\n");
                WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n<script src=\"https://js.braintreegateway.com/web/dropin/1.22.0/js/dropin.min.js\"></script>\r\n<script>\r\n    var client_token = \"");
#nullable restore
#line 98 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Payment\Purchase.cshtml"
                   Write(ViewBag.ClientToken);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
    var form = document.querySelector('#payment-form');

    braintree.dropin.create({
        authorization: client_token,
        container: '#bt-dropin'
    }, function (createErr, instance) {
        form.addEventListener('submit', function (event) {
            event.preventDefault();

            instance.requestPaymentMethod(function (err, payload) {
                if (err) {
                    return;
                }
              
                document.querySelector('#nonce').value = payload.nonce;
                form.submit();
            });
        });
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SWP391.Models.Package> Html { get; private set; }
    }
}
#pragma warning restore 1591
