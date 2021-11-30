using System;
using System.Collections.Generic;
using Bar.Models;
using System.Data.SqlClient;
using System.Data;

namespace Bar.Repositories
{
  public class UsuarioDatabaseRepository : BDContext
  {
    /*
    public void Create(Usuario model)
    {
      try
      {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        // cmd.CommandText = "EXEC CREATE_TAREFA @texto, @idUsuario";

        cmd.CommandText = "CREATE_TAREFA";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@texto", model.Texto);
        cmd.Parameters.AddWithValue("@idusuario", 2);

        cmd.ExecuteNonQuery();

      }
      catch (Exception ex)
      {
        // Armazenar a exceção em um log.
        Console.WriteLine(ex.Message);
      }
      finally
      {
        Dispose();
      }
    }

    public void Delete(int id)
    {
      try
      {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        cmd.CommandText = "DELETE FROM Tarefa WHERE Id = @id";

        cmd.Parameters.AddWithValue("@id", id);

        cmd.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        // Armazenar a exceção em um log.
      }
      finally
      {
        Dispose();
      }
    }

    public void Update(int id, Tarefa model)
    {
      try
      {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        cmd.CommandText = "UPDATE Tarefa SET Texto = @texto, Concluida = @concluida WHERE Id = @id";

        cmd.Parameters.AddWithValue("@texto", model.Texto);
        cmd.Parameters.AddWithValue("@concluida", model.Concluida);
        cmd.Parameters.AddWithValue("@id", id);

        cmd.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        // Armazenar a exceção em um log.
      }
      finally
      {
        Dispose();
      }
    }

    public List<Tarefa> Read()
    {
      try
      {
        List<Tarefa> lista = new List<Tarefa>();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        cmd.CommandText = "SELECT Id, Texto, Concluida, Usuario FROM ViewTarefa";

        SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
          Tarefa tarefa = new Tarefa();
          tarefa.Id = reader.GetInt32(0);
          tarefa.Texto = reader.GetString(1);
          tarefa.Concluida = reader.GetBoolean(2);
          tarefa.Usuario = new Usuario
          {
            Nome = reader.GetString(3)
          };

          lista.Add(tarefa);
        }

        return lista;
      }
      catch (Exception ex)
      {
        // Armazenar a exceção em um log.
        throw new Exception(ex.Message);
      }
      finally
      {
        Dispose();
      }
    }*/

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

        //cmd.CommandText = "select us.cpf from usuario us join cliente cli on (us.id_usuario = cli.id_usuario) where us.cpf= '@Cpf'";


        //cmd.Parameters.AddWithValue("@cpf", Cpf);

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

        cmd.CommandText = "select pe.id_pedido, pe.data_inclusao, pe.status, sum(pr.qtd_vendida * pr.valor_unitario) as total, pe.id_mesa from pedido pe join produto_pedido pr on (pr.id_pedido = pe.id_pedido) join produto prod on (prod.id_produto = pr.id_produto) where pe.id_cliente = @id group by pe.id_pedido, pe.data_inclusao, pe.id_mesa, pe.status order by pe.data_inclusao desc";

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

    public void Pagamento(int id)
    {
      try
      {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        cmd.CommandText = "update pedido set status = 2 where id_pedido = @id";

        cmd.Parameters.AddWithValue("@id", id);

        //cmd.CommandText = "select us.cpf from usuario us join cliente cli on (us.id_usuario = cli.id_usuario) where us.cpf= '@Cpf'";

        //cmd.Parameters.AddWithValue("@cpf", Cpf);
        cmd.ExecuteNonQuery();

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


/*
public Usuario Read(Usuario usuario)
{
  try
  {
    SqlCommand cmd = new SqlCommand();
    cmd.Connection = connection;

    cmd.CommandText = "select us.cpf from usuario us join cliente cli on (us.id_usuario = cli.id_usuario) where us.cpf= @Cpf";

    cmd.Parameters.AddWithValue("@cpf", usuario.Cpf);

    SqlDataReader Reader = cmd.ExecuteReader();

    Usuario UsuarioEncontrado = new Usuario();
    if (Reader.Read())
    {
      UsuarioEncontrado.Cpf = Reader.GetString("cpf");
    }

    return UsuarioEncontrado;
  }
  catch (Exception ex)
  {
    throw new Exception("Usuario não encontrado!");
    //Console.WriteLine(ex.Message);
    //return null;
  }
  finally
  {
    Dispose();
  }
}

internal Usuario Read(string cpf)
{
  throw new NotImplementedException();
}
}
}*/