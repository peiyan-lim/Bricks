#pragma checksum "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0b4d72eb96a592d74dafe37bc00bc8bfda4644d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Financial_Index), @"mvc.1.0.view", @"/Views/Financial/Index.cshtml")]
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
#line 1 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\_ViewImports.cshtml"
using BricksMeatballs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\_ViewImports.cshtml"
using BricksMeatballs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0b4d72eb96a592d74dafe37bc00bc8bfda4644d", @"/Views/Financial/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04fb86f506fe1fb86431f300c86d10c2af5b57df", @"/Views/_ViewImports.cshtml")]
    public class Views_Financial_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BricksMeatballs.Models.FinancialModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Financial Calculator</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <h4>Calculated Results</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            TDSR Limit\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Model.TDSRLimitDisplay());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            MSR Limit\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Model.MSRLimitDisplay());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            Limit After Expenses\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Model.MaxMonthlyPaymentDisplay());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            Maximum Bank Loan\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Model.MaxBankLoanDisplay());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            LTV\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Model.LTVDisplay());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            True Max\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 60 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Model.TrueMaxDisplay());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            BSD\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Model.BSDDisplay());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ABSD (if any)\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Model.ABSDDisplay());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <hr />\r\n    <h4>Entered Details</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 86 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicantStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 89 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayFor(model => model.ApplicantStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 94 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 97 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 102 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Residency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayFor(model => model.Residency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 110 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.NumProperties));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 113 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayFor(model => model.NumProperties));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 118 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.NumLoans));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 121 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayFor(model => model.NumLoans));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 126 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.MonthlyFixedIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Model.MonthlyFixedIncomeDisplay());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 134 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.MonthlyVariableIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 137 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Model.MonthlyVariableIncomeDisplay());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 142 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Cash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 145 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Model.CashDisplay());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 150 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 153 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Model.CpfDisplay());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 158 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 161 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Model.CreditDisplay());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 166 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.CarLoan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 169 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Model.CarLoanDisplay());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 174 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.OtherHomeLoan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 177 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Model.OtherHomeLoanDisplay());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 182 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.OtherLoan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 185 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Model.OtherLoanDisplay());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 190 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.PropertyType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 193 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayFor(model => model.PropertyType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 198 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.LoanTenure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 201 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Model.LoanTenureDisplay());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 206 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.InterestRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 209 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
       Write(Model.InterestRateDisplay());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 215 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\Views\Financial\Index.cshtml"
Write(Html.ActionLink("Edit", "Edit", @Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0b4d72eb96a592d74dafe37bc00bc8bfda4644d18398", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BricksMeatballs.Models.FinancialModel> Html { get; private set; }
    }
}
#pragma warning restore 1591