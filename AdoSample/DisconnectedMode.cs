using System;
using System.Data;
using System.Data.SqlClient;

namespace AdoSample
{
    public static class DisconnectedMode
    {
        public static DataSet RunSelectCommand(int id)
        {
            var connection = new SqlConnection
            {
                ConnectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=AdoSample;Integrated Security=True"
            };

            var selectCommand = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM Client WHERE Id > @Id"
            };
            selectCommand.Parameters.AddWithValue("@Id", id);

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
            foreach (DataRow row in data.Tables["Client"].Rows)
            {
                Console.WriteLine($"Client {row["Id"]}, Nom : {row["Name"]}");
            }
        }

        public static int RunUpdateCommand(int id, string name)
        {
            // Le procédé est le même que pour la sélection (SqlConnection, SqlCommand, SqlDataAdapter, DataSet, ...).

            // Points d'attention :
            // - En plus d'une SelectCommand, il faudra définir une UpdateCommand sur le SqlDataAdapter qui servira à l'alimentation et la mise à jour du DataSet
            // - Après avoir "Fill" le dataset et mis à jour les enregistrements qui nous intéressent, il faudra "Update" le dataset, cette méthode retourne le nombre d'enregistrements modifiés

            // Je trouve personnellement cette méthode peu intuitive mais elle permet de faire du "bulk update" (modification en masse).

            // Pour plus de détails :
            // https://www.aymericlagier.com/2010/01/29/introduction-a-ado-net-en-c/
            // https://docs.microsoft.com/fr-fr/dotnet/framework/data/adonet/

            return 0;
        }
    }
}
