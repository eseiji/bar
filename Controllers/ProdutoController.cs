using System;
using System.Collections.Generic;
using Bar.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Text.Json;
using System.Reflection.Metadata;

namespace Bar.Models
{
  public class ProdutoController : Controller
  {
    private IProdutoRepository repository;
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

    public ActionResult Estoque()
    {
      List<Produto> produtos = repository.Estoque();
      ViewBag.Estoque = produtos;
      return View();
    }

    public ActionResult selecionarProduto(int id)
    {
      List<Produto> teste = repository.SelecionarProduto(id);

      return RedirectToAction("Cardapio", teste[teste.Count - 1]);
    }

    public ActionResult incrementoQtd(int id)
    {
      List<Produto> produto = repository.SelecionarProduto(id);
      foreach (var item in selecionados)
      {
        if (item.IdProduto == id)
        {
          item.Quantidade = item.Quantidade + 1;
          if (produto[0].Estoque < item.Quantidade)
          {
            item.Quantidade = item.Quantidade - 1;
          }
        }
      }
      produto.Clear();
      return RedirectToAction("Cardapio", null);
    }

    public ActionResult decrementoQtd(int id)
    {
      int cont = 0;
      foreach (var item in selecionados)
      {
        if (item.IdProduto == id)
        {
          if (item.Quantidade > 1)
          {
            item.Quantidade = item.Quantidade - 1;
          }
          else
          {
            selecionados.RemoveAt(cont);
            return RedirectToAction("Cardapio", null);
          }
        }
        cont++;
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

    public ActionResult AdicionarProduto()
    {
      return View();
    }

    [HttpPost]
    public ActionResult AdicionarProduto(Produto produto)
    {
      repository.AdicionarProduto(produto);
      return RedirectToAction("Estoque", "Produto");
    }

    public ActionResult EditarProduto(int id)
    {
      Produto produto = repository.BuscarProduto(id);
      return View(produto);
    }

    [HttpPost]
    public ActionResult EditarProduto(int id, Produto produto)
    {
      repository.EditarProduto(id, produto);
      return RedirectToAction("Estoque", "Produto");
    }

    public ActionResult ExcluirProduto(int id)
    {
      repository.ExcluirProduto(id);
      return RedirectToAction("Estoque", "Produto");
    }
  }
}
