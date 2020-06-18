using System;
using System.Data;

namespace ProyectoPoo
{
    public class ScoreDAO
    {
        public static DataTable Top10()
        {
            DataTable puntuaciones = null;

            try
            {
                string sql = String.Format(
                    "SELECT Usuario, puntaje FROM PUNTAJE ORDER BY score desc LIMIT 10;");
                puntuaciones = Connection.ExecuteQuery(sql);
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
                throw;
            }

            return puntuaciones;
        }
    }
}