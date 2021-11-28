using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Bar.Models;
using Bar.Repositories;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Bar.Controllers
{
  public class UsuarioController : Controller
  {
    private UsuarioDatabaseRepository repository;

    public UsuarioController(UsuarioDatabaseRepository repository)
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
      //Usuario usuario = repository.ValidarLogin(model.Cpf);

      if (usuario == null)
      {
        Console.WriteLine("Usuário não encontrado!");
        ViewBag.Message = "Usuário não encontrado!";
      }
      else
      {
        if (model.Tipo == "cliente")
        {
          HttpContext.Session.SetInt32("IdCliente", usuario.IdUsuario);
          HttpContext.Session.SetString("NomeCliente", usuario.Nome);
          //return RedirectToAction("Cardapio", "Produto");
          return RedirectToAction("Perfil");
        }
        if (model.Tipo == "funcionario")
        {
          return RedirectToAction("Index", "Mesa");
        }
        Console.WriteLine("Usuário encontrado!");
      }

      return View();
    }

    public ActionResult Perfil()
    {
      var id = HttpContext.Session.GetInt32("IdCliente");
      var nome = HttpContext.Session.GetString("NomeCliente");
      List<Pedido> pedidos = repository.Pedido((int)id);
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

    public ActionResult Cardapio()
    {
      return RedirectToAction("Cardapio", "Produto");
    }

    public ActionResult Admin()
    {
      return View();
    }
  }
}