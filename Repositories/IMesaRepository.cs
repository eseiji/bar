using System.Collections.Generic;
using Bar.Models;

namespace Bar.Repositories
{
  public interface IMesaRepository
  {
    List<Mesa> Read();
    List<Mesa> Read(int id);
    List<Pedido> Pedidos(int id);
    List<Produto> Produtos(int id);
    void AtualizarPedido(List<Pedido> pedidos);
  }
}