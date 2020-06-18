namespace ProyectoPoo
{
    public class Score
    {
        public int ScoreID { get; }
        public int score { get; set; }
        public string nickname { get; set; }

        public Score()
        {
            ScoreID = 0;
            score = 0;
            nickname = "";
        }
    }
}