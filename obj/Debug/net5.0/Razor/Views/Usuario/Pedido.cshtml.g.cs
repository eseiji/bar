#pragma checksum "D:\.vscodeProjects\fatec\testeConexao\Views\Usuario\Pedido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f03b40684d92ca97b8239abb4cf9bc28dc99e102"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Pedido), @"mvc.1.0.view", @"/Views/Usuario/Pedido.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f03b40684d92ca97b8239abb4cf9bc28dc99e102", @"/Views/Usuario/Pedido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1592cacf30dbd9ae614e6665fb5587295a9a5d55", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Pedido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bar.Models.Usuario>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f03b40684d92ca97b8239abb4cf9bc28dc99e1024823", async() => {
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
#line 3 "D:\.vscodeProjects\fatec\testeConexao\Views\Usuario\Pedido.cshtml"
  
  ViewBag.Title = "Perfil";
  decimal valor_total = 0;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f03b40684d92ca97b8239abb4cf9bc28dc99e1026681", async() => {
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
            WriteLiteral(@"
        </li>
      </ul>
    </div>
  </nav>
</header>

<section class=""container"">
  <h5 style=""color: white;"">Lista de Produtos</h5>
  <hr
    style=""border: 0; height: 0; border-top: 1px solid rgba(0, 0, 0, 0.1); border-bottom: 1px solid rgba(255, 255, 255, 0.3);"">

");
#nullable restore
#line 31 "D:\.vscodeProjects\fatec\testeConexao\Views\Usuario\Pedido.cshtml"
   if (@ViewBag.Produtos != null && @ViewBag.Produtos.Count > 0)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-hover table-dark"" style=""background: #28282d; color: white; padding: 100px;"">
      <thead>
        <tr>
          <th>#</th>
          <th>Descricão</th>
          <th>Quantidade</th>
          <th>Valor Un.</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 43 "D:\.vscodeProjects\fatec\testeConexao\Views\Usuario\Pedido.cshtml"
         foreach (var produto in @ViewBag.Produtos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\r\n            <td>");
#nullable restore
#line 46 "D:\.vscodeProjects\fatec\testeConexao\Views\Usuario\Pedido.cshtml"
           Write(cont);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 47 "D:\.vscodeProjects\fatec\testeConexao\Views\Usuario\Pedido.cshtml"
           Write(produto.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 48 "D:\.vscodeProjects\fatec\testeConexao\Views\Usuario\Pedido.cshtml"
           Write(produto.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>R$ ");
#nullable restore
#line 49 "D:\.vscodeProjects\fatec\testeConexao\Views\Usuario\Pedido.cshtml"
              Write(Math.Round(@produto.Valor, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          </tr>\r\n");
#nullable restore
#line 51 "D:\.vscodeProjects\fatec\testeConexao\Views\Usuario\Pedido.cshtml"
          valor_total = valor_total + (produto.Quantidade * produto.Valor);
          cont++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td></td>\r\n          <td></td>\r\n          <td></td>\r\n          <td>\r\n            <h3>R$ ");
#nullable restore
#line 59 "D:\.vscodeProjects\fatec\testeConexao\Views\Usuario\Pedido.cshtml"
              Write(Math.Round(@valor_total, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n          </td>\r\n        </tr>\r\n      </tbody>\r\n    </table>\r\n");
#nullable restore
#line 65 "D:\.vscodeProjects\fatec\testeConexao\Views\Usuario\Pedido.cshtml"
     if (@ViewBag.Status == 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <a href=\"/usuario/pagamento\" class=\"btn btn-sm btn-primary\">Realizar Pagamento</a>\r\n");
#nullable restore
#line 68 "D:\.vscodeProjects\fatec\testeConexao\Views\Usuario\Pedido.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"/usuario/perfil\" class=\"btn btn-sm btn-secondary\">Voltar</a>\r\n");
#nullable restore
#line 70 "D:\.vscodeProjects\fatec\testeConexao\Views\Usuario\Pedido.cshtml"
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