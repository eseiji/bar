using Bar.Models;
using System.Collections.Generic;
using System;

namespace Bar.Repositories
{
  public interface IUsuarioRepository
  {
    Usuario Read(string Cpf, string Tipo);
    List<Pedido> Pedido(int id);
  }
}