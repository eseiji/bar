using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Bar.Models;

namespace Bar.Repositories
{
  public class ProdutoRepository : BDContext, IProdutoRepository
  {
    private static List<Produto> produtos = new List<Produto>();
    public List<Produto> Read()
    {
      try
      {
        List<Produto> lista_produto = new List<Produto>();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        cmd.CommandText = "select id_produto, descricao, valor, tipo_produto from produto where qtd_estoque > 0 and status = 1";

        SqlCommand cmdProduto = new SqlCommand();
        cmdProduto.Connection = connection;

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
      }
      finally
      {
        Dispose();
      }
    }

    public Produto BuscarProduto(int id)
    {
      try
      {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        cmd.CommandText = "select id_produto, descricao, valor, tipo_produto, qtd_estoque, status from produto where id_produto = @id";
        cmd.Parameters.AddWithValue("@id", id);

        SqlDataReader Reader = cmd.ExecuteReader();

        if (Reader.Read())
        {
          Produto produto = new Produto();
          produto.IdProduto = Reader.GetInt32("id_produto");
          produto.Descricao = Reader.GetString("descricao");
          produto.Valor = Math.Round(Reader.GetDecimal("valor"), 2);
          produto.TipoProduto = Reader.GetInt32("tipo_produto");
          produto.Estoque = Reader.GetInt32("qtd_estoque");
          produto.Status = Reader.GetInt32("status");

          return produto;
        }

        return null;


      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
      finally
      {
        Dispose();
      }
    }
    public List<Produto> Estoque()
    {
      try
      {
        List<Produto> lista_produtos = new List<Produto>();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        cmd.CommandText = "select id_produto, descricao, tipo_produto, qtd_estoque, valor, data_inclusao, status from produto order by descricao";

        SqlDataReader Reader = cmd.ExecuteReader();

        while (Reader.Read())
        {
          Produto produto = new Produto();
          produto.IdProduto = Reader.GetInt32("id_produto");
          produto.Descricao = Reader.GetString("descricao");
          produto.TipoProduto = Reader.GetInt32("tipo_produto");
          produto.Estoque = Reader.GetInt32("qtd_estoque");
          produto.Valor = Reader.GetDecimal("valor");
          produto.DataInclusao = Reader.GetDateTime("data_inclusao");
          produto.Status = Reader.GetInt32("status");

          lista_produtos.Add(produto);
        }

        return lista_produtos;

      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
      finally
      {
        Dispose();
      }
    }

    public List<Produto> SelecionarProduto(int id)
    {
      try
      {
        SqlCommand cmdProd = new SqlCommand();
        cmdProd.Connection = connection;

        cmdProd.CommandText = "select id_produto, descricao, valor, qtd_estoque, tipo_produto from produto where id_produto = @id";

        cmdProd.Parameters.AddWithValue("@id", id);

        SqlDataReader Reader = cmdProd.ExecuteReader();


        if (Reader.Read())
        {
          Produto produto = new Produto();
          produto.IdProduto = Reader.GetInt32("id_produto");
          produto.Descricao = Reader.GetString("descricao");
          produto.Valor = Reader.GetDecimal("valor");
          produto.Estoque = Reader.GetInt32("qtd_estoque");
          produto.TipoProduto = Reader.GetInt32("tipo_produto");
          produto.Quantidade = 1;

          produtos.Add(produto);
          return produtos;
        }

        return null;

      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
      finally
      {
        Dispose();
      }
    }

    public void AdicionarProduto(Produto produto)
    {
      try
      {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;
        cmd.CommandText = "insert into produto (descricao, tipo_produto, qtd_estoque, valor, data_inclusao, status) values (@descricao, @tipo_produto, @qtd_estoque, @valor, GETDATE(), 1)";
        cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
        cmd.Parameters.AddWithValue("@tipo_produto", produto.TipoProduto);
        cmd.Parameters.AddWithValue("@qtd_estoque", produto.Estoque);
        cmd.Parameters.AddWithValue("@valor", produto.Valor);

        cmd.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
      finally
      {
        Dispose();
      }
    }
    public void EditarProduto(int id, Produto produto)
    {
      try
      {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;
        cmd.CommandText = "update produto set descricao = @descricao, tipo_produto = @tipo_produto, qtd_estoque = @qtd_estoque, valor = @valor, status = @status where id_produto = @id_produto";
        cmd.Parameters.AddWithValue("@id_produto", id);
        cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
        cmd.Parameters.AddWithValue("@tipo_produto", produto.TipoProduto);
        cmd.Parameters.AddWithValue("@qtd_estoque", produto.Estoque);
        cmd.Parameters.AddWithValue("@valor", produto.Valor);
        cmd.Parameters.AddWithValue("@status", produto.Status);

        cmd.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
      finally
      {
        Dispose();
      }
    }

    public void ExcluirProduto(int id)
    {
      try
      {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        cmd.CommandText = "update produto set status = 2 where id_produto = @id_produto";
        cmd.Parameters.AddWithValue("@id_produto", id);
        cmd.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
      finally
      {
        Dispose();
      }
    }

  }
}