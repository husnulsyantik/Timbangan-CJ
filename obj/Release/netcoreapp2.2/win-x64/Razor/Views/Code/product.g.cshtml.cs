#pragma checksum "C:\Users\Developer\source\repos\CJTimbangan\Views\Code\product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afc2aedf381bf81e7f89252759bb6a269c3fd6fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Code_product), @"mvc.1.0.view", @"/Views/Code/product.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Code/product.cshtml", typeof(AspNetCore.Views_Code_product))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afc2aedf381bf81e7f89252759bb6a269c3fd6fe", @"/Views/Code/product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2515a42b8435d9e8874c3fd6602c100dabfc8cca", @"/Views/_ViewImports.cshtml")]
    public class Views_Code_product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<CJTimbangan.Models.Setting>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Code", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Addproduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Developer\source\repos\CJTimbangan\Views\Code\product.cshtml"
  
Layout = "~/Views/Shared/MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(99, 402, true);
            WriteLiteral(@"<div class="""">
    <div class=""page-title"">
        

        <div class=""clearfix""></div>
        <div class=""row"">
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>List Product</h2>
                        <ul class=""nav navbar-right panel_toolbox"">
                    <li>");
            EndContext();
            BeginContext(501, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afc2aedf381bf81e7f89252759bb6a269c3fd6fe5086", async() => {
                BeginContext(550, 35, true);
                WriteLiteral("<i class=\"fa fa-plus\"></i> Add Data");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(589, 1084, true);
            WriteLiteral(@"</li>
                </ul>
                <div class=""clearfix""></div>
                </div>

                <div class=""x_content"">
                    <div class=""table-responsive"">
                        <table class=""table table-striped jambo_table bulk_action"">
                        <thead>
                            <tr class=""headings"">
                                  
                                <th class=""column-title"" style=""width: 10%"">Product</th>
                                <th class=""column-title"" style=""width: 10%"">LOT Number</th>
                                <th class=""column-title"" style=""width: 10%"">Packaging</th>
                                <th class=""column-title"" style=""width: 10%"">Counter</th>
                                <th class=""column-title"" style=""width: 10%"">Tare</th>
                                <th class=""column-title no-link last"" style=""width: 10%""><span class=""nobr"">Action</span></th>
                            </tr>
         ");
            WriteLiteral("               </thead>\r\n\r\n                        <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\Developer\source\repos\CJTimbangan\Views\Code\product.cshtml"
                               var odd = false; 

#line default
#line hidden
            BeginContext(1724, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 39 "C:\Users\Developer\source\repos\CJTimbangan\Views\Code\product.cshtml"
                             foreach (var item in Model){

#line default
#line hidden
            BeginContext(1783, 31, true);
            WriteLiteral("                            <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1814, "\"", 1852, 2);
#line 40 "C:\Users\Developer\source\repos\CJTimbangan\Views\Code\product.cshtml"
WriteAttributeValue("", 1822, odd ? "odd": "even", 1822, 22, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1844, "pointer", 1845, 8, true);
            EndWriteAttribute();
            BeginContext(1853, 83, true);
            WriteLiteral(">\r\n                                \r\n                                <td class=\" \">");
            EndContext();
            BeginContext(1937, 41, false);
#line 42 "C:\Users\Developer\source\repos\CJTimbangan\Views\Code\product.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.barang));

#line default
#line hidden
            EndContext();
            BeginContext(1978, 53, true);
            WriteLiteral("</td>\r\n                                <td class=\" \">");
            EndContext();
            BeginContext(2032, 41, false);
#line 43 "C:\Users\Developer\source\repos\CJTimbangan\Views\Code\product.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.lot_no));

#line default
#line hidden
            EndContext();
            BeginContext(2073, 53, true);
            WriteLiteral("</td>\r\n                                <td class=\" \">");
            EndContext();
            BeginContext(2127, 42, false);
#line 44 "C:\Users\Developer\source\repos\CJTimbangan\Views\Code\product.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.kemasan));

#line default
#line hidden
            EndContext();
            BeginContext(2169, 53, true);
            WriteLiteral("</td>\r\n                                <td class=\" \">");
            EndContext();
            BeginContext(2223, 42, false);
#line 45 "C:\Users\Developer\source\repos\CJTimbangan\Views\Code\product.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.counter));

#line default
#line hidden
            EndContext();
            BeginContext(2265, 53, true);
            WriteLiteral("</td>\r\n                                <td class=\" \">");
            EndContext();
            BeginContext(2319, 39, false);
#line 46 "C:\Users\Developer\source\repos\CJTimbangan\Views\Code\product.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.tare));

#line default
#line hidden
            EndContext();
            BeginContext(2358, 96, true);
            WriteLiteral("</td>\r\n                                <td class=\" last\">\r\n                                     ");
            EndContext();
            BeginContext(2454, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afc2aedf381bf81e7f89252759bb6a269c3fd6fe11217", async() => {
                BeginContext(2530, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\Developer\source\repos\CJTimbangan\Views\Code\product.cshtml"
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
            BeginContext(2538, 41, true);
            WriteLiteral(" | \r\n                                    ");
            EndContext();
            BeginContext(2579, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afc2aedf381bf81e7f89252759bb6a269c3fd6fe13832", async() => {
                BeginContext(2655, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\Developer\source\repos\CJTimbangan\Views\Code\product.cshtml"
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
            BeginContext(2665, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 52 "C:\Users\Developer\source\repos\CJTimbangan\Views\Code\product.cshtml"
                            odd = !odd;
                            }

#line default
#line hidden
            BeginContext(2813, 200, true);
            WriteLiteral("                        </tbody>\r\n                        </table>\r\n                        </div>\r\n                </div>\r\n            </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
