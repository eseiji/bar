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
  }
}