#pragma checksum "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68da7fd6a72d6b7d0887baef71f041813b4610f1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68da7fd6a72d6b7d0887baef71f041813b4610f1", @"/Views/Curso/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b195e0951ebb4337c362372a52496a3462d2eef9", @"/Views/_ViewImports.cshtml")]
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
            BeginContext(94, 211, true);
            WriteLiteral("\r\n\r\n<h1>Tabela de Cursos</h1>\r\n<table>\r\n\t<tr>\r\n\t\t<th>Id</th>\r\n\t\t<th>Nome</th>\r\n\t\t<th>Carga Horaria</th>\r\n\t\t<th>Caminho Imagem</th>\r\n\t\t<th>Caminho V�deo</th>\r\n\t\t<th>Data In�cio</th>\r\n\t\t<th>Detalhes</th>\r\n\t</tr>\r\n");
            EndContext();
#line 19 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml"
     foreach(var curso in Model) {

#line default
#line hidden
            BeginContext(338, 15, true);
            WriteLiteral("\t\t<tr>\r\n\t\t\t<td>");
            EndContext();
            BeginContext(354, 8, false);
#line 21 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml"
           Write(curso.id);

#line default
#line hidden
            EndContext();
            BeginContext(362, 16, true);
            WriteLiteral("</td>\r\n\t\t\t<td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 378, "\"", 409, 2);
            WriteAttributeValue("", 385, "/curso/detalhe/", 385, 15, true);
#line 22 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml"
WriteAttributeValue("", 400, curso.id, 400, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(410, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(412, 10, false);
#line 22 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml"
                                              Write(curso.nome);

#line default
#line hidden
            EndContext();
            BeginContext(422, 18, true);
            WriteLiteral("</a></td>\r\n\t\t\t<td>");
            EndContext();
            BeginContext(441, 18, false);
#line 23 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml"
           Write(curso.cargaHoraria);

#line default
#line hidden
            EndContext();
            BeginContext(459, 14, true);
            WriteLiteral("</td>\r\n\t\t\t<td>");
            EndContext();
            BeginContext(474, 19, false);
#line 24 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml"
           Write(curso.caminhoImagem);

#line default
#line hidden
            EndContext();
            BeginContext(493, 14, true);
            WriteLiteral("</td>\r\n\t\t\t<td>");
            EndContext();
            BeginContext(508, 18, false);
#line 25 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml"
           Write(curso.caminhoVideo);

#line default
#line hidden
            EndContext();
            BeginContext(526, 14, true);
            WriteLiteral("</td>\r\n\t\t\t<td>");
            EndContext();
            BeginContext(541, 46, false);
#line 26 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml"
           Write(Html.DisplayFor(cursoItem => curso.dataInicio));

#line default
#line hidden
            EndContext();
            BeginContext(587, 14, true);
            WriteLiteral("</td>\r\n\t\t\t<td>");
            EndContext();
            BeginContext(602, 62, false);
#line 27 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml"
           Write(Html.ActionLink("Detalhes", "Detalhe", new { id = @curso.id }));

#line default
#line hidden
            EndContext();
            BeginContext(664, 16, true);
            WriteLiteral("</td>\r\n\t\t</tr>\r\n");
            EndContext();
#line 29 "C:\Users\yuri.caldeira\Desktop\MvcProject\Views\Curso\Index.cshtml"
	}

#line default
#line hidden
            BeginContext(684, 553, true);
            WriteLiteral(@"
</table>
<div class=""row"">
<div class=""col-md-4"">
	<div class=""intro-table intro-table-hover"">
		<h5 class=""white heading hide-hover"">Premium Membership</h5>
		<div class=""bottom"">
			<h4 class=""white heading small-heading no-margin regular"">Register Today</h4>
			<h4 class=""white heading small-pt"">20% Discount</h4>
			<a href=""#"" class=""btn btn-white-fill expand"">Register</a>
		</div>
	</div>
</div>
</div>
<!-- <iframe width=""853"" height=""480"" src=""https://youtube.com/embed/u548qyxRTBU"" frameborder=""0"" allowfullscreen></iframe> -->");
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
