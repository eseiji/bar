using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Bar.Models;

namespace Bar.Repositories
{
  public class MesaRepository : BDContext, IMesaRepository
  {
    public List<Mesa> Read()
    {
      try
      {
        List<Mesa> lista_mesa = new List<Mesa>();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        //cmd.CommandText = "select us.cpf from usuario us join cliente cli on (us.id_usuario = cli.id_usuario) where us.cpf= '@Cpf'";
        cmd.CommandText = "select id_mesa, status from mesa";
        //cmd.CommandText = "select m.id_mesa, m.status, pe.valor, pe.data_inclusao from mesa m join pedido pe on (pe.id_mesa = m.id_mesa) where m.status = 1 and pe.status = 1 and pe.data_inclusao = CONVERT (date, GETDATE())";

        //cmd.Parameters.AddWithValue("@cpf", Cpf);

        SqlDataReader Reader = cmd.ExecuteReader();


        while (Reader.Read())
        {
          Mesa mesa = new Mesa();
          mesa.IdMesa = Reader.GetInt32("id_mesa");
          mesa.Status = Reader.GetInt32("status");

          lista_mesa.Add(mesa);
        }

        return lista_mesa;

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

    public List<Mesa> Read(int id)
    {
      try
      {
        List<Mesa> lista_info_pedido = new List<Mesa>();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        //cmd.CommandText = "select us.cpf from usuario us join cliente cli on (us.id_usuario = cli.id_usuario) where us.cpf= '@Cpf'";
        cmd.CommandText = "select pe.valor, pe.data_inclusao, prod.descricao, pr.qtd_vendida, pr.valor_unitario, us.nome from mesa m join pedido pe on (pe.id_mesa = m.id_mesa) join usuario us on (us.id_usuario = pe.id_cliente) join produto_pedido pr on (pr.id_pedido = pe.id_pedido) join produto prod on (prod.id_produto = pr.id_produto) where pe.status in (1, 2) and pe.data_inclusao = CONVERT(date, GETDATE()) and m.id_mesa = @id";

        cmd.Parameters.AddWithValue("@id", id);

        SqlDataReader Reader = cmd.ExecuteReader();


        while (Reader.Read())
        {
          /*
          Produto produto = new Produto();
          produto.Valor = Reader.GetDecimal("valor");
          produto.IdMesa = Reader.GetInt32("id_mesa");
          produto.Status = Reader.GetInt32("status");*/

          Mesa dados = new Mesa();

          dados.Valor = Reader.GetDecimal("valor");
          dados.Data = Reader.GetDateTime("data_inclusao");
          dados.Descricao = Reader.GetString("descricao");
          dados.Quantidade = Reader.GetInt32("qtd_vendida");
          dados.ValorUn = Reader.GetDecimal("valor_unitario");
          dados.NomeCliente = Reader.GetString("nome");

          lista_info_pedido.Add(dados);
        }

        return lista_info_pedido;

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

    public List<Pedido> Pedidos(int id)
    {
      try
      {
        List<Pedido> lista_pedidos = new List<Pedido>();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        cmd.CommandText = "select pe.id_pedido, pe.data_inclusao, pe.status, sum(pr.qtd_vendida * pr.valor_unitario) as total, pe.id_mesa from pedido pe join produto_pedido pr on (pr.id_pedido = pe.id_pedido) join produto prod on (prod.id_produto = pr.id_produto) where pe.id_mesa = @id and pe.data_inclusao = CONVERT(date, GETDATE()) and pe.status in (1, 2) group by pe.id_pedido, pe.data_inclusao, pe.status, pe.id_mesa order by pe.data_inclusao desc";

        cmd.Parameters.AddWithValue("@id", id);

        //cmd.CommandText = "select us.cpf from usuario us join cliente cli on (us.id_usuario = cli.id_usuario) where us.cpf= '@Cpf'";

        //cmd.Parameters.AddWithValue("@cpf", Cpf);

        SqlDataReader Reader = cmd.ExecuteReader();

        while (Reader.Read())
        {
          Pedido pedido = new Pedido();
          pedido.IdPedido = Reader.GetInt32("id_pedido");
          pedido.Data = Reader.GetDateTime("data_inclusao");
          pedido.Status = Reader.GetInt32("status");
          pedido.Valor = Reader.GetDecimal("total");
          pedido.IdMesa = Reader.GetInt32("id_mesa");

          lista_pedidos.Add(pedido);
        }

        return lista_pedidos;

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

    public List<Produto> Produtos(int id)
    {
      try
      {
        List<Produto> lista_produtos = new List<Produto>();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        cmd.CommandText = "select prod.descricao, pr.qtd_vendida, pr.valor_unitario from pedido pe join produto_pedido pr on (pr.id_pedido = pe.id_pedido) join produto prod on (prod.id_produto = pr.id_produto) where pe.id_pedido = @id";

        cmd.Parameters.AddWithValue("@id", id);

        //cmd.CommandText = "select us.cpf from usuario us join cliente cli on (us.id_usuario = cli.id_usuario) where us.cpf= '@Cpf'";

        //cmd.Parameters.AddWithValue("@cpf", Cpf);

        SqlDataReader Reader = cmd.ExecuteReader();

        while (Reader.Read())
        {
          Produto produto = new Produto();
          produto.Descricao = Reader.GetString("descricao");
          produto.Quantidade = Reader.GetInt32("qtd_vendida");
          produto.Valor = Reader.GetDecimal("valor_unitario");

          lista_produtos.Add(produto);
        }

        return lista_produtos;

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

    public void AtualizarPedido(int id, List<Pedido> pedidos)
    {
      try
      {

        foreach (var item in pedidos)
        {
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = connection;
          cmd.CommandText = "update pedido set status = 3, id_funcionario = @id_funcionario where id_pedido = @id_pedido";
          cmd.Parameters.AddWithValue("@id_funcionario", id);
          cmd.Parameters.AddWithValue("@id_pedido", item.IdPedido);


          SqlCommand cmdUpdateMesa = new SqlCommand();
          cmdUpdateMesa.Connection = connection;
          cmdUpdateMesa.CommandText = "update mesa set status = 1 where id_mesa = @id_mesa";
          cmdUpdateMesa.Parameters.AddWithValue("@id_mesa", item.IdMesa);

          cmdUpdateMesa.ExecuteNonQuery();
          cmd.ExecuteNonQuery();
        }



        //cmd.CommandText = "select us.cpf from usuario us join cliente cli on (us.id_usuario = cli.id_usuario) where us.cpf= '@Cpf'";

        //cmd.Parameters.AddWithValue("@cpf", Cpf);


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