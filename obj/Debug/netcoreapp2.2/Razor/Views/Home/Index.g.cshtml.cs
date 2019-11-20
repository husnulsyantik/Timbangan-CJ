#pragma checksum "C:\Users\Developer\source\repos\CJTimbangan\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d679d7d6bb42c03b0a177d67d2c98e19591a9206"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Developer\source\repos\CJTimbangan\Views\_ViewImports.cshtml"
using CJTimbangan;

#line default
#line hidden
#line 2 "C:\Users\Developer\source\repos\CJTimbangan\Views\_ViewImports.cshtml"
using CJTimbangan.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d679d7d6bb42c03b0a177d67d2c98e19591a9206", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2515a42b8435d9e8874c3fd6602c100dabfc8cca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<CJTimbangan.Models.Input>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendors/jquery/canvasjs.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "C:\Users\Developer\source\repos\CJTimbangan\Views\Home\Index.cshtml"
  
Layout = "~/Views/Shared/MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(162, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d679d7d6bb42c03b0a177d67d2c98e19591a92063721", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(218, 988, true);
            WriteLiteral(@"
<div class="""">
    <div class=""page-title"">
        

        <div class=""clearfix""></div>
        <div class=""row"">
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>List Scale</h2>
                        <ul class=""nav navbar-right panel_toolbox""></ul>
                        <div class=""clearfix""></div>
                    </div>

                    <div class=""x_content"">
                        <div class=""table-responsive"">
                            <div id=""chartContainer"" style=""height: 200px;""></div>


                            <script type=""text/javascript"">
                            </script>

                        </div>
                    </div>
                    <div id=""chartContainer"" style=""height: 200px;""></div>

                    <script type=""text/javascript"">
                        //var result = ");
            EndContext();
            BeginContext(1207, 28, false);
#line 35 "C:\Users\Developer\source\repos\CJTimbangan\Views\Home\Index.cshtml"
                                  Write(Html.Raw(ViewBag.DataPoints));

#line default
#line hidden
            EndContext();
            BeginContext(1235, 2427, true);
            WriteLiteral(@";
                        var dataPoints =[];
                        var chart = new CanvasJS.Chart(""chartContainer"", {
                            theme: ""light2"",
                            zoomEnabled: true,
                            animationEnabled: true,
                            title: {
                                text: ""Report Data""
                            },
                            data: [
                                {
                                    type: ""line"",
                                    xValueType : ""dateTime"",
                                    xValueFormatString: ""DD-MM-YYYY HH:mm:ss"",
                                    showInLegend : true,
                                    dataPoints: dataPoints,
                                }
                            ]
                        });

                        $(function () {
                            chart.render();

                            setTimeout(getData, 1000);
     ");
            WriteLiteral(@"                   });
                        function getData() {
                            $.ajax({
                                url: ""home/GetRealTimeData"",
                                dataType : 'JSON',
                                success: function (d) {
                                    dataPoints = [];
                                    //var xdataPoints = [];
                                    $.each(d, function (idx, dt) {
                                        var timeStamp = new Date(dt.tgl_cetak);
                                        var time = { v: timeStamp, f: moment(timeStamp).format('D-M-Y HH:mm:ss') };
                                        var val = dt.weight;
                                        dataPoints.push({ label: dt.tgl_cetak, y: dt.weight });
                                    })
                                    chart.options.data[0].dataPoints = dataPoints;
                                    chart.render();
                            ");
            WriteLiteral(@"        setTimeout(getData, 1000);
                                }
                            });
                            //$.get('home/GetRealTimeData', function (d) {
                            //});
                        }
                    </script>



                </div>
            </div>
            </div>
        </div>
    </div>
</div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<CJTimbangan.Models.Input>> Html { get; private set; }
    }
}
#pragma warning restore 1591