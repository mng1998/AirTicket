#pragma checksum "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e968c605fe8ee9f1640faf2fffd4e84790486d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DatVe_Details), @"mvc.1.0.view", @"/Views/DatVe/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DatVe/Details.cshtml", typeof(AspNetCore.Views_DatVe_Details))]
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
#line 1 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\_ViewImports.cshtml"
using MvcEfCore;

#line default
#line hidden
#line 2 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\_ViewImports.cshtml"
using MvcEfCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e968c605fe8ee9f1640faf2fffd4e84790486d0", @"/Views/DatVe/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6ac9d7d923c3d5dddaae649fdfc678fcbf1a57f", @"/Views/_ViewImports.cshtml")]
    public class Views_DatVe_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcEfCore.Models.PhieuDatVe>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(36, 104, true);
            WriteLiteral("\r\n<div>\r\n    <h4>PhieuDatVe</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(141, 43, false);
#line 8 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GiaTien));

#line default
#line hidden
            EndContext();
            BeginContext(184, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(228, 39, false);
#line 11 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Details.cshtml"
       Write(Html.DisplayFor(model => model.GiaTien));

#line default
#line hidden
            EndContext();
            BeginContext(267, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(311, 42, false);
#line 14 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HangVe));

#line default
#line hidden
            EndContext();
            BeginContext(353, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(397, 45, false);
#line 17 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Details.cshtml"
       Write(Html.DisplayFor(model => model.HangVe.HangID));

#line default
#line hidden
            EndContext();
            BeginContext(442, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(486, 45, false);
#line 20 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.KhachHang));

#line default
#line hidden
            EndContext();
            BeginContext(531, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(575, 53, false);
#line 23 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Details.cshtml"
       Write(Html.DisplayFor(model => model.KhachHang.KhachHangID));

#line default
#line hidden
            EndContext();
            BeginContext(628, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(672, 45, false);
#line 26 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TrangThai));

#line default
#line hidden
            EndContext();
            BeginContext(717, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(761, 41, false);
#line 29 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Details.cshtml"
       Write(Html.DisplayFor(model => model.TrangThai));

#line default
#line hidden
            EndContext();
            BeginContext(802, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(846, 49, false);
#line 32 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LichChuyenBay));

#line default
#line hidden
            EndContext();
            BeginContext(895, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(939, 57, false);
#line 35 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Details.cshtml"
       Write(Html.DisplayFor(model => model.LichChuyenBay.ChuyenBayID));

#line default
#line hidden
            EndContext();
            BeginContext(996, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1043, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d62725679b26494b82a2d205eae0749d", async() => {
                BeginContext(1099, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 40 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Details.cshtml"
                           WriteLiteral(Model.PhieuDatVeID);

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
            BeginContext(1107, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1115, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3774d2c49096410babcddc68434bcbed", async() => {
                BeginContext(1137, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(1153, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcEfCore.Models.PhieuDatVe> Html { get; private set; }
    }
}
#pragma warning restore 1591