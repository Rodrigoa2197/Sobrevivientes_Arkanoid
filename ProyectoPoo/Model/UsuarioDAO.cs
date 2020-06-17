using System;

namespace ProyectoPoo
{
    public class UsuarioDAO
    {
        public static void CreateNew(string usuario)
        {
            string sql = String.Format(
                "INSERT INTO Usuario(usuario) VALUES ('{0}');",
                usuario);

            Connection.ExecuteNonQuery(sql);
        }
    }
}