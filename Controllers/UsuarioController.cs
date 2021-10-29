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
      Usuario usuario = repository.Read(model.Cpf);
      //Usuario usuario = repository.ValidarLogin(model.Cpf);

      if (usuario == null)
      {
        //ViewBag.Message = "Usuário não encontrado!";
        Console.WriteLine("Usuário não encontrado!");
        //return View(model);
      }
      else
      {
        Console.WriteLine("Usuário encontrado!");
        return RedirectToAction("Index", "Mesa");
        //return View("Index", "Mesa");
        //return View(usuario);
      }
      //ViewBag.Message = "Usuário encontrado!";
      //Console.WriteLine("Usuário encontrado!");

      return View();
    }
  }
}