using System.Collections.Generic;
using Bar.Models;

namespace Bar.Repositories
{
  public interface IMesaRepository
  {
    List<Mesa> Read();
  }
}