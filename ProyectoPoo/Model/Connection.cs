using System.Data;
using Npgsql;

namespace ProyectoPoo
{
    public static class Connection
    {
        private static string host = "127.0.0.1",
            database = "ProyectoPoo",
            //database = "POOproyecto",
            userId = "postgres",
<<<<<<< HEAD
            //password = "gaseosa1234";
            password = "00303318";
            //password = "uca";

            private static string sConnection =
            $"Server={host};Port=5432;User Id={userId};Password={password};Database={database};";
        
        public static DataTable ExecuteQuery(string query)
=======
            password = "uca";
            //password = "00303318";
            //password = "gaseosa1234";
                

            private static string sConnection =
                $"Server={host};Port=5432;User Id={userId};Password={password};Database={database};";

            public static DataTable ExecuteQuery(string query)
>>>>>>> caa6b64bfeab95d44a72ff74b4567962f2e337a3
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            
            DataSet ds = new DataSet();
            
            connection.Open();
            
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);
            
            connection.Close();
            
            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string act)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            
            connection.Open();
            
            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            command.ExecuteNonQuery();
            
            connection.Close();
        }
    }
}
