#pragma checksum "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\AccountManagement\userProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "347fb76ccef192dde0f99f7027a8a37eaabfa20d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountManagement_userProfile), @"mvc.1.0.view", @"/Views/AccountManagement/userProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"347fb76ccef192dde0f99f7027a8a37eaabfa20d", @"/Views/AccountManagement/userProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b74afac4cba0d6d4237ee0870aa916fc45131b23", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountManagement_userProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/userlogo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\FPTLearning\Spring2022\SWP391\Week 3\Source Code\SWP391-OnlineLearning-Platform\Views\AccountManagement\userProfile.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "userProfile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    body {
        background: #F1F3FA;
    }

    /* Profile container */
    .profile {
        margin: 20px 0;
    }

    /* Profile sidebar */
    .profile-sidebar {
        padding: 20px 0 10px 0;
        background: #fff;
    }

    .profile-userpic img {
        float: none;
        margin: 0 auto;
        width: 50%;
        height: 50%;
        -webkit-border-radius: 50% !important;
        -moz-border-radius: 50% !important;
        border-radius: 50% !important;
    }

    .profile-usertitle {
        text-align: center;
        margin-top: 20px;
    }

    .profile-usertitle-name {
        color: #5a7391;
        font-size: 16px;
        font-weight: 600;
        margin-bottom: 7px;
    }

    .profile-usertitle-job {
        text-transform: uppercase;
        color: #5b9bd1;
        font-size: 12px;
        font-weight: 600;
        margin-bottom: 15px;
    }

    .profile-userbuttons {
        text-align: center;
        margin-top: 10p");
            WriteLiteral(@"x;
    }

        .profile-userbuttons .btn {
            text-transform: uppercase;
            font-size: 11px;
            font-weight: 600;
            padding: 6px 15px;
            margin-right: 5px;
        }

            .profile-userbuttons .btn:last-child {
                margin-right: 0px;
            }

    .profile-usermenu {
        margin-top: 30px;
    }

        .profile-usermenu ul li {
            border-bottom: 1px solid #f0f4f7;
        }

            .profile-usermenu ul li:last-child {
                border-bottom: none;
            }

            .profile-usermenu ul li a {
                color: #93a3b5;
                font-size: 14px;
                font-weight: 400;
            }

                .profile-usermenu ul li a i {
                    margin-right: 8px;
                    font-size: 14px;
                }

                .profile-usermenu ul li a:hover {
                    background-color: #fafcfd;
                    color");
            WriteLiteral(@": #5b9bd1;
                }

            .profile-usermenu ul li.active {
                border-bottom: none;
            }

                .profile-usermenu ul li.active a {
                    color: #5b9bd1;
                    background-color: #f6f9fb;
                    border-left: 2px solid #5b9bd1;
                    margin-left: -2px;
                }

    /* Profile Content */
    .profile-content {
        padding: 20px;
        background: #fff;
        min-height: 460px;
    }
</style>

<div class=""container"">
    <div class=""row profile"">
        <div class=""col-md-3"">
            <div class=""profile-sidebar"">
                <!-- SIDEBAR USERPIC -->
                <div class=""profile-userpic"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "347fb76ccef192dde0f99f7027a8a37eaabfa20d7222", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <!-- END SIDEBAR USERPIC -->
                <!-- SIDEBAR USER TITLE -->
                <div class=""profile-usertitle"">
                    <div class=""profile-usertitle-name"">
                        Marcus Doe
                    </div>
                    <div class=""profile-usertitle-job"">
                        Student
                    </div>
                </div>
                <!-- END SIDEBAR USER TITLE -->
                <!-- SIDEBAR BUTTONS -->
                <div class=""profile-userbuttons"">
                    <button type=""button"" class=""btn btn-success btn-sm"">Follow</button>
                    <button type=""button"" class=""btn btn-danger btn-sm"">Message</button>
                </div>
                <!-- END SIDEBAR BUTTONS -->
                <!-- SIDEBAR MENU -->
                <div class=""profile-usermenu"">
                    <ul class=""nav"">
                        <li>
                            <a href=""#"">
     ");
            WriteLiteral(@"                           <i class=""glyphicon glyphicon-home""></i>
                                Profile
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                <i class=""glyphicon glyphicon-ok""></i>
                                Edit Profile
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                <i class=""glyphicon glyphicon-flag""></i>
                                Change Password
                            </a>
                        </li>
                    </ul>
                </div>
                <!-- END MENU -->
            </div>
        </div>
        <div class=""col-md-9"">
            <div class=""profile-content"">
                <table class=""table table-hover"">
                    <tr>
                        <td>User Name</td>
                ");
            WriteLiteral(@"        <td style=""font-weight:bold"">dtd91</td>
                    </tr>
                    <tr>
                        <td>Full Name</td>
                        <td style=""font-weight:bold"">Tien Dat</td>
                    </tr>
                    <tr>
                        <td>Date of birth</td>
                        <td style=""font-weight:bold"">9th October 2001</td>
                    </tr>
                    <tr>
                        <td>Phone</td>
                        <td style=""font-weight:bold"">038********</td>
                    </tr>
                    <tr>
                        <td>Gender</td>
                        <td style=""font-weight:bold"">Male</td>
                    </tr>
                </table>
                <button style=""margin-left:20%"" type=""button"" class=""btn btn-secondary"">Edit Your Profile</button>

            </div>

        </div>
    </div>
</div>");
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
