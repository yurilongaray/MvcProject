#pragma checksum "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Detalhe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eada58f3af3785823863f541fdb13a6b2fa02e31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_Detalhe), @"mvc.1.0.view", @"/Views/Curso/Detalhe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Curso/Detalhe.cshtml", typeof(AspNetCore.Views_Curso_Detalhe))]
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
#line 1 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\_ViewImports.cshtml"
using MvcProject;

#line default
#line hidden
#line 2 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\_ViewImports.cshtml"
using MvcProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eada58f3af3785823863f541fdb13a6b2fa02e31", @"/Views/Curso/Detalhe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b195e0951ebb4337c362372a52496a3462d2eef9", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_Detalhe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcProject.Models.CursoModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Detalhe.cshtml"
  
     ViewData["Title"] = "Detalhe";

#line default
#line hidden
            BeginContext(83, 36, true);
            WriteLiteral("\r\n<h2>Detalhes do Curso</h2>\r\n\r\n<h3>");
            EndContext();
            BeginContext(120, 19, false);
#line 9 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Detalhe.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(139, 7, true);
            WriteLiteral("</h3>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcProject.Models.CursoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591