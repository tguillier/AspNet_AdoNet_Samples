using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AdoSample
{
    public static class DisconnectedMode
    {
        public static DataSet RunSelectCommand(int id)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=AdoSample;Integrated Security=True";

            var selectCommand = new SqlCommand();
            selectCommand.Connection = connection;
            selectCommand.CommandText = "SELECT * FROM Client WHERE Id > @ClientId";
            selectCommand.Parameters.AddWithValue("@ClientId", id);

            var adapter = new SqlDataAdapter(selectCommand);
            var data = new DataSet();

            try
            {
                connection.Open();
                adapter.Fill(data, "Client");

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void WriteData(this DataSet data)
        {
            // Notation "SQL Like"
            IEnumerable<Client> clients =
                from row in data.Tables["Client"].AsEnumerable()
                
                select new Client
                {
                    Id = row.Field<int>("Id"),
                    Name = row.Field<string>("Name")
                };

            // Notation "Fluent"
            IEnumerable<Client> clients2 = data.Tables["Client"]
                .AsEnumerable()
                .Select(row => new Client
                {
                    Id = row.Field<int>("Id"),
                    Name = row.Field<string>("Name")
                });

            foreach (Client client in clients)
            {
                Console.WriteLine($"Client {client.Id}, Nom : {client.Name}");
            }
        }
    }
}
