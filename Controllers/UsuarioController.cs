using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Bar.Models;
using Bar.Repositories;
using System;
using System.Linq;

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
        //ViewBag.Message = "Usuário não encontrado!";
        Console.WriteLine("Usuário não encontrado!");
        ViewBag.Message = "Usuário não encontrado!";
        //return View(model);
      }
      else
      {
        if (model.Tipo == "cliente")
        {
          HttpContext.Session.SetInt32("IdCliente", usuario.IdUsuario);
          return RedirectToAction("Cardapio", "Produto");
        }
        if (model.Tipo == "funcionario")
        {
          return RedirectToAction("Index", "Mesa");
        }
        Console.WriteLine("Usuário encontrado!");
        //return View("Index", "Mesa");
        //return View(usuario);
      }

      //HttpContext.Session.SetString("Tipo", usuario.Tipo);
      //ViewBag.Message = "Usuário encontrado!";
      //Console.WriteLine("Usuário encontrado!");

      return View();
    }

    public ActionResult Admin()
    {
      return View();
    }
  }
}