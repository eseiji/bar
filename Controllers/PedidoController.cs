using System.Collections.Generic;
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

  }
}