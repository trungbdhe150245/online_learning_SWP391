#pragma checksum "C:\Users\Admin\Desktop\online_learning_SWP391-datdthe151528\Views\AccountManagement\ResetNewPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "424ef3b399cf349426ab5017f74cb50bf5083363"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountManagement_ResetNewPassword), @"mvc.1.0.view", @"/Views/AccountManagement/ResetNewPassword.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\online_learning_SWP391-datdthe151528\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\online_learning_SWP391-datdthe151528\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"424ef3b399cf349426ab5017f74cb50bf5083363", @"/Views/AccountManagement/ResetNewPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6a837e61f6c7e2776282f86d4e5ffaad8856c29", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountManagement_ResetNewPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("registration"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\Admin\Desktop\online_learning_SWP391-datdthe151528\Views\AccountManagement\ResetNewPassword.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "resetNewPassword";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "424ef3b399cf349426ab5017f74cb50bf50833634652", async() => {
                WriteLiteral("\n    <style>\n        h2, p {\n            color: black;\n        }\n\n        #xxx {\n            height: 50%;\n            display: flex;\n            justify-content: center;\n            align-items: center;\n        }\n    </style>\n\n");
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
            WriteLiteral("\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "424ef3b399cf349426ab5017f74cb50bf50833635857", async() => {
                WriteLiteral(@"
    <div class=""container"" id=""xx"">
        <div class=""row justify-content-center"">
            <div class=""col-md-12 text-center"">
                <h3>RESET PASSWORD</h3>
            </div>
            <div class=""col-md-6"" style=""float:none;margin:auto;"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "424ef3b399cf349426ab5017f74cb50bf50833636400", async() => {
                    WriteLiteral(@"
                    <div class=""form-group"" style=""margin-bottom: 5px;"">
                        <label for=""newPassword"" style=""font-weight: bold;"">Enter new Password: </label>
                        <div class=""input-group-append"">
                            <input type=""password"" name=""newPassword"" id=""newPassword"" class=""form-control"" aria-describedby=""emailHelp"" placeholder=""Enter Your Password"" />
                        </div>
                    </div>
                    <p style=""color: #666; font-weight: 400;"">The password should have atleast 8 characters</p>

                    <div class=""form-group"">
                        <label for=""confirmNewPassword"" style=""font-weight: bold;"">Confirm new Password: </label>
                        <input type=""password"" name=""confirmNewPassword"" id=""confirmNewPassword"" class=""form-control"" aria-describedby=""emailHelp"" placeholder=""Confirm Your Password"">
                    </div>
                    <div class=""form-group col-md-4 text-center"" style=""f");
                    WriteLiteral(@"loat:none;margin:auto;"">
                        <button type=""submit"" id=""sendBtn"" class="" btn btn-block mybtn btn-primary tx-tfm"" style=""background-color: #1db954;"">CONFIRM</button>
                    </div>

                    <div class=""form-group"">
                        <p class=""text-center""><a href=""#"" id=""signin"">Dont get email?</a></p>
                    </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            </div>\n\n        </div>\n    </div>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    $(function () {
        $(""form[name='registration']"").validate({
            rules: {
                password: {
                    required: true,
                    minlength: 8
                }
            },

            messages: {
                password: {
                    required: ""Please provide a password"",
                    minlength: ""Your password must be at least 8 characters long""
                },
            },

            submitHandler: function (form) {
                form.submit();
            }
        });
    });

    function password_show_hide(c) {
        var x = document.getElementById(c);
        var show_eye = document.getElementById(""show_eye"");
        var hide_eye = document.getElementById(""hide_eye"");
        hide_eye.classList.remove(""d-none"");
        if (x.type === ""password"") {
            x.type = ""text"";
            show_eye.style.display = ""none"";
            hide_eye.style.display = ""block"";
        } else {
            x.type = ""password"";");
            WriteLiteral("\n            show_eye.style.display = \"block\";\n            hide_eye.style.display = \"none\";\n        }\n    }\n</script>\n\n");
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
