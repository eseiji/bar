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
    //private IProdutoMemoryRepository mrepository;

    public ProdutoController(IProdutoRepository repository)
    {
      this.repository = repository;
    }

    public ActionResult Cardapio(int id)
    {
      List<Produto> produtos = repository.Read();
      ViewBag.produtos = produtos;

      List<int> teste = repository.Create(id);
      ViewBag.teste = teste;

      return View();
    }

    public ActionResult Create(int id)
    {
      //List<Produto> teste2 = repository.Query(id);
      List<int> teste = repository.Create(id);
      ViewBag.teste = teste;
      //ViewBag.teste2 = teste2;
      return RedirectToAction("Cardapio");
    }

    public ActionResult Carrinho(int id)
    {
      return RedirectToAction("Create");
      /*
      var produto = repository.Read(id);
      Console.WriteLine("Passou");
      return View(produto);*/
    }

    public void CarrinhoTeste(List<int> produtosTeste)
    {
      Console.WriteLine("PASSOU");
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
