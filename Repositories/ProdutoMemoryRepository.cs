using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Bar.Models;

namespace Bar.Repositories
{
  public class ProdutoMemoryRepository : IProdutoMemoryRepository
  {


    private static List<int> teste = new List<int>();
    public void Create(int id)
    {
      teste.Add(id);
    }

    public List<int> Read()
    {
      return teste;
    }
  }
}