#pragma checksum "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cf6dcb5046a97522f85a4e5d0768eb41a28d55c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quizs_QuizDetails), @"mvc.1.0.view", @"/Views/Quizs/QuizDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cf6dcb5046a97522f85a4e5d0768eb41a28d55c", @"/Views/Quizs/QuizDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54e882c67d784dd57ad5d07672f78e3d5358b785", @"/Views/_ViewImports.cshtml")]
    public class Views_Quizs_QuizDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SWP391.Models.ViewModels.Quiz_QuestionVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "QuestionBank", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "QuestionDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
  
    ViewData["Title"] = "QuizDetails";
    var mdo = "";
    var fat = "";
    var getbootstrap = "";
    Layout = "~/Views/Shared/UserLayout/_AdminLayout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Quiz</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.quiz.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
       Write(Html.DisplayFor(model => model.quiz.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.quiz.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
       Write(Html.DisplayFor(model => model.quiz.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.quiz.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
       Write(Html.DisplayFor(model => model.quiz.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.quiz.QuestionNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
       Write(Html.DisplayFor(model => model.quiz.QuestionNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.quiz.Topic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
       Write(Html.DisplayFor(model => model.quiz.Topic.TopicName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.quiz.QuizLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
       Write(Html.DisplayFor(model => model.quiz.QuizLevel.QuizLevelName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.quiz.QuizType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
       Write(Html.DisplayFor(model => model.quiz.QuizType.QuizTypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cf6dcb5046a97522f85a4e5d0768eb41a28d55c10295", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn btn-primary\">Edit</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
                           WriteLiteral(Model.quiz.QuizId);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cf6dcb5046a97522f85a4e5d0768eb41a28d55c12539", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn btn-success\">Back To List</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $('#exampleModal').on('show.bs.modal', function (event) {
            var button = $(event.relatedTarget) // Button that triggered the modal
            var recipient = button.data('whatever') // Extract info from data-* attributes
            // If necessary, you could initiate an AJAX request here (and then do the updating in a callback).
            // Update the modal's content. We'll use jQuery here, but you could use a data binding library or other methods instead.
            var modal = $(this)
            modal.find('.modal-title').text('New message to ' + recipient)
        })
    </script>
");
            }
            );
            WriteLiteral(@"
<h1>Danh Sách Quesiton</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Course
            </th>
            <th>
                Question Content
            </th>
            <th>
                Level
            </th>
            <th>
                Status
            </th>
            <th>
                Action
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 165 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
         foreach (var item in Model.list_question)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 168 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 170 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.Course.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 173 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 177 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.QuizLevel.QuizLevelName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 180 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
                     if (item.StatusId == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"fa fa-circle text-success\"> </i>\r\n");
#nullable restore
#line 183 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
#nullable restore
#line 184 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status.StatusValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cf6dcb5046a97522f85a4e5d0768eb41a28d55c17907", async() => {
                WriteLiteral("Detail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 187 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
                                                                                   WriteLiteral(item.QuestionId);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cf6dcb5046a97522f85a4e5d0768eb41a28d55c20371", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 188 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
                                                                           WriteLiteral(item.QuestionId);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 191 "D:\FPTLearning\Spring2022\SWP391\Week 8\Source Code\online_learning_SWP391\SWP391\Views\Quizs\QuizDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SWP391.Models.ViewModels.Quiz_QuestionVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
