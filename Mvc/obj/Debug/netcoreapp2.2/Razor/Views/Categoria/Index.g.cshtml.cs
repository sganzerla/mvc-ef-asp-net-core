#pragma checksum "C:\Users\alisson-pc\Documents\Cursos Udemy\aspnet-core-aprendendo-do-zero-ao-avancado\modulo4\Mvc\Views\Categoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15f4e902d562fa7c39a17a8d9c79a41c426cd71b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_Index), @"mvc.1.0.view", @"/Views/Categoria/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categoria/Index.cshtml", typeof(AspNetCore.Views_Categoria_Index))]
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
#line 1 "C:\Users\alisson-pc\Documents\Cursos Udemy\aspnet-core-aprendendo-do-zero-ao-avancado\modulo4\Mvc\Views\_ViewImports.cshtml"
using Mvc;

#line default
#line hidden
#line 2 "C:\Users\alisson-pc\Documents\Cursos Udemy\aspnet-core-aprendendo-do-zero-ao-avancado\modulo4\Mvc\Views\_ViewImports.cshtml"
using Mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15f4e902d562fa7c39a17a8d9c79a41c426cd71b", @"/Views/Categoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d14c947c23ce1723f7843b90231a2951c10e8cb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominio.Entidades.Categoria>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 368, true);
            WriteLiteral(@"
    <h2>Todas Categorias</h2>
    <a href=""/Categoria/Salvar"" class=""btn"">Nova Categoria</a>
    <div class=""row"">
        <div class=""col-md-12"">
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>Nome</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 14 "C:\Users\alisson-pc\Documents\Cursos Udemy\aspnet-core-aprendendo-do-zero-ao-avancado\modulo4\Mvc\Views\Categoria\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(490, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(553, 9, false);
#line 17 "C:\Users\alisson-pc\Documents\Cursos Udemy\aspnet-core-aprendendo-do-zero-ao-avancado\modulo4\Mvc\Views\Categoria\Index.cshtml"
                           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(562, 40, true);
            WriteLiteral("</td>\r\n                             <td>");
            EndContext();
            BeginContext(603, 19, false);
#line 18 "C:\Users\alisson-pc\Documents\Cursos Udemy\aspnet-core-aprendendo-do-zero-ao-avancado\modulo4\Mvc\Views\Categoria\Index.cshtml"
                            Write(item.PermiteEstoque);

#line default
#line hidden
            EndContext();
            BeginContext(622, 41, true);
            WriteLiteral("</td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 663, "\"", 696, 2);
            WriteAttributeValue("", 670, "/Categoria/Editar/", 670, 18, true);
#line 19 "C:\Users\alisson-pc\Documents\Cursos Udemy\aspnet-core-aprendendo-do-zero-ao-avancado\modulo4\Mvc\Views\Categoria\Index.cshtml"
WriteAttributeValue("", 688, item.Id, 688, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(697, 93, true);
            WriteLiteral(" class=\"btn\">Editar</a></td>                             \r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 790, "\"", 824, 2);
            WriteAttributeValue("", 797, "/Categoria/Deletar/", 797, 19, true);
#line 20 "C:\Users\alisson-pc\Documents\Cursos Udemy\aspnet-core-aprendendo-do-zero-ao-avancado\modulo4\Mvc\Views\Categoria\Index.cshtml"
WriteAttributeValue("", 816, item.Id, 816, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(825, 62, true);
            WriteLiteral(" class=\"btn\">Deletar</a></td>\r\n                        </tr>\r\n");
            EndContext();
#line 22 "C:\Users\alisson-pc\Documents\Cursos Udemy\aspnet-core-aprendendo-do-zero-ao-avancado\modulo4\Mvc\Views\Categoria\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(910, 74, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dominio.Entidades.Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
