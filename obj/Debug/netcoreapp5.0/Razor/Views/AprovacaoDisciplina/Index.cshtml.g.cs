#pragma checksum "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3d5e5cfff059712d703b568c2aec1a021ebbb1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AprovacaoDisciplina_Index), @"mvc.1.0.view", @"/Views/AprovacaoDisciplina/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3d5e5cfff059712d703b568c2aec1a021ebbb1a", @"/Views/AprovacaoDisciplina/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1a4fa8d2d40697c6844bbec55f8b96421d7e546", @"/Views/_ViewImports.cshtml")]
    public class Views_AprovacaoDisciplina_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Universidade.Models.CursoModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("VALUE", "--Selecione--", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("VALUE", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("VALUE", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-center\">\n    <br>\n    <h1>Relatório de Aprovação por Disciplina</h1>\n    <br>\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d5e5cfff059712d703b568c2aec1a021ebbb1a4479", async() => {
                WriteLiteral("\n    <center>\n    <div>\n\n        <div class=\"col-sm-5\">\n            <label><strong>Cursos:</strong> </label>\n            <SELECT id=\"cursos\" class=\"form-control\" required>\n");
#nullable restore
#line 15 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d5e5cfff059712d703b568c2aec1a021ebbb1a5222", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                                         Write(item.nome);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                      WriteLiteral(item.nome);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("VALUE", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 18 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </SELECT>\n        </div>\n\n\n        <div class=\"col-sm-5\">\n            <label><strong>Ano:</strong> </label>\n");
#nullable restore
#line 25 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
              
                int ano = DateTime.Now.Year;

#line default
#line hidden
#nullable disable
                WriteLiteral("                <SELECT id=\"ano\" class=\"form-control\" required>\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d5e5cfff059712d703b568c2aec1a021ebbb1a7904", async() => {
                    WriteLiteral("--Selecione--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d5e5cfff059712d703b568c2aec1a021ebbb1a9152", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 29 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                                   Write(ano);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                      WriteLiteral(ano);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("VALUE", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d5e5cfff059712d703b568c2aec1a021ebbb1a11099", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 30 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                                        Write(ano-1);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                       WriteLiteral(ano-1);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("VALUE", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d5e5cfff059712d703b568c2aec1a021ebbb1a13057", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 31 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                                        Write(ano-2);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                       WriteLiteral(ano-2);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("VALUE", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d5e5cfff059712d703b568c2aec1a021ebbb1a15015", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 32 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                                        Write(ano-3);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                       WriteLiteral(ano-3);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("VALUE", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d5e5cfff059712d703b568c2aec1a021ebbb1a16973", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                                        Write(ano-4);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                       WriteLiteral(ano-4);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("VALUE", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d5e5cfff059712d703b568c2aec1a021ebbb1a18931", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                                        Write(ano-5);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                       WriteLiteral(ano-5);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("VALUE", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d5e5cfff059712d703b568c2aec1a021ebbb1a20889", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 35 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                                        Write(ano-6);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                       WriteLiteral(ano-6);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("VALUE", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d5e5cfff059712d703b568c2aec1a021ebbb1a22847", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 36 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                                        Write(ano-7);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                       WriteLiteral(ano-7);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("VALUE", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d5e5cfff059712d703b568c2aec1a021ebbb1a24805", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 37 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                                        Write(ano-8);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                       WriteLiteral(ano-8);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("VALUE", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d5e5cfff059712d703b568c2aec1a021ebbb1a26763", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 38 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                                        Write(ano-9);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                       WriteLiteral(ano-9);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("VALUE", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d5e5cfff059712d703b568c2aec1a021ebbb1a28721", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 39 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                                         Write(ano-10);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                       WriteLiteral(ano-10);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("VALUE", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </SELECT>\n");
                WriteLiteral("        </div>\n\n\n        <div class=\"col-sm-5\">\n            <label><strong>Semestre:</strong> </label>\n            <SELECT id=\"semestre\" class=\"form-control\" required>\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d5e5cfff059712d703b568c2aec1a021ebbb1a30920", async() => {
                    WriteLiteral("--Selecione--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d5e5cfff059712d703b568c2aec1a021ebbb1a32165", async() => {
                    WriteLiteral(" 1° semestre");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d5e5cfff059712d703b568c2aec1a021ebbb1a33409", async() => {
                    WriteLiteral(" 2° semestre");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </SELECT>
        </div>
    </div>
    <br /><br />
    
        
            <button type=""button"" id=""btn_exibir"" class=""btn btn-primary"">Exibir Relatório</button>
    
        
           <button type=""button"" id=""btn_voltar"" class=""btn btn-primary"">Voltar</button>
        
   
    </center>
");
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
            WriteLiteral("\n<br /><br />\n<div id=\"div_vazia\"></div>\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n<script>\n    $(document).on(\'click\', \'#btn_exibir\', exibir);\n\n        function exibir(){\n\n          var url = \"");
#nullable restore
#line 98 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                Write(Url.Action("Pesquisar", "AprovacaoDisciplina"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
          var curso = document.getElementById(""cursos"").value;
          var ano = parseInt(document.getElementById(""ano"").value);
          var semestre = parseInt(document.getElementById(""semestre"").value);

          if(curso == ""--Selecionar--""||isNaN(ano)||isNaN(semestre)){
            alert(""Todos os campos da pesquisa precisam estar preenchidos"")
          }else{
            $.ajax(url, {
            method: 'Get',
            data: {curso:curso,
                  ano:ano,
                  semestre:semestre
                  }
            }).done(function (response) {
              $(""#div_vazia"").html(response)
            }).fail(function () {
              swal('Atenção', 'Ocorreu um erro!', 'error')
            });

          }
      }
    $(document).on('click', '#btn_voltar', voltar);

        function voltar(){
            window.location.href = """);
#nullable restore
#line 123 "C:\Users\Openk\Desktop\Projeto Rodando\ProjetoUniversidadeC--main\Views\AprovacaoDisciplina\Index.cshtml"
                               Write(Url.Action("Index", "Cursos"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n        }\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Universidade.Models.CursoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591