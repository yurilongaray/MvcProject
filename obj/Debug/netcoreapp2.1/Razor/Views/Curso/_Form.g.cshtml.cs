#pragma checksum "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\_Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0845b7b63c0dbf0704c6f4f5eaad7efcc6bd9b77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso__Form), @"mvc.1.0.view", @"/Views/Curso/_Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Curso/_Form.cshtml", typeof(AspNetCore.Views_Curso__Form))]
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
#line 3 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\_ViewImports.cshtml"
using MvcProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0845b7b63c0dbf0704c6f4f5eaad7efcc6bd9b77", @"/Views/Curso/_Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13e74ccc1fe8a2aaede951e0e9151498594f2448", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso__Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcProject.ViewModels.AlunoCursoVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\_Form.cshtml"
 if (!ViewData.ModelState.IsValid)
{

#line default
#line hidden
            BeginContext(84, 59, true);
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(144, 24, false);
#line 6 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\_Form.cshtml"
   Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(168, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 8 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\_Form.cshtml"
}

#line default
#line hidden
            BeginContext(185, 78, true);
            WriteLiteral("\r\n<div class=\"col-md-6\">\r\n\r\n\t<!-- Verificar o pq n�o s�o preenchidos -->\r\n    ");
            EndContext();
            BeginContext(264, 31, false);
#line 13 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\_Form.cshtml"
Write(Html.HiddenFor(m => m.Curso.Id));

#line default
#line hidden
            EndContext();
            BeginContext(295, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(302, 33, false);
#line 14 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\_Form.cshtml"
Write(Html.HiddenFor(m => m.Curso.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(335, 42, true);
            WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(378, 32, false);
#line 17 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\_Form.cshtml"
   Write(Html.LabelFor(m => m.Aluno.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(410, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(421, 67, false);
#line 18 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\_Form.cshtml"
   Write(Html.TextBoxFor(m => m.Aluno.Nome, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(488, 65, true);
            WriteLiteral("\r\n        <span id=\"helpBlock2\" class=\"help-block\">\r\n            ");
            EndContext();
            BeginContext(554, 44, false);
#line 20 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\_Form.cshtml"
       Write(Html.ValidationMessageFor(m => m.Aluno.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(598, 41, true);
            WriteLiteral("\r\n        </span>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcProject.ViewModels.AlunoCursoVM> Html { get; private set; }
    }
}
#pragma warning restore 1591