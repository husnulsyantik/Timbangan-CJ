#pragma checksum "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8f6830091bd95f5b0e371a168b712a68646e2f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reprint_Index), @"mvc.1.0.view", @"/Views/Reprint/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reprint/Index.cshtml", typeof(AspNetCore.Views_Reprint_Index))]
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
#line 6 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8f6830091bd95f5b0e371a168b712a68646e2f7", @"/Views/Reprint/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2515a42b8435d9e8874c3fd6602c100dabfc8cca", @"/Views/_ViewImports.cshtml")]
    public class Views_Reprint_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<CJTimbangan.Models.Input>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::AspNetCore.Views_Reprint_Index.__Generated__PagerViewComponentTagHelper __PagerViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
  
    Layout = "~/Views/Shared/MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(204, 508, true);
            WriteLiteral(@"<script>
    function doNavigate() {
        window.location.href = document.getElementById(""UrlList"").value;
    }
</script>

<div class="""">
    <div class=""page-title"">
        <div class=""title_left"">
            <h3></h3>
        </div>


    </div>


    <div class=""clearfix""></div>

    <div class=""row"">
        <div class=""col-md-12 col-sm-12 col-xs-12"">
            <div class=""x_panel"">

                <ul class=""nav nav-tabs"">
                    <li><a data-toggle=""tab""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 712, "\"", 768, 3);
            WriteAttributeValue("", 722, "location.href=\'", 722, 15, true);
#line 31 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
WriteAttributeValue("", 737, Url.Action("Index","Report"), 737, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 766, "\';", 766, 2, true);
            EndWriteAttribute();
            BeginContext(769, 63, true);
            WriteLiteral(">Summary</a></li>\r\n                    <li><a data-toggle=\"tab\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 832, "\"", 888, 3);
            WriteAttributeValue("", 842, "location.href=\'", 842, 15, true);
#line 32 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
WriteAttributeValue("", 857, Url.Action("Index","Detail"), 857, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 886, "\';", 886, 2, true);
            EndWriteAttribute();
            BeginContext(889, 84, true);
            WriteLiteral(">Detail Report</a></li>\r\n                    <li class=\"active\"><a data-toggle=\"tab\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 973, "\"", 1030, 3);
            WriteAttributeValue("", 983, "location.href=\'", 983, 15, true);
#line 33 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
WriteAttributeValue("", 998, Url.Action("Index","Reprint"), 998, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 1028, "\';", 1028, 2, true);
            EndWriteAttribute();
            BeginContext(1031, 266, true);
            WriteLiteral(@">List Reprint</a></li>
                </ul>
                <br>

                <div class=""col-md-2 col-sm- col-xs-9 form-group pull-left"">
                    <select name class=""form-control"" id=""UrlList"" onchange=""doNavigate()"">
                        ");
            EndContext();
            BeginContext(1297, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8f6830091bd95f5b0e371a168b712a68646e2f76362", async() => {
                BeginContext(1354, 9, true);
                WriteLiteral("All Shift");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
                           WriteLiteral(Url.Action("Index", "Reprint"));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1372, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1398, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8f6830091bd95f5b0e371a168b712a68646e2f78506", async() => {
                BeginContext(1446, 7, true);
                WriteLiteral("Shift 1");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
                           WriteLiteral(Url.Action("Index", "Shift1c"));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1462, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1488, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8f6830091bd95f5b0e371a168b712a68646e2f710337", async() => {
                BeginContext(1536, 7, true);
                WriteLiteral("Shift 2");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
                           WriteLiteral(Url.Action("Index", "Shift2c"));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1552, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1578, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8f6830091bd95f5b0e371a168b712a68646e2f712169", async() => {
                BeginContext(1626, 7, true);
                WriteLiteral("Shift 3");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
                           WriteLiteral(Url.Action("Index", "Shift3c"));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1642, 1126, true);
            WriteLiteral(@"
                    </select>
                </div>
                <br>
                <br />
                <div class=""x_content"">
                    <div class=""table-responsive"">
                        <table class=""table table-striped jambo_table bulk_action"">
                            <thead>
                                <tr class=""headings"">

                                    <th class=""column-title"" style=""width: 18%"">Production Date</th>
                                    <th class=""column-title"" style=""width: 18%"">Printing Date</th>
                                    <th class=""column-title"" style=""width: 12%"">Product</th>
                                    <th class=""column-title"" style=""width: 12%"">Packaging</th>
                                    <th class=""column-title"" style=""width: 12%"">Lot Number</th>
                                    <th class=""column-title"" style=""width: 10%"">Shift</th>
                                    <th class=""column-title"" style=""");
            WriteLiteral("width: 10%\">Status</th>\r\n                            </thead>\r\n\r\n                            <tbody>\r\n");
            EndContext();
#line 63 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
                                   var odd = false; 

#line default
#line hidden
            BeginContext(2823, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 64 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
            BeginContext(2920, 39, true);
            WriteLiteral("                                    <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2959, "\"", 2997, 2);
#line 66 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
WriteAttributeValue("", 2967, odd ? "odd": "even", 2967, 22, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2989, "pointer", 2990, 8, true);
            EndWriteAttribute();
            BeginContext(2998, 57, true);
            WriteLiteral(">\r\n                                        <td class=\" \">");
            EndContext();
            BeginContext(3056, 47, false);
#line 67 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.tgl_produksi));

#line default
#line hidden
            EndContext();
            BeginContext(3103, 61, true);
            WriteLiteral("</td>\r\n                                        <td class=\" \">");
            EndContext();
            BeginContext(3165, 44, false);
#line 68 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.tgl_cetak));

#line default
#line hidden
            EndContext();
            BeginContext(3209, 61, true);
            WriteLiteral("</td>\r\n                                        <td class=\" \">");
            EndContext();
            BeginContext(3271, 41, false);
#line 69 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.barang));

#line default
#line hidden
            EndContext();
            BeginContext(3312, 61, true);
            WriteLiteral("</td>\r\n                                        <td class=\" \">");
            EndContext();
            BeginContext(3374, 42, false);
#line 70 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.kemasan));

#line default
#line hidden
            EndContext();
            BeginContext(3416, 61, true);
            WriteLiteral("</td>\r\n                                        <td class=\" \">");
            EndContext();
            BeginContext(3478, 41, false);
#line 71 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.lot_no));

#line default
#line hidden
            EndContext();
            BeginContext(3519, 61, true);
            WriteLiteral("</td>\r\n                                        <td class=\" \">");
            EndContext();
            BeginContext(3581, 40, false);
#line 72 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.shift));

#line default
#line hidden
            EndContext();
            BeginContext(3621, 61, true);
            WriteLiteral("</td>\r\n                                        <td class=\" \">");
            EndContext();
            BeginContext(3683, 41, false);
#line 73 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.status));

#line default
#line hidden
            EndContext();
            BeginContext(3724, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 75 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
                                    odd = !odd;
                                }

#line default
#line hidden
            BeginContext(3858, 169, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                        <nav aria-label=\"Input navigation example\">\r\n                            ");
            EndContext();
            BeginContext(4027, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d8f6830091bd95f5b0e371a168b712a68646e2f719989", async() => {
            }
            );
            __PagerViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Reprint_Index.__Generated__PagerViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__PagerViewComponentTagHelper);
#line 80 "C:\Users\Developer\source\repos\CJTimbangan\Views\Reprint\Index.cshtml"
__PagerViewComponentTagHelper.pagingList = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("paging-list", __PagerViewComponentTagHelper.pagingList, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4060, 142, true);
            WriteLiteral("\r\n                        </nav>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<CJTimbangan.Models.Input>> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:pager")]
        public class __Generated__PagerViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__PagerViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public ReflectionIT.Mvc.Paging.IPagingList pagingList { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("Pager", new { pagingList });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591
