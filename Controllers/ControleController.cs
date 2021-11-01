using Bar.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bar.Controllers
{
  public class ControleController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}