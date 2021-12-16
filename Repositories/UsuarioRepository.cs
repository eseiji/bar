using System;
using System.Collections.Generic;
using Bar.Models;
using System.Data.SqlClient;
using System.Data;

namespace Bar.Repositories
{
  public class UsuarioRepository : BDContext, IUsuarioRepository
  {
    public Usuario Read(string Cpf, string Tipo)
    {
      try
      {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        if (Tipo == "cliente")
        {
          cmd.CommandText = "select us.cpf, us.id_usuario, us.nome from usuario us join cliente cli on (us.id_usuario = cli.id_usuario) where us.cpf= @Cpf";
        }
        if (Tipo == "funcionario")
        {
          cmd.CommandText = "select us.cpf, us.id_usuario, us.nome from usuario us join funcionario func on (us.id_usuario = func.id_usuario) where us.cpf= @Cpf";
        }

        cmd.Parameters.AddWithValue("@cpf", Cpf);

        SqlDataReader Reader = cmd.ExecuteReader();

        if (Reader.Read())
        {
          Usuario usuario = new Usuario();
          usuario.Cpf = Reader.GetString(0);
          usuario.IdUsuario = Reader.GetInt32(1);
          usuario.Nome = Reader.GetString(2);

          return usuario;
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

    public List<Pedido> Pedidos(int id)
    {
      try
      {
        List<Pedido> lista_pedidos = new List<Pedido>();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        cmd.CommandText = "select pe.id_pedido, pe.data_inclusao, pe.status, sum(pr.qtd_vendida * pr.valor_unitario) as total, pe.id_mesa from pedido pe join produto_pedido pr on (pr.id_pedido = pe.id_pedido) join produto prod on (prod.id_produto = pr.id_produto) where pe.id_cliente = @id group by pe.id_pedido, pe.data_inclusao, pe.id_mesa, pe.status order by pe.data_inclusao desc";

        cmd.Parameters.AddWithValue("@id", id);

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
      }
      finally
      {
        Dispose();
      }
    }

    public void Pagamento(int id)
    {
      try
      {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        cmd.CommandText = "update pedido set status = 2 where id_pedido = @id";

        cmd.Parameters.AddWithValue("@id", id);

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