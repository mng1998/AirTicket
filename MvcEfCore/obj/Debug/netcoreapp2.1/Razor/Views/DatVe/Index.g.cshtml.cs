#pragma checksum "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f6623baf4fbf9e963677fe9e52cfd8dcbb10c6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DatVe_Index), @"mvc.1.0.view", @"/Views/DatVe/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DatVe/Index.cshtml", typeof(AspNetCore.Views_DatVe_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f6623baf4fbf9e963677fe9e52cfd8dcbb10c6b", @"/Views/DatVe/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6ac9d7d923c3d5dddaae649fdfc678fcbf1a57f", @"/Views/_ViewImports.cshtml")]
    public class Views_DatVe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcEfCore.ViewModels.LichChuyenBayVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/bg_2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Index.cshtml"
  
    ViewData["Title"] = "Đặt vé";

#line default
#line hidden
            BeginContext(102, 53, true);
            WriteLiteral("<div class=\"hero-wrap\">\r\n    <div class=\"\">\r\n        ");
            EndContext();
            BeginContext(155, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cec8de6197e94850a82ed1b64f300c82", async() => {
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
            BeginContext(186, 1245, true);
            WriteLiteral(@"
        <div class=""container"">

        </div>
    </div>
   
</div>
<section class=""ftco-section bg-light"">
    <div class=""container"">
        <div class=""row justify-content-center mb-5 pb-3"">
            <div class=""col-md-7 heading-section text-center ftco-animate"">
                <h2><strong>Flight</strong> Schedule</h2>
            </div>
        </div>
        <div class=""container"">
            <table id=""table"" class=""display table"">
                <thead>
                    <tr>
                        <th>
                            Flight ID
                        </th>
                        <th>
                            Departure time
                        </th>
                        <th>
                            Price
                        </th>
                        <th>
                            Flight Time
                        </th>
                        <th>
                            Bussiness Class 
                        </t");
            WriteLiteral("h>\r\n                        <th>\r\n                            Economy Class\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 48 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1504, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1601, 46, false);
#line 52 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ChuyenBayID));

#line default
#line hidden
            EndContext();
            BeginContext(1647, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1751, 45, false);
#line 55 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NgayGioBay));

#line default
#line hidden
            EndContext();
            BeginContext(1796, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1900, 40, false);
#line 58 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.GiaVe));

#line default
#line hidden
            EndContext();
            BeginContext(1940, 107, true);
            WriteLiteral(" VND\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2048, 46, false);
#line 61 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ThoiGianBay));

#line default
#line hidden
            EndContext();
            BeginContext(2094, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2198, 48, false);
#line 64 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.BusinessClass));

#line default
#line hidden
            EndContext();
            BeginContext(2246, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2350, 47, false);
#line 67 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.EconomyClass));

#line default
#line hidden
            EndContext();
            BeginContext(2397, 105, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n\r\n                                ");
            EndContext();
            BeginContext(2502, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16a58f54825145aea66f2f8c654b0cc4", async() => {
                BeginContext(2558, 8, true);
                WriteLiteral("Book now");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Index.cshtml"
                                                         WriteLiteral(item.ChuyenBayID);

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
            BeginContext(2570, 36, true);
            WriteLiteral(" |\r\n                                ");
            EndContext();
            BeginContext(2606, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cd1c6821fc74cb7bf3feee22e057326", async() => {
                BeginContext(2663, 17, true);
                WriteLiteral("Seat Reservations");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Index.cshtml"
                                                          WriteLiteral(item.ChuyenBayID);

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
            BeginContext(2684, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 75 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\DatVe\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2775, 464, true);
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</section>

    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.19/css/jquery.dataTables.css"">


    <script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.10.19/js/jquery.dataTables.js""></script>
    <script>
        $(document).ready(function () {
            $('#table').DataTable();
        });
    </script>





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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcEfCore.ViewModels.LichChuyenBayVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
