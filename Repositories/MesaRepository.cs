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
  }
}