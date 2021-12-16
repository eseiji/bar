using System.Collections.Generic;
using Bar.Models;

namespace Bar.Repositories
{
  public interface IPedidoRepository
  {
    void Create(int id, List<Produto> produto);
  }
}