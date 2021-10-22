using System;
using System.Collections.Generic;
using Bar.Models;
using System.Data.SqlClient;

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
    }
*/
    public Usuario Read(string Cpf)
    {
      try
      {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        cmd.CommandText = "SELECT * FROM Usuario WHERE cpf = @cpf";

        cmd.Parameters.AddWithValue("@cpf", Cpf);

        SqlDataReader reader = cmd.ExecuteReader();

        if (reader.Read())
        {
          Usuario usuario = new Usuario();
          usuario.Cpf = reader.GetString(0);

          return usuario;
        }

        return null;

      }
      catch (Exception ex)
      {
        throw new Exception("Usuário não encontrada.");
      }
      finally
      {
        Dispose();
      }
    }
  }
}