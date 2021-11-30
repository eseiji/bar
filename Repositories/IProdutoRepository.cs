using System.Collections.Generic;
using Bar.Models;

namespace Bar.Repositories
{
  public interface IProdutoRepository
  {
    //void Create(Produto model);
    List<Produto> Read();
    Produto BuscarProduto(int id);
    List<int> Create(int id);
    List<Produto> Query(int id);
    //Produto Read(int id);
    void InserirProduto(Produto produto);
    void EditarProduto(int id, Produto produto);
    void ExcluirProduto(int id);
    List<Produto> Estoque();
    void AdicionarProduto(Produto produto);

    //Produto Read(int id);
    //void Update(int id, Produto model);
    //void Delete(int id);
  }
}