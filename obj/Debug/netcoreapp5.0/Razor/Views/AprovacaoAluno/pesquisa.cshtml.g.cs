#pragma checksum "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoAluno\pesquisa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "668a3d4d8a899cc4878f222c6087146d8d4f957d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AprovacaoAluno_pesquisa), @"mvc.1.0.view", @"/Views/AprovacaoAluno/pesquisa.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\_ViewImports.cshtml"
using Universidade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\_ViewImports.cshtml"
using Universidade.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"668a3d4d8a899cc4878f222c6087146d8d4f957d", @"/Views/AprovacaoAluno/pesquisa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1a4fa8d2d40697c6844bbec55f8b96421d7e546", @"/Views/_ViewImports.cshtml")]
    public class Views_AprovacaoAluno_pesquisa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Universidade.Models.AprovacaoAlunoModel>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Alunos neste curso</h1>\n</div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "668a3d4d8a899cc4878f222c6087146d8d4f957d3442", async() => {
                WriteLiteral(@"

    <table class=""table"" id=""tabela"">
        <thead>
            <tr>
                <th scope=""col"">Nome</th>
                <th scope=""col"">CPF</th>
                <th scope=""col"">Nota</th>
                <th scope=""col"">Aprovados</th>
                <th scope=""col"">Curso</th>
                <th scope=""col"">Disciplina</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoAluno\pesquisa.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 23 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoAluno\pesquisa.cshtml"
                   Write(item.nome_aluno);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 24 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoAluno\pesquisa.cshtml"
                   Write(item.cpf);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 25 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoAluno\pesquisa.cshtml"
                   Write(item.nota);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n\n");
#nullable restore
#line 27 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoAluno\pesquisa.cshtml"
                     if (@item.nota >= 60)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>Sim</td>\n");
#nullable restore
#line 30 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoAluno\pesquisa.cshtml"

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>Nao</td>\n");
#nullable restore
#line 35 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoAluno\pesquisa.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    <td>");
#nullable restore
#line 37 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoAluno\pesquisa.cshtml"
                   Write(item.nome_curso);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 38 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoAluno\pesquisa.cshtml"
                   Write(item.nome_disciplina);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 40 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoAluno\pesquisa.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\n    </table>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Universidade.Models.AprovacaoAlunoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
