#pragma checksum "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b14db9906197eccb8890b12a3fa0e213b14974e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Conference_Schedule), @"mvc.1.0.view", @"/Areas/Admin/Views/Conference/Schedule.cshtml")]
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
#line 1 "D:\EConference-Bikash\EConference\Areas\Admin\Views\_ViewImports.cshtml"
using EConference;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\EConference-Bikash\EConference\Areas\Admin\Views\_ViewImports.cshtml"
using EConference.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b14db9906197eccb8890b12a3fa0e213b14974e", @"/Areas/Admin/Views/Conference/Schedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f01a57a3dc4d545ba442a8ff40474bb396b7726", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Conference_Schedule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EConference.Models.ViewModels.SchedulingViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
  
    ViewData["Title"] = "Schedule Conferences";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-primary\">Schedule Conferences</h2>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"p-4 border rounded\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b14db9906197eccb8890b12a3fa0e213b14974e4462", async() => {
                WriteLiteral(@"
        <table id=""tblData"" class=""table table-striped table-bordered"" style=""width:100%"">
            <thead class=""thead-dark"">
                <tr class=""table-info"">
                    <th>Paper ID</th>
                    <th>Topic</th>
                    <th>Title</th>
                    <th>Publisher</th>
                    <th>Participant</th>
                    <th>Time Zone</th>
                    <th>Country</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 28 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
                 for (int i = 0; i < Model.Groups.Count; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td colspan=\"7\">\r\n                            Group #");
#nullable restore
#line 32 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
                               Write(i+1);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"float-right\">\r\n                                <label for=\"groupName\">Name:</label>\r\n                                <select name=\"groupName\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b14db9906197eccb8890b12a3fa0e213b14974e6100", async() => {
                    WriteLiteral("---");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 37 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
                                     foreach (ConferenceName n in Model.Names)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b14db9906197eccb8890b12a3fa0e213b14974e7674", async() => {
#nullable restore
#line 39 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
                                                         Write(n.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
                                           WriteLiteral(n.Id);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n");
#nullable restore
#line 40 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </select>
                                <label for=""groupTime"">Time:</label>
                                <input type=""time"" name=""groupTime"" />
                                <label for=""groupDate"" class=""pl-1"">Date:</label>
                                <input class=""date"" type=""date"" name=""groupDate"" />
                            </div>
                        </td>
                    </tr>
");
#nullable restore
#line 49 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
                     foreach (Papers p in Model.Groups[i])
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 52 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
                           Write(p.PaperId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 53 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
                           Write(EConference.Models.PaperTopic.Get(p.PaperTopic).Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 54 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
                           Write(p.PaperTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 55 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
                           Write(p.Publisher);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 56 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
                           Write(p.Participant);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 57 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
                           Write(TimeZoneInfo.FindSystemTimeZoneById(p.TimeZone).DisplayName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 58 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
                           Write(p.Country);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 60 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 64 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
         if (Model.Groups.Count > 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <button type=\"submit\" class=\"btn btn-outline-primary\">Schedule Conferences</button>\r\n");
#nullable restore
#line 67 "D:\EConference-Bikash\EConference\Areas\Admin\Views\Conference\Schedule.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EConference.Models.ViewModels.SchedulingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
