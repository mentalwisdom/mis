#pragma checksum "/Users/mac/Desktop/backup/soft/mis/Templates/ControllerGenerator/EmptyController.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "711bc0aedcbbe0a497e4a92eaac36c648875cafc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ControllerGenerator_EmptyController), @"mvc.1.0.view", @"/Templates/ControllerGenerator/EmptyController.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Templates/ControllerGenerator/EmptyController.cshtml", typeof(AspNetCore.Templates_ControllerGenerator_EmptyController))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"711bc0aedcbbe0a497e4a92eaac36c648875cafc", @"/Templates/ControllerGenerator/EmptyController.cshtml")]
    public class Templates_ControllerGenerator_EmptyController : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(82, 146, true);
            WriteLiteral("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Threading.Tasks;\r\nusing Microsoft.AspNetCore.Mvc;\r\n\r\nnamespace ");
            EndContext();
            BeginContext(229, 19, false);
#line 8 "/Users/mac/Desktop/backup/soft/mis/Templates/ControllerGenerator/EmptyController.cshtml"
     Write(Model.NamespaceName);

#line default
#line hidden
            EndContext();
            BeginContext(248, 22, true);
            WriteLiteral("\r\n{\r\n    public class ");
            EndContext();
            BeginContext(271, 15, false);
#line 10 "/Users/mac/Desktop/backup/soft/mis/Templates/ControllerGenerator/EmptyController.cshtml"
            Write(Model.ClassName);

#line default
#line hidden
            EndContext();
            BeginContext(286, 118, true);
            WriteLiteral(" : Controller\r\n    {\r\n        public IActionResult Index()\r\n        {\r\n            return View();\r\n        }\r\n    }\r\n}");
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
