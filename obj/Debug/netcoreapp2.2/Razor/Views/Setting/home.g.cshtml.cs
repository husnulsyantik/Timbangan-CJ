#pragma checksum "C:\Users\Developer\source\repos\CJTimbangan\Views\Setting\home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7634b0fb5951caad9866390a779c0012baa80b99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Setting_home), @"mvc.1.0.view", @"/Views/Setting/home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Setting/home.cshtml", typeof(AspNetCore.Views_Setting_home))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7634b0fb5951caad9866390a779c0012baa80b99", @"/Views/Setting/home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2515a42b8435d9e8874c3fd6602c100dabfc8cca", @"/Views/_ViewImports.cshtml")]
    public class Views_Setting_home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<CJTimbangan.Models.Setting>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Setting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditTimbangan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Developer\source\repos\CJTimbangan\Views\Setting\home.cshtml"
  
    Layout = "~/Views/Shared/MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(103, 1933, true);
            WriteLiteral(@"<div class="""">
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
                            <table class=""table table-striped jambo_table bulk_action"">
                                <thead>
                                    <tr class=""headings"">

                                        <th class=""column-title"" style=""width: 10%"">ID Controller</th>
                                        <th class=""column-title"" style=""width: 10%"">Type Controller</th>
                                        <th class=""column-title"" ");
            WriteLiteral(@"style=""width: 10%"">IP Controller</th>
                                        <th class=""column-title"" style=""width: 10%"">ID Printer</th>
                                        <th class=""column-title"" style=""width: 10%"">Type Controller</th>
                                        <th class=""column-title"" style=""width: 10%"">IP Printer</th>
                                        <th class=""column-title"" style=""width: 10%"">ID Scale</th>
                                        <th class=""column-title"" style=""width: 10%"">Type Scale</th>
                                        <th class=""column-title"" style=""width: 10%"">Product</th>
                                        <th class=""column-title no-link last"" style=""width: 10%""><span class=""nobr"">Action</span></th>
                                    </tr>
                                </thead>

                                <tbody>
");
            EndContext();
#line 40 "C:\Users\Developer\source\repos\CJTimbangan\Views\Setting\home.cshtml"
                                       var odd = false; 

#line default
#line hidden
            BeginContext(2095, 36, true);
            WriteLiteral("                                    ");
            EndContext();
#line 41 "C:\Users\Developer\source\repos\CJTimbangan\Views\Setting\home.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            BeginContext(2200, 43, true);
            WriteLiteral("                                        <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2243, "\"", 2281, 2);
#line 43 "C:\Users\Developer\source\repos\CJTimbangan\Views\Setting\home.cshtml"
WriteAttributeValue("", 2251, odd ? "odd": "even", 2251, 22, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2273, "pointer", 2274, 8, true);
            EndWriteAttribute();
            BeginContext(2282, 63, true);
            WriteLiteral(">\r\n\r\n                                            <td class=\" \">");
            EndContext();
            BeginContext(2346, 48, false);
#line 45 "C:\Users\Developer\source\repos\CJTimbangan\Views\Setting\home.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.id_controller));

#line default
#line hidden
            EndContext();
            BeginContext(2394, 65, true);
            WriteLiteral("</td>\r\n                                            <td class=\" \">");
            EndContext();
            BeginContext(2460, 50, false);
#line 46 "C:\Users\Developer\source\repos\CJTimbangan\Views\Setting\home.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.type_controller));

#line default
#line hidden
            EndContext();
            BeginContext(2510, 65, true);
            WriteLiteral("</td>\r\n                                            <td class=\" \">");
            EndContext();
            BeginContext(2576, 48, false);
#line 47 "C:\Users\Developer\source\repos\CJTimbangan\Views\Setting\home.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.ip_controller));

#line default
#line hidden
            EndContext();
            BeginContext(2624, 65, true);
            WriteLiteral("</td>\r\n                                            <td class=\" \">");
            EndContext();
            BeginContext(2690, 45, false);
#line 48 "C:\Users\Developer\source\repos\CJTimbangan\Views\Setting\home.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.id_printer));

#line default
#line hidden
            EndContext();
            BeginContext(2735, 65, true);
            WriteLiteral("</td>\r\n                                            <td class=\" \">");
            EndContext();
            BeginContext(2801, 47, false);
#line 49 "C:\Users\Developer\source\repos\CJTimbangan\Views\Setting\home.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.type_printer));

#line default
#line hidden
            EndContext();
            BeginContext(2848, 65, true);
            WriteLiteral("</td>\r\n                                            <td class=\" \">");
            EndContext();
            BeginContext(2914, 45, false);
#line 50 "C:\Users\Developer\source\repos\CJTimbangan\Views\Setting\home.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.ip_printer));

#line default
#line hidden
            EndContext();
            BeginContext(2959, 65, true);
            WriteLiteral("</td>\r\n                                            <td class=\" \">");
            EndContext();
            BeginContext(3025, 47, false);
#line 51 "C:\Users\Developer\source\repos\CJTimbangan\Views\Setting\home.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.id_dig_scale));

#line default
#line hidden
            EndContext();
            BeginContext(3072, 65, true);
            WriteLiteral("</td>\r\n                                            <td class=\" \">");
            EndContext();
            BeginContext(3138, 49, false);
#line 52 "C:\Users\Developer\source\repos\CJTimbangan\Views\Setting\home.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.type_dig_scale));

#line default
#line hidden
            EndContext();
            BeginContext(3187, 65, true);
            WriteLiteral("</td>\r\n                                            <td class=\" \">");
            EndContext();
            BeginContext(3253, 41, false);
#line 53 "C:\Users\Developer\source\repos\CJTimbangan\Views\Setting\home.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.barang));

#line default
#line hidden
            EndContext();
            BeginContext(3294, 119, true);
            WriteLiteral("</td>\r\n                                            <td class=\" last\">\r\n                                                ");
            EndContext();
            BeginContext(3413, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7634b0fb5951caad9866390a779c0012baa80b9912137", async() => {
                BeginContext(3492, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\Developer\source\repos\CJTimbangan\Views\Setting\home.cshtml"
                                                                                                         WriteLiteral(item.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3500, 52, true);
            WriteLiteral(" |\r\n                                                ");
            EndContext();
            BeginContext(3552, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7634b0fb5951caad9866390a779c0012baa80b9914777", async() => {
                BeginContext(3621, 6, true);
                WriteLiteral("Delete");
                EndContext();
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
#line 56 "C:\Users\Developer\source\repos\CJTimbangan\Views\Setting\home.cshtml"
                                                                                               WriteLiteral(item.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3631, 100, true);
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 59 "C:\Users\Developer\source\repos\CJTimbangan\Views\Setting\home.cshtml"
                                        odd = !odd;
                                    }

#line default
#line hidden
            BeginContext(3823, 220, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<CJTimbangan.Models.Setting>> Html { get; private set; }
    }
}
#pragma warning restore 1591