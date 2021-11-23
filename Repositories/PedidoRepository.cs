using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Bar.Models;

namespace Bar.Repositories
{
  public class PedidoRepository : BDContext, IPedidoRepository
  {
    public void Create(List<Produto> produtos)
    {
      try
      {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        //cmd.CommandText = "select us.cpf from usuario us join cliente cli on (us.id_usuario = cli.id_usuario) where us.cpf= '@Cpf'";
        cmd.CommandText = "insert into pedido (valor, data_inclusao, status, id_mesa, id_cliente, id_funcionario) values (@valor, GETDATE(), 1, 1, 1, 1)" + "select @@IDENTITY";

        cmd.Parameters.AddWithValue("@valor", "sim"); //AJUSTAR ===================================================

        int idPedido = Convert.ToInt32(cmd.ExecuteScalar());

        foreach (var item in produtos)
        {
          SqlCommand cmdProd = new SqlCommand();
          cmdProd.Connection = connection;

          cmdProd.CommandText = "insert into produto_pedido values (@id_pedido, @id_produto, @qtd_vendida, @valor_unitario)";
          cmdProd.Parameters.AddWithValue("@id_pedido", idPedido);
          cmdProd.Parameters.AddWithValue("@id_produto", item.IdProduto);
          cmdProd.Parameters.AddWithValue("@qtd_vendida", item.Quantidade);
          cmdProd.Parameters.AddWithValue("@valor_unitario", item.Valor);

          SqlDataReader Reader = cmdProd.ExecuteReader();
        }

        //cmd.Parameters.AddWithValue("@id", id);
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