using System.Collections.Generic;
using Bar.Models;

namespace Bar.Repositories
{
  public interface IPedidoRepository
  {
    void Create(List<Produto> produto);
    /*
    List<Produto> Read(int id);
    Pedido Read();
    void Update(int id, Pedido model);
    void Delete(int id);*/
    //Pedido Read();
  }
}