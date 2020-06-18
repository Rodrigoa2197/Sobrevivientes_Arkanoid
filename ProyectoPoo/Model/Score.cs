namespace ProyectoPoo
{
    public class Score
    {
        public int ScoreID { get; }
        public int puntuacion { get; set; }
        public string usuario { get; set; }

        public Score()
        {
            ScoreID = 0;
            puntuacion = 0;
            usuario = "";
        }
    }
}