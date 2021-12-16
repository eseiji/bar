using System;
using System.Collections.Generic;
using System.Text.Json;
using Bar.Repositories;
using Microsoft.AspNetCore.Http;
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
        ViewBag.Produtos = selecionados;

        TempData["selecionados"] = JsonSerializer.Serialize(selecionados);
      }
      return View();
    }

    public ActionResult Finalizar()
    {
      var id = HttpContext.Session.GetInt32("IdUsuario");
      var selecionados = JsonSerializer.Deserialize<List<Produto>>(TempData["selecionados"] as String);
      repository.Create((int)id, selecionados);
      TempData["finalizado"] = JsonSerializer.Serialize("true");
      return RedirectToAction("Cardapio", "Produto");
    }

  }
}