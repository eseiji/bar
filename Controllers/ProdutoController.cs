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
    public static List<Produto> selecionados = new List<Produto>();
    public ActionResult Cardapio(Produto teste)
    {
      List<Produto> produtos = repository.Read();
      ViewBag.produtos = produtos;
      selecionados.Add(teste);
      ViewBag.testeFinal = selecionados;
      if (selecionados[0].Descricao == null)
      {
        selecionados.RemoveAt(0);
        ViewBag.testeFinal = null;
      }
      else
      {
        ViewBag.testeFinal = selecionados;
      }
      return View();
    }

    public ActionResult Cardapio1(int id)
    {
      List<Produto> teste = repository.Query(id);
      //ViewBag.teste = teste;

      return RedirectToAction("Cardapio", teste[teste.Count - 1]);
    }

    /*
        public ActionResult Create(int id)
        {
          //List<Produto> teste2 = repository.Query(id);
          List<int> teste = repository.Create(id);
          ViewBag.teste = teste;
          //ViewBag.teste2 = teste2;
          return RedirectToAction("Cardapio");
        }*/

    public ActionResult Pedido()
    {
      TempData["selecionados"] = JsonSerializer.Serialize(selecionados);
      return RedirectToAction("Carrinho", "Pedido");
      /*
      var produto = repository.Read(id);
      Console.WriteLine("Passou");
      return View(produto);*/
    }

    /*    public void CarrinhoTeste(List<int> produtosTeste)
        {
          Console.WriteLine("PASSOU");
          /*
          var produto = repository.Read(id);
          Console.WriteLine("Passou");
          return View(produto);
        }

        [HttpPost]
        public ActionResult Carrinho(Produto model)
        {
          repository.InserirProduto(model);
          Console.WriteLine("Passou");
          return View();
        }*/
  }
}
