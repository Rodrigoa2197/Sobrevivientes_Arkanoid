using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class ControlTop : UserControl
    {
        private Label[,] players;

        public delegate void EventControlT(object sender, EventArgs e);
        public EventControlT OnClickButton;
        public ControlTop()
        {
            InitializeComponent(); 
        }

        public void ControlTop_Load(object sender, EventArgs e)
        {
            LoadPlayers();
        }
        private void LoadPlayers()
        {
            var playerList = PlayerDAO.ObtainTopPlayers();
            players = new Label[10,2];
            int sampleTop = label1.Bottom + 50, sampleLeft =20;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    players[i,j] = new Label();
                    if (j == 0)
                    {
                        players[i, j].Text = playerList[i].Usuario;
                        players[i, j].Left = sampleLeft;
                    }
                    else
                    {
                        players[i, j].Text = playerList[i].Puntaje.ToString();
                        players[i, j].Left = Width / 2 + sampleLeft;
                    }
                    players[i, j].Top = sampleTop + 24 * i;
                    players[i, j].Height += 4;
                    players[i, j].Width += 30;
                    players[i, j].Font = new Font("Microsoft YaHei", 14F);
                    players[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    Controls.Add(players[i, j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}