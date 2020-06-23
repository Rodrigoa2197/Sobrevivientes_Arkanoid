using System.Numerics;

namespace ProyectoPoo
{
    public class Player
    {
        public int id_usuario { get; set; }
        public string Usuario { get; set; }
        public int Puntaje { get; set; }

        public Player(string usuario, int puntaje)
        {
            Usuario = usuario;
            Puntaje = puntaje;
        }
    }
}