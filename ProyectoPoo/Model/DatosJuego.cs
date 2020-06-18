namespace ProyectoPoo
{
    public static class DatosJuego
    {
        //Variables necesarias para poder interactuar con el juego
        public static bool juegoIniciado = false;
        public static double ticksCount = 0;
        public static int dirX = 20, dirY = -dirX,  lifes = 3, score = 0;
        
        
        public static void InitializeGame()
        {
            juegoIniciado = false;
            ticksCount = 0;
            lifes = 3;
            score = 0;
        }
    }
}