using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Bar.Models;

namespace Bar.Repositories
{
  public class ProdutoMemoryRepository : BDContext, IProdutoMemoryRepository
  {


    private static List<Produto> produtos = new List<Produto>();
    public void Create(Produto model)
    {
      produtos.Add(model);
    }

    public List<Produto> Read()
    {
      return produtos;
    }
  }
}