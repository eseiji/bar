using System.Collections.Generic;
using Bar.Models;

namespace Bar.Repositories
{
  public interface IProdutoRepository
  {
    List<Produto> Read();
    Produto BuscarProduto(int id);
    List<Produto> SelecionarProduto(int id);
    void EditarProduto(int id, Produto produto);
    void ExcluirProduto(int id);
    List<Produto> Estoque();
    void AdicionarProduto(Produto produto);
  }
}