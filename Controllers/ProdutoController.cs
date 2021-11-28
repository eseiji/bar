using System;
using System.Collections.Generic;
using Bar.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Text.Json;

namespace Bar.Models
{
  public class ProdutoController : Controller
  {
    private IProdutoRepository repository;
    //private IProdutoMemoryRepository mrepository;
    public ProdutoController(IProdutoRepository repository)
    {
      this.repository = repository;
    }
    private static List<Produto> selecionados = new List<Produto>();
    public ActionResult Cardapio(Produto teste)
    {
      List<Produto> produtos = repository.Read();
      ViewBag.produtos = produtos;
      if (teste.Descricao != null)
      {
        selecionados.Add(teste);
        /*
        if (selecionados[0].Descricao == null)
        {
          selecionados.RemoveAt(0);
          ViewBag.testeFinal = null;
        }
        else
        {
          ViewBag.testeFinal = selecionados;
        }*/
      }
      if (TempData["finalizado"] != null)
      {
        var finalizado = JsonSerializer.Deserialize<String>(TempData["finalizado"] as String);
        if (finalizado == "true")
        {
          selecionados.Clear();
          TempData["finalizado"] = JsonSerializer.Serialize("false");
          return RedirectToAction("Perfil", "Usuario");
        }
      }
      ViewBag.testeFinal = selecionados;

      return View();
    }

    public ActionResult selecionarProduto(int id)
    {
      List<Produto> teste = repository.Query(id);
      //ViewBag.teste = teste;

      return RedirectToAction("Cardapio", teste[teste.Count - 1]);
    }
    /*CRIAR BOTÃO, CHAMAR MÉTODO PARA INCREMENTAR QUANTIDADE.
    PARA CADA ITEM DA LISTA "SELECIONADOS", COMPARAR COM O ID TRAZIDO PELO BOTÃO E ADICIONAR A QUANTIDADE*/

    /*
        public ActionResult Create(int id)
        {
          //List<Produto> teste2 = repository.Query(id);
          List<int> teste = repository.Create(id);
          ViewBag.teste = teste;
          //ViewBag.teste2 = teste2;
          return RedirectToAction("Cardapio");
        }*/

    public ActionResult incrementoQtd(int id)
    {
      foreach (var item in selecionados)
      {
        if (item.IdProduto == id)
        {
          item.Quantidade = item.Quantidade + 1;
        }
      }
      return RedirectToAction("Cardapio", null);
    }

    public ActionResult decrementoQtd(int id)
    {
      foreach (var item in selecionados)
      {
        if (item.IdProduto == id)
        {
          item.Quantidade = item.Quantidade - 1;
        }
      }
      return RedirectToAction("Cardapio", null);
    }

    public ActionResult Pedido()
    {
      TempData["selecionados"] = JsonSerializer.Serialize(selecionados);
      return RedirectToAction("Carrinho", "Pedido");
    }

    public ActionResult PedidoFinalizado()
    {
      var finalizado = JsonSerializer.Deserialize<List<Produto>>(TempData["finalizado"] as String);
      return RedirectToAction("Cardapio");
    }

    /*    public void CarrinhoTeste(List<int> produtosTeste)
        {
          Console.WriteLine("PASSOU");
          /*
          var produto = repository.Read(id);
          Console.WriteLine("Passou");
          return View(produto);
        }
    */
    [HttpPost]
    public void TesteQtd(List<int> qtd)
    {
      //repository.InserirProduto(model);
      Console.WriteLine(qtd);
    }
  }
}
