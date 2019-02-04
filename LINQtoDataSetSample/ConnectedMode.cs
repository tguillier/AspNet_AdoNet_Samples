using System;
using System.Data.SqlClient;

namespace AdoSample
{
    class ConnectedMode
    {
        public static void RunSelectCommand(int clientId)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=AdoSample;Integrated Security=True";

            var selectCommand = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM Client WHERE Id > @Id"
            };
            selectCommand.Parameters.AddWithValue("@Id", clientId);

            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader["ContactName"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static int RunUpdateCommand(int clientId, string clientName)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=AdoSample;Integrated Security=True";

            var updateCommand = new SqlCommand
            {
                Connection = connection,
                CommandText = "UPDATE Client SET Name = @Name WHERE Id = @Id"
            };
            updateCommand.Parameters.AddWithValue("@Name", clientName);
            updateCommand.Parameters.AddWithValue("@Id", clientId);

            try
            {
                connection.Open();

                // ExecuteNonQuery() permet d'exécuter les requêtes ne retournant aucun résultat (à l'exception du nombre de lignes modifiées).
                return updateCommand.ExecuteNonQuery(); 
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
    }
}
