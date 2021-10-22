using System.Data.SqlClient;

namespace Bar.Repositories
{
  public abstract class BDContext
  {
    protected SqlConnection connection;
  }
}