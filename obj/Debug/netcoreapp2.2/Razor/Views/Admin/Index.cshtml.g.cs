#pragma checksum "/Users/mac/Desktop/backup/soft/mis/Views/Admin/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5b9776bb3fc803307ea293cf2973dcbf4dac2ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5b9776bb3fc803307ea293cf2973dcbf4dac2ad", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708eb2a9aed54b9aee9df7bd8bc02a45efbfbd0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 43, true);
            WriteLiteral(" <div class=\"text-center\">\n\n   <h4>Welcome ");
            EndContext();
            BeginContext(44, 12, false);
#line 3 "/Users/mac/Desktop/backup/soft/mis/Views/Admin/Index.cshtml"
          Write(ViewBag.user);

#line default
#line hidden
            EndContext();
            BeginContext(56, 360, true);
            WriteLiteral(@"</h4>

   <div class=""container"">
     <div class=""row"">
       <div class=""col-12 col-md-4 col-sm-6"">
         <h5>Business Entity</h5>
               <a class=""btn btn-outline-success btn-block "" href=""/productgroup"">
           <i class=""fa fa-atom float-left mt-1""></i>
            Product group
           <span class=""badge badge-info float-right mt-1""> ");
            EndContext();
            BeginContext(417, 21, false);
#line 12 "/Users/mac/Desktop/backup/soft/mis/Views/Admin/Index.cshtml"
                                                       Write(ViewBag.productgroups);

#line default
#line hidden
            EndContext();
            BeginContext(438, 230, true);
            WriteLiteral("</span>\n           </a>\n          <a class=\"btn btn-outline-success btn-block \" href=\"/product\">\n           <i class=\"fa fa-atom float-left mt-1\"></i>\n           Product\n           <span class=\"badge badge-info float-right mt-1\"> ");
            EndContext();
            BeginContext(669, 16, false);
#line 17 "/Users/mac/Desktop/backup/soft/mis/Views/Admin/Index.cshtml"
                                                       Write(ViewBag.Products);

#line default
#line hidden
            EndContext();
            BeginContext(685, 80, true);
            WriteLiteral("</span>\n           </a>\n       \n       </div>   \n\n     </div>\n\n   </div>\n </div>");
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
