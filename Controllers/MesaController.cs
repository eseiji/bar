using System;
using System.Collections.Generic;
using System.Text.Json;
using Bar.Models;
using Bar.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bar.Controllers
{
  public class MesaController : Controller
  {
    private IMesaRepository repository;

    public MesaController(IMesaRepository repository)
    {
      this.repository = repository;
    }

    private static List<Pedido> selecionados = new List<Pedido>();

    public ActionResult Index()
    {
      var nome = HttpContext.Session.GetString("NomeUsuario");
      ViewBag.Nome = nome;

      List<Mesa> mesas = repository.Read();
      ViewBag.Mesas = mesas;
      foreach (var item in mesas)
      {
        if (item.Status == 1)
        {
          item.TextoStatus = "Disponível";
        }
        else
        {
          item.TextoStatus = "Em uso";
        }
      }
      return View();
    }
    public ActionResult Painel(int id)
    {
      /*
      if (id == 0)
      {
        var idTemp = JsonSerializer.Deserialize<Int32>(TempData["idMesa"] as String);
        id = idTemp;
        TempData["idMesa"] = JsonSerializer.Serialize(id);
      }
      else
      {
        TempData["idMesa"] = null;
        TempData["idMesa"] = JsonSerializer.Serialize(id);
      }*/
      List<Pedido> pedidos = repository.Pedidos(id);
      if (pedidos.Count > 0)
      {
        ViewBag.Pedidos = pedidos;
        selecionados = pedidos;
      }
      else
      {
        selecionados.Clear();
      }
      return View();
    }

    public ActionResult VisualizarPedido(int id, int status)
    {
      //TempData["IdPedido"] = JsonSerializer.Serialize(id);
      List<Produto> produtos = repository.Produtos(id);
      ViewBag.Produtos = produtos;
      /*
      JsonSerializer.Deserialize<Int32>(TempData["StatusPedido"] as String);
      TempData["StatusPedido"] = JsonSerializer.Serialize(ViewBag.Pedidos[0].Status);*/
      return View("Pedidos");
    }


    public ActionResult ValidarPedido()
    {

      var id = HttpContext.Session.GetInt32("IdUsuario");
      repository.AtualizarPedido((int)id, selecionados);
      //TempData["IdPedido"] = JsonSerializer.Serialize(id);
      /*
      List<Produto> produtos = repository.Produtos(id);
      ViewBag.Produtos = produtos;
      JsonSerializer.Deserialize<Int32>(TempData["StatusPedido"] as String);
      TempData["StatusPedido"] = JsonSerializer.Serialize(ViewBag.Pedidos[0].Status);*/
      return View("Painel");
    }

    public ActionResult AdicionarProduto()
    {
      return View();
    }

    [HttpPost]
    public ActionResult AdicionarProduto(Produto produto)
    {
      return View();
    }
  }
}

