using System.Collections.Generic;
using Bar.Models;

namespace Bar.Repositories
{
  public interface IProdutoRepository
  {
    //void Create(Produto model);
    List<Produto> Read();
    //Produto Read(int id);
    //void Update(int id, Produto model);
    //void Delete(int id);
  }
}