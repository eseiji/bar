using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Bar.Models;
using Bar.Repositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;

namespace Bar.Controllers
{
  public class UsuarioController : Controller
  {
    private IUsuarioRepository repository;

    public UsuarioController(IUsuarioRepository repository)
    {
      this.repository = repository;
    }

    [HttpGet]
    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Login(Usuario model)
    {
      Usuario usuario = repository.Read(model.Cpf, model.Tipo);

      if (usuario == null)
      {
        ViewBag.Message = "Usuário não encontrado!";
      }
      else
      {
        HttpContext.Session.SetInt32("IdUsuario", usuario.IdUsuario);
        HttpContext.Session.SetString("NomeUsuario", usuario.Nome);
        if (model.Tipo == "cliente")
        {
          return RedirectToAction("Perfil");
        }
        if (model.Tipo == "funcionario")
        {
          return RedirectToAction("Index", "Mesa");
        }
      }

      return View();
    }
    public ActionResult Perfil()
    {
      var id = HttpContext.Session.GetInt32("IdUsuario");
      var nome = HttpContext.Session.GetString("NomeUsuario");
      List<Pedido> pedidos = repository.Pedidos((int)id);
      if (pedidos.Count > 0)
      {
        foreach (var pedido in pedidos)
        {
        }
        ViewBag.Pedidos = pedidos;
      }
      ViewBag.Nome = nome;
      return View();
    }

    public ActionResult VisualizarPedido(int id, int status)
    {
      TempData["IdPedido"] = JsonSerializer.Serialize(id);
      List<Produto> produtos = repository.Produtos(id);
      ViewBag.Produtos = produtos;
      ViewBag.Status = status;
      return View("Pedido");
    }

    public ActionResult Pagamento()
    {
      var id = JsonSerializer.Deserialize<Int32>(TempData["IdPedido"] as String);
      repository.Pagamento(id);
      return RedirectToAction("Perfil");
    }

    public ActionResult Cardapio()
    {
      return RedirectToAction("Cardapio", "Produto");
    }
  }
}