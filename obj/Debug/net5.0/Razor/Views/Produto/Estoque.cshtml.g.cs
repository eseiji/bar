#pragma checksum "D:\.vscodeProjects\fatec\testeConexao\Views\Produto\Estoque.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1cccddf15d4f92fc9a41b68706c32ce5ed6c050"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Estoque), @"mvc.1.0.view", @"/Views/Produto/Estoque.cshtml")]
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
#line 1 "D:\.vscodeProjects\fatec\testeConexao\Views\_ViewImports.cshtml"
using Bar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.vscodeProjects\fatec\testeConexao\Views\_ViewImports.cshtml"
using Bar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1cccddf15d4f92fc9a41b68706c32ce5ed6c050", @"/Views/Produto/Estoque.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1592cacf30dbd9ae614e6665fb5587295a9a5d55", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Estoque : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bar.Models.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/cardapio.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1cccddf15d4f92fc9a41b68706c32ce5ed6c0504828", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.vscodeProjects\fatec\testeConexao\Views\Produto\Estoque.cshtml"
  
  ViewBag.Title = "Estoque";
  int cont = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<header>
  <nav class=""navbar navbar-expand-lg border-bottom border-dark box-shadow"" style=""padding: 8px 20px"">
    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
      <ul class=""navbar-nav mr-auto"">
        <li class=""nav-item active"">
          <a class=""navbar-brand text-white"" href=""#"">Bar<span class=""sr-only"">(current)</span></a>
        </li>
      </ul>
      <ul class=""navbar-nav"">
        <li class=""nav-item"">
          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1cccddf15d4f92fc9a41b68706c32ce5ed6c0506660", async() => {
                WriteLiteral("Sair");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n      </ul>\r\n    </div>\r\n  </nav>\r\n</header>\r\n\r\n<section class=\"container\">\r\n  <h2 style=\"color: white;\">Estoque</h2>\r\n\r\n");
#nullable restore
#line 28 "D:\.vscodeProjects\fatec\testeConexao\Views\Produto\Estoque.cshtml"
   if (@ViewBag.Estoque != null && @ViewBag.Estoque.Count > 0)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-hover table-dark"" style=""background: #28282d; color: white; padding: 100px;"">
      <thead>
        <tr>
          <th>#</th>
          <th>Descricao</th>
          <th>Qtd</th>
          <th>Valor Un</th>
          <th>Data Inclusao</th>
          <th>Status</th>
          <th>&nbsp</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 43 "D:\.vscodeProjects\fatec\testeConexao\Views\Produto\Estoque.cshtml"
         foreach (var produto in @ViewBag.Estoque)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\r\n            <td>");
#nullable restore
#line 46 "D:\.vscodeProjects\fatec\testeConexao\Views\Produto\Estoque.cshtml"
           Write(cont);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 47 "D:\.vscodeProjects\fatec\testeConexao\Views\Produto\Estoque.cshtml"
           Write(produto.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 48 "D:\.vscodeProjects\fatec\testeConexao\Views\Produto\Estoque.cshtml"
           Write(produto.Estoque);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>R$ ");
#nullable restore
#line 49 "D:\.vscodeProjects\fatec\testeConexao\Views\Produto\Estoque.cshtml"
              Write(Math.Round(@produto.Valor, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 50 "D:\.vscodeProjects\fatec\testeConexao\Views\Produto\Estoque.cshtml"
           Write(Convert.ToDateTime(@produto.DataInclusao).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 51 "D:\.vscodeProjects\fatec\testeConexao\Views\Produto\Estoque.cshtml"
           Write(produto.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1653, "\"", 1701, 2);
            WriteAttributeValue("", 1660, "/produto/editarProduto/", 1660, 23, true);
#nullable restore
#line 52 "D:\.vscodeProjects\fatec\testeConexao\Views\Produto\Estoque.cshtml"
WriteAttributeValue("", 1683, produto.IdProduto, 1683, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-secondary\">Editar</a>&nbsp<a");
            BeginWriteAttribute("href", "\r\n            href=\"", 1753, "\"", 1815, 2);
            WriteAttributeValue("", 1773, "/produto/excluirProduto/", 1773, 24, true);
#nullable restore
#line 53 "D:\.vscodeProjects\fatec\testeConexao\Views\Produto\Estoque.cshtml"
WriteAttributeValue("", 1797, produto.IdProduto, 1797, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-danger\">Excluir</a></td>\r\n          </tr>\r\n");
#nullable restore
#line 55 "D:\.vscodeProjects\fatec\testeConexao\Views\Produto\Estoque.cshtml"
          cont++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </tbody>\r\n    </table>\r\n    <a href=\"/produto/adicionarProduto\" class=\"btn btn-sm btn-primary\">Adicionar produto</a>\r\n    <a href=\"/mesa/index\" class=\"btn btn-sm btn-secondary\">Voltar</a>\r\n");
#nullable restore
#line 62 "D:\.vscodeProjects\fatec\testeConexao\Views\Produto\Estoque.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bar.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
