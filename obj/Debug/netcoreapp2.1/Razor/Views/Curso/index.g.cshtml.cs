#pragma checksum "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39ee8c7b68223f988635d651c0fa8966dc907c95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_Index), @"mvc.1.0.view", @"/Views/Curso/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Curso/Index.cshtml", typeof(AspNetCore.Views_Curso_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39ee8c7b68223f988635d651c0fa8966dc907c95", @"/Views/Curso/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13e74ccc1fe8a2aaede951e0e9151498594f2448", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcProject.Models.CursoModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml"
  
    ViewData["Title"] = "Cursos";

#line default
#line hidden
            BeginContext(94, 82, true);
            WriteLiteral("\r\n\r\n<h1 style=\"text-align: center\">Cursos Disponí­veis</h1>\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 11 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml"
     foreach(var curso in Model)
	{

#line default
#line hidden
            BeginContext(211, 43, true);
            WriteLiteral("\t\t<div class=\"col-md-4 curso-box\">\r\n\t\t\t<h4>");
            EndContext();
            BeginContext(255, 10, false);
#line 14 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml"
           Write(curso.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(265, 37, true);
            WriteLiteral("</h4>\r\n\t\t\t<img class = \"imagem-curso\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 302, "\"", 328, 1);
#line 15 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml"
WriteAttributeValue("", 308, curso.CaminhoImagem, 308, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(329, 52, true);
            WriteLiteral("/>\r\n\t\t\t<div class=\"col-md-12 botoes-cursos\">\r\n\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 381, "\"", 412, 2);
            WriteAttributeValue("", 388, "/curso/detalhe/", 388, 15, true);
#line 17 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml"
WriteAttributeValue("", 403, curso.Id, 403, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(413, 74, true);
            WriteLiteral("><button type=\"button\" class=\"btn btn-light\">Detalhes</button></a>\r\n\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 487, "\"", 520, 2);
            WriteAttributeValue("", 494, "/curso/inscrever/", 494, 17, true);
#line 18 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml"
WriteAttributeValue("", 511, curso.Id, 511, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(521, 89, true);
            WriteLiteral("><button type=\"button\" class=\"btn btn-info\">Inscrição</button></a>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
            EndContext();
#line 21 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml"
	}

#line default
#line hidden
            BeginContext(614, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcProject.Models.CursoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
