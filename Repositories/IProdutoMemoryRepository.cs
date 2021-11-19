using System.Collections.Generic;
using Bar.Models;

namespace Bar.Repositories
{
  public interface IProdutoMemoryRepository
  {
    //void Create(Produto model);
    List<int> Read();
    void Create(int id);

    //Produto Read(int id);
    //void Update(int id, Produto model);
    //void Delete(int id);
  }
}