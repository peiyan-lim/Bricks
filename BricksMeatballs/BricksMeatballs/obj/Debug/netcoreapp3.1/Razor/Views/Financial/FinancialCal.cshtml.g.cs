#pragma checksum "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a431def0596e42c63be7543f71cc8fd5a6485fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Financial_FinancialCal), @"mvc.1.0.view", @"/Views/Financial/FinancialCal.cshtml")]
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
#line 1 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\_ViewImports.cshtml"
using BricksMeatballs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\_ViewImports.cshtml"
using BricksMeatballs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a431def0596e42c63be7543f71cc8fd5a6485fa", @"/Views/Financial/FinancialCal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04fb86f506fe1fb86431f300c86d10c2af5b57df", @"/Views/_ViewImports.cshtml")]
    public class Views_Financial_FinancialCal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BricksMeatballs.Models.FinancialModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
  
    ViewData["Title"] = "FinancialCal";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
  
    ViewBag.Title = "Calculator";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Calculator</h2>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>FinancialModel</h4>\r\n        <hr />\r\n        ");
#nullable restore
#line 23 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
       Write(Html.LabelFor(model => model.monthlyFixedIncome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 27 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.EditorFor(model => model.monthlyFixedIncome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 28 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.ValidationMessageFor(model => model.monthlyFixedIncome, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
       Write(Html.LabelFor(model => model.monthlyVariableIncome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 35 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.EditorFor(model => model.monthlyVariableIncome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 36 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.ValidationMessageFor(model => model.monthlyVariableIncome, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
       Write(Html.LabelFor(model => model.cashTowardsDownPayment, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 43 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.EditorFor(model => model.cashTowardsDownPayment, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 44 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.ValidationMessageFor(model => model.cashTowardsDownPayment, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 49 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
       Write(Html.LabelFor(model => model.cpfOrdinaryAccount, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 51 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.EditorFor(model => model.cpfOrdinaryAccount, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 52 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.ValidationMessageFor(model => model.cpfOrdinaryAccount, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
       Write(Html.LabelFor(model => model.creditMinPayments, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 59 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.EditorFor(model => model.creditMinPayments, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 60 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.ValidationMessageFor(model => model.creditMinPayments, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
       Write(Html.LabelFor(model => model.carLoan, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 67 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.EditorFor(model => model.carLoan, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 68 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.ValidationMessageFor(model => model.carLoan, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 73 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
       Write(Html.LabelFor(model => model.otherHomeLoan, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 75 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.EditorFor(model => model.otherHomeLoan, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 76 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.ValidationMessageFor(model => model.otherHomeLoan, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 81 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
       Write(Html.LabelFor(model => model.otherLoan, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 83 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.EditorFor(model => model.otherLoan, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 84 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.ValidationMessageFor(model => model.otherLoan, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 89 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
       Write(Html.LabelFor(model => model.propertyType, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 91 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.EditorFor(model => model.propertyType, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 92 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.ValidationMessageFor(model => model.propertyType, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 97 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
       Write(Html.LabelFor(model => model.loanTenure, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 99 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.EditorFor(model => model.loanTenure, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 100 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.ValidationMessageFor(model => model.loanTenure, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 105 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
       Write(Html.LabelFor(model => model.maximumAffordableHousePrice, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 107 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.EditorFor(model => model.maximumAffordableHousePrice, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 108 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.ValidationMessageFor(model => model.maximumAffordableHousePrice, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 113 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
       Write(Html.LabelFor(model => model.age, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 115 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.EditorFor(model => model.age, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 116 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
           Write(Html.ValidationMessageFor(model => model.age, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 121 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
       Write(Html.LabelFor(model => model.residency, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                <div class=\"checkbox\">\r\n                    ");
#nullable restore
#line 124 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
               Write(Html.EditorFor(model => model.residency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 125 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
               Write(Html.ValidationMessageFor(model => model.residency, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </div>
    </div>
");
#nullable restore
#line 136 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 139 "C:\Users\Sripriya\source\repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Financial\FinancialCal.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
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
