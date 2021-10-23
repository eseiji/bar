using Bar.Models;
using System.Collections.Generic;
using System;

namespace Bar.Repositories
{
  public interface IUsuarioRepository
  {
    Usuario Read(string CPF);
  }
}