using System;
using System.Data.SqlClient;

namespace Bar.Repositories
{
  public abstract class BDContext
  {
    protected SqlConnection connection;
    public BDContext()
    {
      var strConnection = "Data Source = DESKTOP-506GQL0;Integrated Security = True;Initial Catalog = BDBar";
      connection = new SqlConnection(strConnection);
      connection.Open();
    }

    public void Dispose()
    {
      connection.Close();
    }
  }
}