using System;
using System.Data.SqlClient; 

// 3 classes principais do namespace SqlClient:
// SqlConnection (usada para conectar e desconectar com o banco de dados)
// SqlCommand (usada para executar um comando SQL a partir da conexão estabelecida)
// SqlDataReader (usada para percorrer os dados consultados pelo comando SQL)

namespace Bar.Repositories
{
    public abstract class BDContext
    {
        // Atributo
        protected SqlConnection connection;

        // Construtor
        public BDContext()
        {
            var strConnection = "Data Source = localhost; Integrated Security = True; Initial Catalog = nome_banco_bar";
            connection = new SqlConnection(strConnection);
            connection.Open();
            Console.WriteLine("Abri a conexão");
        }

        public void Dispose()
        {
            connection.Close();
            Console.WriteLine("Fechei a conexão");
        }
    }
}