using System;
using System.Collections.Generic;
using Bar.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace Bar.Models
{
  public class ProdutoController : Controller
  {
    private IProdutoRepository repository;
    private IProdutoMemoryRepository mrepository;

    public ProdutoController(IProdutoRepository repository)
    {
      this.repository = repository;
    }

    public ActionResult Cardapio()
    {
      List<Produto> produtos = repository.Read();
      return View(produtos);
    }

    public ActionResult Create(Produto model)
    {
      mrepository.Create(model);
      return RedirectToAction("Cardapio");
    }

    public ActionResult Carrinho(int id)
    {

      return RedirectToAction("Cardapio");
      /*
      var produto = repository.Read(id);
      Console.WriteLine("Passou");
      return View(produto);*/
    }

    public ActionResult CarrinhoTeste()
    {
      HttpContext.Session.GetInt32("id");
      return RedirectToAction("Cardapio");
      /*
      var produto = repository.Read(id);
      Console.WriteLine("Passou");
      return View(produto);*/
    }

    [HttpPost]
    public ActionResult Carrinho(Produto model)
    {
      repository.InserirProduto(model);
      Console.WriteLine("Passou");
      return View();
    }
  }
}
