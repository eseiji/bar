using System.Collections.Generic;
using Bar.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Bar.Models
{
  public class ProdutoController : Controller
  {
    private IProdutoRepository repository;

    public ProdutoController(IProdutoRepository repository)
    {
      this.repository = repository;
    }

    public ActionResult Cardapio()
    {
      List<Produto> produtos = repository.Read();
      return View(produtos);
    }
  }
}