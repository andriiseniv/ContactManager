#pragma checksum "D:\.Net Trainee\BitsOrchestra\CSVReader\CSVReader\Views\CSV\Import.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f75a3009805bb6ac01783963ae234dddf665910"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CSV_Import), @"mvc.1.0.view", @"/Views/CSV/Import.cshtml")]
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
#line 1 "D:\.Net Trainee\BitsOrchestra\CSVReader\CSVReader\Views\_ViewImports.cshtml"
using CSVReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net Trainee\BitsOrchestra\CSVReader\CSVReader\Views\_ViewImports.cshtml"
using CSVReader.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f75a3009805bb6ac01783963ae234dddf665910", @"/Views/CSV/Import.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92ca5e52ea8444d1f531a7090fdb8ce1a6aa158e", @"/Views/_ViewImports.cshtml")]
    public class Views_CSV_Import : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CSVReader.Models.CSVModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position:relative; right:12px; top:5px; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline btn py-0 mb-4 col-md-9"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CSV", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Write", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn text-white btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 110px; bottom:90px; font-weight: 200; font-size: medium; background-color:#2E4053; float:right;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position:relative;float:right;bottom:21px; left:157px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f75a3009805bb6ac01783963ae234dddf6659106493", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>background-image</title>\r\n    <style>\r\n        body {\r\n            background-color: grey;\r\n            background: grey url(/img/back1.jpg) fixed;\r\n        }\r\n    </style>\r\n");
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
            WriteLiteral(@"

<div class=""row "">
    <div class=""container "">
        <div style=""position:relative; top:0.11%; left:15%;"" class=""row py-3 mt-3"">
            <div class=""list-group-item list-group-item-action gap-2 p-3   shadow-lg bg-light    col-sm col-md-8 align-items-lg-end"">
                <div class="" mr-3 mb-3"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f75a3009805bb6ac01783963ae234dddf6659108035", async() => {
                WriteLiteral(@"
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""23"" height=""25"" fill=""currentColor"" class=""bi bi-arrow-left text-black-50"" viewBox=""0 0 16 16"">
                            <path fill-rule=""evenodd"" d=""M15 8a.5.5 0 0 0-.5-.5H2.707l3.147-3.146a.5.5 0 1 0-.708-.708l-4 4a.5.5 0 0 0 0 .708l4 4a.5.5 0 0 0 .708-.708L2.707 8.5H14.5A.5.5 0 0 0 15 8z"" />
                        </svg>
                        <h5 style=""position:absolute; left:40px; top:-1px; font-weight:200;"">Back</h5>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("height:25px;", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    <h5 class=\"ml-5\" style=\"position:relative; top:5px; float:right; right:320px; font-weight:500;\">");
#nullable restore
#line 26 "D:\.Net Trainee\BitsOrchestra\CSVReader\CSVReader\Views\CSV\Import.cshtml"
                                                                                                               Write(Model.Count(x => x.CSVID == 0));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Contacts</h5>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f75a3009805bb6ac01783963ae234dddf66591010717", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 29 "D:\.Net Trainee\BitsOrchestra\CSVReader\CSVReader\Views\CSV\Import.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p>\r\n                                <input id=\"it3\"");
                BeginWriteAttribute("value", " value=", 1732, "", 1749, 1);
#nullable restore
#line 32 "D:\.Net Trainee\BitsOrchestra\CSVReader\CSVReader\Views\CSV\Import.cshtml"
WriteAttributeValue("", 1739, item.Name, 1739, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"name\" class=\"invisible\" style=\"white-space:inherit; width:0px;height:0px; position:absolute;\" />\r\n                                <input id=\"it3\"");
                BeginWriteAttribute("value", " value=", 1901, "", 1925, 1);
#nullable restore
#line 33 "D:\.Net Trainee\BitsOrchestra\CSVReader\CSVReader\Views\CSV\Import.cshtml"
WriteAttributeValue("", 1908, item.DateOfBirth, 1908, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"dateOfBirth\" class=\"invisible\" style=\"width:0px;height:0px; position:absolute;\" />\r\n                                <input id=\"it3\"");
                BeginWriteAttribute("value", " value=", 2063, "", 2094, 1);
#nullable restore
#line 34 "D:\.Net Trainee\BitsOrchestra\CSVReader\CSVReader\Views\CSV\Import.cshtml"
WriteAttributeValue("", 2070, item.Married.ToString(), 2070, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"married\" class=\"invisible\" style=\"width:0px;height:0px; position:absolute;\" />\r\n                                <input id=\"it3\"");
                BeginWriteAttribute("value", " value=", 2228, "", 2246, 1);
#nullable restore
#line 35 "D:\.Net Trainee\BitsOrchestra\CSVReader\CSVReader\Views\CSV\Import.cshtml"
WriteAttributeValue("", 2235, item.Phone, 2235, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"phone\" class=\"invisible\" style=\"width:0px;height:0px; position:absolute;\" />\r\n                                <input id=\"it3\"");
                BeginWriteAttribute("value", " value=", 2378, "", 2397, 1);
#nullable restore
#line 36 "D:\.Net Trainee\BitsOrchestra\CSVReader\CSVReader\Views\CSV\Import.cshtml"
WriteAttributeValue("", 2385, item.Salary, 2385, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"salary\" class=\"invisible\" style=\"width:0px;height:0px; position:absolute;\" />\r\n\r\n                            </p>\r\n");
#nullable restore
#line 39 "D:\.Net Trainee\BitsOrchestra\CSVReader\CSVReader\Views\CSV\Import.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f75a3009805bb6ac01783963ae234dddf66591014157", async() => {
                    WriteLiteral(@"

                            Save
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""25"" height=""25"" fill=""currentColor"" class=""bi bi-bookmark-plus-fill"" viewBox=""0 0 16 16"">
                                <path fill-rule=""evenodd"" d=""M2 15.5V2a2 2 0 0 1 2-2h8a2 2 0 0 1 2 2v13.5a.5.5 0 0 1-.74.439L8 13.069l-5.26 2.87A.5.5 0 0 1 2 15.5zm6.5-11a.5.5 0 0 0-1 0V6H6a.5.5 0 0 0 0 1h1.5v1.5a.5.5 0 0 0 1 0V7H10a.5.5 0 0 0 0-1H8.5V4.5z"" />
                            </svg>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n             \r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                </div>

                <table class=""table table-striped"">
                    <thead style="" background-color: #273746;"" class=""text-white"">
                        <tr>
                            <th scope=""col"">Name</th>
                            <th scope=""col"">Birth</th>
                            <th scope=""col"">Married</th>
                            <th scope=""col"">Phone</th>
                            <th scope=""col"">Salary</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 65 "D:\.Net Trainee\BitsOrchestra\CSVReader\CSVReader\Views\CSV\Import.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 68 "D:\.Net Trainee\BitsOrchestra\CSVReader\CSVReader\Views\CSV\Import.cshtml"
                           Write(item.Name.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 69 "D:\.Net Trainee\BitsOrchestra\CSVReader\CSVReader\Views\CSV\Import.cshtml"
                           Write(item.DateOfBirth.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 70 "D:\.Net Trainee\BitsOrchestra\CSVReader\CSVReader\Views\CSV\Import.cshtml"
                           Write(item.Married);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>+");
#nullable restore
#line 71 "D:\.Net Trainee\BitsOrchestra\CSVReader\CSVReader\Views\CSV\Import.cshtml"
                            Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>$");
#nullable restore
#line 72 "D:\.Net Trainee\BitsOrchestra\CSVReader\CSVReader\Views\CSV\Import.cshtml"
                            Write(Convert.ToInt32(item.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 74 "D:\.Net Trainee\BitsOrchestra\CSVReader\CSVReader\Views\CSV\Import.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CSVReader.Models.CSVModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
