#pragma checksum "C:\Users\corli\Source\Repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Graph\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aadad27ad63d6ef7d7a0396d9594ddffb28d9de7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Graph_Index), @"mvc.1.0.view", @"/Views/Graph/Index.cshtml")]
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
#line 1 "C:\Users\corli\Source\Repos\Bricks\BricksMeatballs\BricksMeatballs\Views\_ViewImports.cshtml"
using BricksMeatballs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\corli\Source\Repos\Bricks\BricksMeatballs\BricksMeatballs\Views\_ViewImports.cshtml"
using BricksMeatballs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aadad27ad63d6ef7d7a0396d9594ddffb28d9de7", @"/Views/Graph/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04fb86f506fe1fb86431f300c86d10c2af5b57df", @"/Views/_ViewImports.cshtml")]
    public class Views_Graph_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\corli\Source\Repos\Bricks\BricksMeatballs\BricksMeatballs\Views\Graph\Index.cshtml"
   ViewData["Title"] = "Index";
                Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>

<div id=""chart_div""></div>
<script type=""text/javascript"">google.charts.load('current', {
        packages: ['corechart', 'bar']
    });
    google.charts.setOnLoadCallback(LoadData);

    function LoadData() {
        $.ajax({

            url: 'Graph/GraphChart',
            dataType: ""json"",
            type: ""GET"",
            error: function (xhr, status, error) {
                var err = eval(""("" + xhr.responseText + "")"");
                toastr.error(err.message);
            },
            success: function (data) {
                GraphChart(data);
                return false;
            }
        });
        return false;
    }

    function GraphChart(data) {
        var tdata = new google.visualization.DataTable();
        tdata.addColumn('number', 'saleTime');
        tdata.addColumn('number', 'averagePrice');
        for (var i = 0; i < data.length; i++) {
            tdata.addRow([data[i].saleTime, data[");
            WriteLiteral(@"i].averagePrice]);
        }

        var options = {
            title: 'Average Price of Housing',
            chartArea: {
                width: '50%'
            },
            colors: ['#e0440e'],
            hAxis: {
                title: 'Date'
            },
            vAxis: {
                title: 'Average Price'
            }
        };
        var chart = new google.visualization.LineChart(document.getElementById('chart_div'));

        chart.draw(tdata, options);
        return false;
    }</script>");
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
