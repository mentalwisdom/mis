#pragma checksum "/Users/mac/Desktop/backup/soft/mis/Views/ProductOrder/OrderStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9149d69ad00117ae6286526ffa409a99277a10be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductOrder_OrderStatus), @"mvc.1.0.view", @"/Views/ProductOrder/OrderStatus.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductOrder/OrderStatus.cshtml", typeof(AspNetCore.Views_ProductOrder_OrderStatus))]
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
#line 1 "/Users/mac/Desktop/backup/soft/mis/Views/_ViewImports.cshtml"
using MIS;

#line default
#line hidden
#line 2 "/Users/mac/Desktop/backup/soft/mis/Views/_ViewImports.cshtml"
using MIS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9149d69ad00117ae6286526ffa409a99277a10be", @"/Views/ProductOrder/OrderStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708eb2a9aed54b9aee9df7bd8bc02a45efbfbd0c", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductOrder_OrderStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 100, true);
            WriteLiteral("<h2> Order Status:</h2>\n <!--server side rendering/displaying technique in software engineering -->\n");
            EndContext();
#line 3 "/Users/mac/Desktop/backup/soft/mis/Views/ProductOrder/OrderStatus.cshtml"
 if(ViewBag.error){

#line default
#line hidden
            BeginContext(120, 39, true);
            WriteLiteral("    <div style=\"background-color:red;\">");
            EndContext();
            BeginContext(160, 11, false);
#line 4 "/Users/mac/Desktop/backup/soft/mis/Views/ProductOrder/OrderStatus.cshtml"
                                  Write(ViewBag.msg);

#line default
#line hidden
            EndContext();
            BeginContext(171, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 5 "/Users/mac/Desktop/backup/soft/mis/Views/ProductOrder/OrderStatus.cshtml"
}
else{

#line default
#line hidden
            BeginContext(186, 72, true);
            WriteLiteral("    <div style=\"background-color:green;\">sucess</div>\n    <h4>customer: ");
            EndContext();
            BeginContext(259, 17, false);
#line 8 "/Users/mac/Desktop/backup/soft/mis/Views/ProductOrder/OrderStatus.cshtml"
             Write(ViewBag.full_name);

#line default
#line hidden
            EndContext();
            BeginContext(276, 28, true);
            WriteLiteral("</h4>\n    <h4>order status: ");
            EndContext();
            BeginContext(305, 20, false);
#line 9 "/Users/mac/Desktop/backup/soft/mis/Views/ProductOrder/OrderStatus.cshtml"
                 Write(ViewBag.order_status);

#line default
#line hidden
            EndContext();
            BeginContext(325, 24, true);
            WriteLiteral(" </h4>\n    <h4>product: ");
            EndContext();
            BeginContext(350, 20, false);
#line 10 "/Users/mac/Desktop/backup/soft/mis/Views/ProductOrder/OrderStatus.cshtml"
            Write(ViewBag.product_name);

#line default
#line hidden
            EndContext();
            BeginContext(370, 35, true);
            WriteLiteral(" </h4>\n    <h4>order order amount: ");
            EndContext();
            BeginContext(406, 11, false);
#line 11 "/Users/mac/Desktop/backup/soft/mis/Views/ProductOrder/OrderStatus.cshtml"
                       Write(ViewBag.qty);

#line default
#line hidden
            EndContext();
            BeginContext(417, 6, true);
            WriteLiteral("</h4>\n");
            EndContext();
#line 12 "/Users/mac/Desktop/backup/soft/mis/Views/ProductOrder/OrderStatus.cshtml"
}

#line default
#line hidden
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