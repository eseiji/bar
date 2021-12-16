using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Bar.Models;

namespace Bar.Repositories
{
  public class PedidoRepository : BDContext, IPedidoRepository
  {
    public void Create(int id, List<Produto> produtos)
    {
      try
      {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;

        Decimal valor_total = 0;

        foreach (var item in produtos)
        {
          valor_total = valor_total + (item.Quantidade * item.Valor);
        }
        cmd.CommandText = "insert into pedido (valor, data_inclusao, status, id_mesa, id_cliente) values (@valor, GETDATE(), 1, 1, @id_cliente)" + "select @@IDENTITY";

        cmd.Parameters.AddWithValue("@valor", valor_total);
        cmd.Parameters.AddWithValue("@id_cliente", id);

        int idPedido = Convert.ToInt32(cmd.ExecuteScalar());

        foreach (var item in produtos)
        {
          SqlCommand cmdInsertProd = new SqlCommand();
          cmdInsertProd.Connection = connection;
          cmdInsertProd.CommandText = "insert into produto_pedido values (@id_pedido, @id_produto, @qtd_vendida, @valor_unitario)";
          cmdInsertProd.Parameters.AddWithValue("@id_pedido", idPedido);
          cmdInsertProd.Parameters.AddWithValue("@id_produto", item.IdProduto);
          cmdInsertProd.Parameters.AddWithValue("@qtd_vendida", item.Quantidade);
          cmdInsertProd.Parameters.AddWithValue("@valor_unitario", item.Valor);

          SqlCommand cmdUpdateProd = new SqlCommand();
          cmdUpdateProd.Connection = connection;
          cmdUpdateProd.CommandText = "update produto set qtd_estoque = (qtd_estoque - @qtd_estoque) where id_produto = @id";
          cmdUpdateProd.Parameters.AddWithValue("@qtd_estoque", item.Quantidade);
          cmdUpdateProd.Parameters.AddWithValue("@id", item.IdProduto);

          SqlCommand cmdUpdateMesa = new SqlCommand();
          cmdUpdateMesa.Connection = connection;
          cmdUpdateMesa.CommandText = "update mesa set status = 2 where id_mesa = @id_mesa";
          cmdUpdateMesa.Parameters.AddWithValue("@id_mesa", 1);

          cmdUpdateProd.ExecuteNonQuery();
          cmdInsertProd.ExecuteNonQuery();
          cmdUpdateMesa.ExecuteNonQuery();
        }
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