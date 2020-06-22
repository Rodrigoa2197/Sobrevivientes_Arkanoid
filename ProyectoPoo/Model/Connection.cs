using System.Data;
using Npgsql;

namespace ProyectoPoo
{
    public static class Connection
    {
        private static string host = "127.0.0.1",
            database = "POOproyecto",
            userId = "postgres",
<<<<<<< HEAD
            //password = "gaseosa1234";
            password = "00303318";
            //password = "uca";
=======
            password = "uca";
>>>>>>> refs/remotes/origin/master

            private static string sConnection =
            $"Server={host};Port=5432;User Id={userId};Password={password};Database={database};";
        
<<<<<<< HEAD
        public static DataTable ExecuteQuery(string query)
=======
            public static DataTable ExecuteQuery(string query)
>>>>>>> refs/remotes/origin/master
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
