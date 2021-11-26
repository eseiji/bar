using System;
using System.Collections.Generic;
using System.Text.Json;
using Bar.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Bar.Models
{
  public class PedidoController : Controller
  {
    private IPedidoRepository repository;

    public PedidoController(IPedidoRepository repository)
    {
      this.repository = repository;
    }

    public ActionResult Carrinho()
    {
      if (TempData["selecionados"] != null)
      {
        var selecionados = JsonSerializer.Deserialize<List<Produto>>(TempData["selecionados"] as String);
        repository.Create(selecionados);
        ViewBag.Produtos = selecionados;
        //Console.WriteLine(selecionados);
      }

      return View();
    }

  }
}