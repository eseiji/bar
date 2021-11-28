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
        cmd.CommandText = "select id_produto, descricao, valor, tipo_produto from produto";

        SqlCommand cmdProduto = new SqlCommand();
        cmdProduto.Connection = connection;

        //cmd.Parameters.AddWithValue("@cpf", Cpf);

        SqlDataReader Reader = cmd.ExecuteReader();


        while (Reader.Read())
        {
          Produto produto = new Produto();
          produto.IdProduto = Reader.GetInt32("id_produto");
          produto.Descricao = Reader.GetString("descricao");
          produto.Valor = Reader.GetDecimal("valor");
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

    /*    public Produto Read(int id)
        {
          try
          {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            //cmd.CommandText = "select us.cpf from usuario us join cliente cli on (us.id_usuario = cli.id_usuario) where us.cpf= '@Cpf'";
            cmd.CommandText = "select id_produto, descricao, valor, tipo_produto from produto where id_produto = @id";

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader Reader = cmd.ExecuteReader();


            if (Reader.Read())
            {
              Produto produto = new Produto();
              produto.IdProduto = Reader.GetInt32("id_produto");
              produto.Descricao = Reader.GetString("descricao");
              produto.Valor = Math.Round(Reader.GetDecimal("valor"), 2);
              produto.TipoProduto = Reader.GetInt32("tipo_produto");

              return produto;
            }

            return null;

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
        }*/

    public void InserirProduto(Produto model)
    {
      try
      {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        //cmd.CommandText = "select us.cpf from usuario us join cliente cli on (us.id_usuario = cli.id_usuario) where us.cpf= '@Cpf'";
        cmd.CommandText = "select id_produto, descricao, valor, tipo_produto from produto where id_produto = @id";
        cmd.CommandText = "insert into produto_pedido (id_produto, descricao, valor, tipo_produto) where id_produto = @id";

        //cmd.Parameters.AddWithValue("@id", id);

        SqlDataReader Reader = cmd.ExecuteReader();


        if (Reader.Read())
        {
          Produto produto = new Produto();
          produto.IdProduto = Reader.GetInt32("id_produto");
          produto.Descricao = Reader.GetString("descricao");
          produto.Valor = Math.Round(Reader.GetDecimal("valor"), 2);
          produto.TipoProduto = Reader.GetInt32("tipo_produto");
        }

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
    private static List<int> teste = new List<int>();
    private static List<Produto> teste2 = new List<Produto>();

    public List<Produto> Query(int id)
    {
      try
      {
        SqlCommand cmdProd = new SqlCommand();
        cmdProd.Connection = connection;

        //cmd.CommandText = "select us.cpf from usuario us join cliente cli on (us.id_usuario = cli.id_usuario) where us.cpf= '@Cpf'";
        cmdProd.CommandText = "select id_produto, descricao, valor, tipo_produto from produto where id_produto = @id";

        cmdProd.Parameters.AddWithValue("@id", id);

        SqlDataReader Reader = cmdProd.ExecuteReader();


        if (Reader.Read())
        {
          Produto produto = new Produto();
          produto.IdProduto = Reader.GetInt32("id_produto");
          produto.Descricao = Reader.GetString("descricao");
          produto.Valor = Math.Round(Reader.GetDecimal("valor"), 2);
          produto.TipoProduto = Reader.GetInt32("tipo_produto");

          teste2.Add(produto);
          return teste2;
        }

        return null;

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
      /*
      teste.Add(id);
      return teste;*/
    }
    public List<int> Create(int id)
    {
      teste.Add(id);
      return teste;
    }
  }
}