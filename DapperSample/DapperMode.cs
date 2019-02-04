using Dapper;
using System;
using System.Data.SqlClient;

namespace AdoSample
{
    class DapperMode
    {
        // Plus de détails :
        // https://stackexchange.github.io/Dapper/
        // https://exceptionnotfound.net/dapper-vs-entity-framework-vs-ado-net-performance-benchmarking/
        // https://www.quora.com/Which-one-gives-better-performance-Dapper-Entity-Framework-or-ADO-NET

        public static void RunSelectCommand(int clientId)
        {
            var connection = new SqlConnection
            {
                ConnectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=AdoSample;Integrated Security=True"
            };

            var clients = connection.Query<Client>("SELECT * FROM Client WHERE Id > @Id", new { Id = clientId });

            foreach (var client in clients)
            {
                Console.WriteLine($"Id: {client.Id}, Nom: {client.Name}");
            }
        }

        public static int RunUpdateCommand(int clientId, string clientName)
        {
            var connection = new SqlConnection
            {
                ConnectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=AdoSample;Integrated Security=True"
            };

            string sql = "UPDATE Client SET Name = @ClientName WHERE Id = @ClientId";
            return connection.Execute(sql, new
            {
                ClientId = clientId,
                ClientName = clientName
            });
        }
    }
}
