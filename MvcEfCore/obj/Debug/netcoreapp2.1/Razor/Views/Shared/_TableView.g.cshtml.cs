#pragma checksum "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\Shared\_TableView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "539542c20ea07ad3ee8ced090097b5a6a481fce2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TableView), @"mvc.1.0.view", @"/Views/Shared/_TableView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TableView.cshtml", typeof(AspNetCore.Views_Shared__TableView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"539542c20ea07ad3ee8ced090097b5a6a481fce2", @"/Views/Shared/_TableView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6ac9d7d923c3d5dddaae649fdfc678fcbf1a57f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TableView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\Shared\_TableView.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(52, 12, false);
#line 4 "C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Views\Shared\_TableView.cshtml"
Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(64, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("css", async() => {
                BeginContext(79, 171, true);
                WriteLiteral("\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"https://cdn.datatables.net/1.10.19/css/jquery.dataTables.css//cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css\">\n");
                EndContext();
            }
            );
            DefineSection("Scripts", async() => {
                BeginContext(270, 249, true);
                WriteLiteral("\n    <script type=\"text/javascript\" charset=\"utf8\" src=\"https://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js\"></script>\n    <script>\n        $(document).ready(function () {\n            $(\'#table_id\').DataTable();\n        });\n    </script>\n");
                EndContext();
            }
            );
            BeginContext(521, 2, true);
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591