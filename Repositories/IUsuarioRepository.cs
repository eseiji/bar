using Bar.Models;
using System.Collections.Generic;
using System;

namespace Bar.Repositories
{
  public interface IUsuarioRepository
  {
    Usuario Read(string Cpf, string Tipo);
    List<Pedido> Pedidos(int id);
    List<Produto> Produtos(int id);
    void Pagamento(int id);
  }
}