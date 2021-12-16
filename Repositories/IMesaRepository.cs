using System.Collections.Generic;
using Bar.Models;

namespace Bar.Repositories
{
  public interface IMesaRepository
  {
    List<Mesa> Read();
    List<Pedido> Pedidos(int id);
    List<Produto> Produtos(int id);
    void AtualizarPedido(int id, List<Pedido> pedidos);
  }
}