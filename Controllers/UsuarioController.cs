using Microsoft.AspNetCore.Mvc;
using Bar.Models;
using Bar.Repositories;

namespace Bar.Controllers
{
  public class UsuarioController : Controller
  {
    private UsuarioDatabaseRepository repository;

    [HttpGet]
    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Login(Usuario model)
    {
      Usuario usuario = repository.Read(model.Cpf);

      if (usuario == null)
      {
        return ViewBag.Message = "Usuário não encontrado!";
        //return View(model);
      }
      return ViewBag.Message = "Usuário encontrado!";

      //return RedirectToAction("Index", "Bar");
    }
  }
}