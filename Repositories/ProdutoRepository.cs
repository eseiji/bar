using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Bar.Models;

namespace Bar.Repositories
{
  public class ProdutoRepository : BDContext, IProdutoRepository
  {
    public List<Produto> Read()
    {
      try
      {
        List<Produto> lista_produto = new List<Produto>();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        //cmd.CommandText = "select us.cpf from usuario us join cliente cli on (us.id_usuario = cli.id_usuario) where us.cpf= '@Cpf'";
        cmd.CommandText = "select descricao, valor, tipo_produto from produto";

        //cmd.Parameters.AddWithValue("@cpf", Cpf);

        SqlDataReader Reader = cmd.ExecuteReader();


        while (Reader.Read())
        {
          Produto produto = new Produto();
          produto.Descricao = Reader.GetString("descricao");
          produto.Valor = Math.Round(Reader.GetDecimal("valor"), 2);
          produto.TipoProduto = Reader.GetInt32("tipo_produto");

          lista_produto.Add(produto);
        }

        return lista_produto;

      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
        //Console.WriteLine(ex.Message);
        //return null;
      }
      finally
      {
        Dispose();
      }
    }
  }
}