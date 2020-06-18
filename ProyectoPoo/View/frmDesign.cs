using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class frmDesign : Form
    {
        private CustomPictureBox[,] cpb;
        private PictureBox ball;
        public frmDesign()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }

        private void frmDesign_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("../../Resources/Player.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Top = Height - pictureBox1.Height - 80;

            pictureBox1.Left = (Width / 2) - (pictureBox1.Width / 2);
            
            ball = new PictureBox();
            ball.Width = ball.Height = 20;
            ball.BackgroundImage = Image.FromFile("../../Resources/Ball.png");
            ball.BackgroundImageLayout = ImageLayout.Stretch;

            ball.Top = pictureBox1.Top - ball.Height;
            ball.Left = pictureBox1.Left + (pictureBox1.Width/2) - (ball.Width /2);
            Controls.Add(ball);

            LoadTile();
            timer1.Start();
        }

        private void LoadTile()
        {
            
            int xAxis = 10;
            int yAxis = 5;

            int pbHeight = (int) (Height * 0.3) / yAxis;
            int pbWidth = Width / xAxis;
            
            cpb = new CustomPictureBox[yAxis, xAxis];
            for (int i = 0; i < yAxis; i++)
            {
                for (int j = 0; j < xAxis; j++)
                {
                    cpb[i,j] = new CustomPictureBox();
                    
                    if (i == 0)
                        cpb[i, j].Golpes = 2;
                    else
                        cpb[i, j].Golpes = 1;
                    cpb[i, j].Height = pbHeight;
                    cpb[i, j].Width = pbWidth;
                    
                    //posiciones
                    cpb[i, j].Left = j * pbWidth;
                    cpb[i, j].Top = i * pbHeight;
                    
                    if (i==1)
                        cpb[i,j].BackgroundImage= Image.FromFile("../../Resources/blinded.png");    
                    else 
                        cpb[i,j].BackgroundImage= Image.FromFile("../../Resources/"+ GRN() +".png");
                    cpb[i,j].BackgroundImageLayout= ImageLayout.Stretch;
                    
                    
                    cpb[i,j].Tag = "titleTag";
                    Controls.Add(cpb[i,j]);
                }
            }
        }
        private int GRN()
        {
            return new Random().Next(1,8);
        }


        private void frmDesign_MouseMove(object sender, MouseEventArgs e)
        {
            if (!DatosJuego.juegoIniciado)
            {
                if(e.X < (Width - pictureBox1.Width))
                {
                    pictureBox1.Left = e.X;
                    ball.Left = pictureBox1.Left + (pictureBox1.Width / 2) - (ball.Width / 2);
                }
            }
            else
            {
                if (e.X < (Width - pictureBox1.Width))
                    pictureBox1.Left = e.X;
                
            }
            
        }
          private void timer1_Tick(object sender, EventArgs e)
                {
                    if(!DatosJuego.juegoIniciado)
                        return;
                    ball.Left += DatosJuego.dirX;
                    ball.Top += DatosJuego.dirY;
                    
                    rebotarPelota();
                }

        private void frmDesign_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                DatosJuego.juegoIniciado = true;
        }

        private void rebotarPelota()
        {
            if(ball.Bottom > Height)
                Application.Exit();
            if (ball.Left < 0 || ball.Right > Width)
            {
                DatosJuego.dirX = -DatosJuego.dirX; 
                return;
            }

            if (ball.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                DatosJuego.dirY = -DatosJuego.dirY;

            }
                
            for (int i = 4; i >= 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (ball.Bounds.IntersectsWith(cpb[i, j].Bounds))
                    {
                        cpb[i, j].Golpes--;
                        if(cpb[i,j].Golpes == 0)
                            Controls.Remove(cpb[i,j]);
                        DatosJuego.dirY = -DatosJuego.dirY;
                        return;
                    }
                }
            }
        }

      
    }
    }
