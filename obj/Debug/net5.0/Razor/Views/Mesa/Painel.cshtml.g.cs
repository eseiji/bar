#pragma checksum "D:\.vscodeProjects\fatec\testeConexao\Views\Mesa\Painel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f752cca96808f8a6063004a69512f0dc6a1a2dd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mesa_Painel), @"mvc.1.0.view", @"/Views/Mesa/Painel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f752cca96808f8a6063004a69512f0dc6a1a2dd6", @"/Views/Mesa/Painel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1592cacf30dbd9ae614e6665fb5587295a9a5d55", @"/Views/_ViewImports.cshtml")]
    public class Views_Mesa_Painel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bar.Models.Usuario>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f752cca96808f8a6063004a69512f0dc6a1a2dd64808", async() => {
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
#line 3 "D:\.vscodeProjects\fatec\testeConexao\Views\Mesa\Painel.cshtml"
  
  ViewBag.Title = "Perfil";
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f752cca96808f8a6063004a69512f0dc6a1a2dd66635", async() => {
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
            WriteLiteral("\r\n        </li>\r\n      </ul>\r\n    </div>\r\n  </nav>\r\n</header>\r\n\r\n<section class=\"container\">\r\n\r\n");
#nullable restore
#line 27 "D:\.vscodeProjects\fatec\testeConexao\Views\Mesa\Painel.cshtml"
   if (@ViewBag.Pedidos != null && @ViewBag.Pedidos.Count > 0)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h2 style=""color: white;"">Lista de Pedidos</h2>
    <table class=""table table-hover table-dark"" style=""background: #28282d; color: white; padding: 100px;"">
      <thead>
        <tr>
          <th>#</th>
          <th>Valor</th>
          <th>Situação</th>
          <th>&nbsp</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 40 "D:\.vscodeProjects\fatec\testeConexao\Views\Mesa\Painel.cshtml"
         foreach (var pedido in @ViewBag.Pedidos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\r\n            <td>");
#nullable restore
#line 43 "D:\.vscodeProjects\fatec\testeConexao\Views\Mesa\Painel.cshtml"
           Write(cont);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>R$ ");
#nullable restore
#line 44 "D:\.vscodeProjects\fatec\testeConexao\Views\Mesa\Painel.cshtml"
              Write(Math.Round(@pedido.Valor, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 45 "D:\.vscodeProjects\fatec\testeConexao\Views\Mesa\Painel.cshtml"
             if (@pedido.Status == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <td>Em andamento</td>\r\n");
#nullable restore
#line 48 "D:\.vscodeProjects\fatec\testeConexao\Views\Mesa\Painel.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <td>Pago</td>\r\n");
#nullable restore
#line 52 "D:\.vscodeProjects\fatec\testeConexao\Views\Mesa\Painel.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><a");
            BeginWriteAttribute("href", " href=\"", 1549, "\"", 1621, 4);
            WriteAttributeValue("", 1556, "/mesa/visualizarPedido/?id=", 1556, 27, true);
#nullable restore
#line 53 "D:\.vscodeProjects\fatec\testeConexao\Views\Mesa\Painel.cshtml"
WriteAttributeValue("", 1583, pedido.IdPedido, 1583, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1599, "&status=", 1599, 8, true);
#nullable restore
#line 53 "D:\.vscodeProjects\fatec\testeConexao\Views\Mesa\Painel.cshtml"
WriteAttributeValue("", 1607, pedido.Status, 1607, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Visualizar</a></td>\r\n          </tr>\r\n");
#nullable restore
#line 55 "D:\.vscodeProjects\fatec\testeConexao\Views\Mesa\Painel.cshtml"
          cont++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tbody>\r\n    </table>\r\n    <a href=\"/mesa/validarpedido\" class=\"btn btn-sm btn-primary\">Validar e encerrar pedidos</a>\r\n");
#nullable restore
#line 60 "D:\.vscodeProjects\fatec\testeConexao\Views\Mesa\Painel.cshtml"
  }
  else
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 style=\"color: white;\">O cliente ainda não realizou nenhum pedido.</h2>\r\n");
#nullable restore
#line 64 "D:\.vscodeProjects\fatec\testeConexao\Views\Mesa\Painel.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  <a href=\"/mesa/index\" class=\"btn btn-sm btn-secondary\">Voltar</a>\r\n</section>");
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
