using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class frmDesign : Form
    {
        //Creando la matriz.
        private CustomPictureBox[,] cpb;
        private Panel scorePanel, blackPanel;
        private Label remainingLifes, score;
        private PictureBox ball;

        private double tiempoTranscurido = 0, tiempoLimite = 4;
        private int remainingPb = 0;


        // Para trabajar con pic + label
        private PictureBox heart;

        // Para trabajar con n pic
        private PictureBox[] hearts;

        private delegate void BallActions();
        private Player currentPlayer;

        private readonly BallActions BallMovements;
        public Action FinishGame, WinningGame;



        public frmDesign()
        {
            InitializeComponent();
            BallMovements = rebotarPelota;
            BallMovements += MoveBall;

            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000; // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void frmDesign_Load(object sender, EventArgs e)
        {
            ScoresPanel();
            // Creando la barra de el jugador atraves de codigo
            pictureBox1.BackgroundImage = Image.FromFile("../../Resources/Player.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Top = Height - pictureBox1.Height - 80;

            pictureBox1.Left = (Width / 2) - (pictureBox1.Width / 2);

            //Creando la bola del juego atraves de codigo.
            ball = new PictureBox();
            ball.Width = ball.Height = 20;
            ball.BackgroundImage = Image.FromFile("../../Resources/Ball.png");
            ball.BackgroundImageLayout = ImageLayout.Stretch;

            ball.Top = pictureBox1.Top - ball.Height;
            ball.Left = pictureBox1.Left + (pictureBox1.Width / 2) - (ball.Width / 2);
            Controls.Add(ball);

            LoadTile();
            timer1.Start();
        }

        private void LoadTile()
        {
            //Creando el diseno de los cuadros atraves del custompicture box.
            int xAxis = 10;
            int yAxis = 5;

            int pbHeight = (int) (Height * 0.3) / yAxis;
            int pbWidth = Width / xAxis;

            cpb = new CustomPictureBox[yAxis, xAxis];
            for (int i = 0; i < yAxis; i++)
            {
                for (int j = 0; j < xAxis; j++)
                {
                    cpb[i, j] = new CustomPictureBox();

                    if (i == 0)
                        cpb[i, j].Golpes = 2;
                    else
                        cpb[i, j].Golpes = 1;
                    cpb[i, j].Height = pbHeight;
                    cpb[i, j].Width = pbWidth;

                    //posiciones de la matriz
                    cpb[i, j].Left = j * pbWidth;
                    cpb[i, j].Top = i * pbHeight;

                    if (i == 1)
                        cpb[i, j].BackgroundImage = Image.FromFile("../../Resources/blinded.png");
                    else
                        cpb[i, j].BackgroundImage = Image.FromFile("../../Resources/" + GRN() + ".png");
                    cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;

                    int imageBack;
                    if (i % 2 == 0 && j % 2 == 0)
                        imageBack = 3;
                    else if (i % 2 == 0 && j % 2 != 0)
                        imageBack = 4;
                    else if (i % 2 != 0 && j % 2 == 0)
                        imageBack = 4;
                    else
                        imageBack = 3;

                    if (i == 4)
                    {
                        cpb[i, j].BackgroundImage = Image.FromFile("../../Resources/tb1.png");
                        cpb[i, j].Tag = "blinded";
                    }
                    else
                    {
                        cpb[i, j].BackgroundImage = Image.FromFile("../../Resources/" + imageBack + ".png");
                        cpb[i, j].Tag = "tileTag";
                    }

                    cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    Controls.Add(cpb[i, j]);
                }
            }
        }

        private int GRN()
        {
            return new Random().Next(1, 8);
        }

        // Creando el movimiento de la barra player y que inicie en medio de la pantalla.
        private void frmDesign_MouseMove(object sender, MouseEventArgs e)
        {
            //Movimiento de barra y pelota cuando el juego no ha iniciado.
            if (!DatosJuego.juegoIniciado)
            {
                if (e.X < (Width - pictureBox1.Width))
                {
                    pictureBox1.Left = e.X;
                    ball.Left = pictureBox1.Left + (pictureBox1.Width / 2) - (ball.Width / 2);
                }
            }
            //Movimiento de barra y pelota cuando el juego ya inicio.
            else
            {
                if (e.X < (Width - pictureBox1.Width))
                    pictureBox1.Left = e.X;

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!DatosJuego.juegoIniciado)
                return;
            try
            {
                BallMovements?.Invoke();
            }
            catch (OutBoundsException ex)
            {
                try
                {
                    DatosJuego.lifes--;
                    DatosJuego.juegoIniciado = false;
                    timer1.Stop();

                    RepositionElements();
                    UpdateElements();

                    if (DatosJuego.lifes == 0)
                    
                        throw new NoRemainingLifesException("Has Perdido!:(");
                    
                }
                catch (NoRemainingLifesException ex2)
                {
                    timer1.Stop();
                    FinishGame?.Invoke();
                    
                }
            }
        }


        //Creando boton para dar inicio al juego y que solamente se pueda con ese boton.
        private void frmDesign_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (!DatosJuego.juegoIniciado)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Space:
                            DatosJuego.juegoIniciado = true;
                            timer1.Start();
                            break;
                        default:
                            throw new WrongKeyException("Presione Space para iniciar el juego");
                    }
                }
            }
            catch (WrongKeyException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Creando los movimeinto de la pelota a traves de toda la ventana del juego.  
        private void rebotarPelota()
        {
            //Rebote en el lado izquierodo o derecho de la ventana.
            if (ball.Top < scorePanel.Height)
            {
                DatosJuego.dirY = -DatosJuego.dirY;
                return;
            }

            if (ball.Bottom > Height)
                throw new OutBoundsException("");

            if (ball.Left < 0 || ball.Right > Width)
            {
                DatosJuego.dirX = -DatosJuego.dirX;
                return;
            }
            // Rebote con el jugador.
            if (ball.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                DatosJuego.dirY = -DatosJuego.dirY;
                return;

            }
            //Manera en que colisionan con cpb.
            for (int i = 4; i >= 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (cpb[i, j] != null && ball.Bounds.IntersectsWith(cpb[i, j].Bounds))
                    {
                        DatosJuego.score += (int) (cpb[i, j].Golpes * DatosJuego.ticksCount);
                        cpb[i, j].Golpes--;

                        if (cpb[i, j].Golpes == 0)
                        {
                            Controls.Remove(cpb[i, j]);
                            cpb[i, j] = null;

                            remainingPb--;
                            
                        }
                        
                        else if (cpb[i, j].Tag.Equals("blinded"))
                            cpb[i, j].BackgroundImage = Image.FromFile("../../Resources/tb2.png");

                        DatosJuego.dirY = -DatosJuego.dirY;

                        score.Text = DatosJuego.score.ToString();

                        if (remainingPb == 0)
                        {
                            timer1.Stop();
                            
                            
                              /*PlayerDAO.CreateNewScore(currentPlayer.id_usuario, DatosJuego.score);
                                MessageBox.Show("Has ganado!");
                                this.Hide();
                                FinishGame?.Invoke();*/
              
                        }
             
                        return;
                    }
                }
            }
        }

        private void MoveBall()
        {
            ball.Left += DatosJuego.dirX;
            ball.Top += DatosJuego.dirY;
        }
        
        private void CheckGame()
        {
            //Verificar que no hayan más bloques
            if (remainingPb == 0)
            {
                //detener timer
                timer1.Stop();
                //Agregar puntaje
                PlayerDAO.CreateNewScore(currentPlayer.id_usuario, DatosJuego.score);
                MessageBox.Show("Felicidades ha completado el juego.",
                    "Arkanoid", MessageBoxButtons.OK);
                //Cambiar de menu
                Form1 fr = new Form1();

                //Reiniciar valores de juego para permitir juego nuevo
                DatosJuego.lifes = 3;
                DatosJuego.score = 0;
                fr.Show();
            }
        }
        //Se encargara de inicializzr los elementos arriba de la ventana el puntaje y las vidas.
        private void ScoresPanel()
        {
            // Instanciar panel
            scorePanel = new Panel();

            // Setear elementos del panel
            scorePanel.Width = Width;
            scorePanel.Height = (int)(Height * 0.07);

            scorePanel.Top = scorePanel.Left = 0;

            scorePanel.BackColor = Color.Black;
            
            
            #region Label + PictureBox
            // Instanciar pictureBox
            heart = new PictureBox();

            heart.Height = heart.Width = scorePanel.Height;

            heart.Top = 0;
            heart.Left = 20;

            heart.BackgroundImage = Image.FromFile("../../Resources/Heart.png");
            heart.BackgroundImageLayout = ImageLayout.Stretch;
            #endregion

            #region N cantidad de PictureBox
            hearts = new PictureBox[DatosJuego.lifes];
            
            for(int i = 0; i < DatosJuego.lifes; i++)
            {
                // Instanciacion de pb
                hearts[i] = new PictureBox();

                hearts[i].Height = hearts[i].Width = scorePanel.Height;

                hearts[i].BackgroundImage = Image.FromFile("../../Resources/Heart.png");
                hearts[i].BackgroundImageLayout = ImageLayout.Stretch;

                hearts[i].Top = 0;

                if (i == 0)
                    // corazones[i].Left = 20;
                    hearts[i].Left = scorePanel.Width / 2;
                else
                {
                    hearts[i].Left = hearts[i - 1].Right + 5;
                }
            }
            #endregion
            
            
            // Instanciar labels
            remainingLifes = new Label();
            score = new Label();

            // Setear elementos de los labels
            remainingLifes.ForeColor = score.ForeColor = Color.White;

            remainingLifes.Text = "x " + DatosJuego.lifes.ToString();
            score.Text = DatosJuego.score.ToString();

            remainingLifes.Font = score.Font = new Font("Microsoft Sans Serif", 24F);
            remainingLifes.TextAlign = score.TextAlign = ContentAlignment.MiddleCenter;

            remainingLifes.Left = heart.Right + 5;
            score.Left = Width - 100;

            remainingLifes.Height = score.Height = scorePanel.Height;

            scorePanel.Controls.Add(heart);
            scorePanel.Controls.Add(remainingLifes);
            scorePanel.Controls.Add(score);

            foreach(var pb in hearts)
            {
                scorePanel.Controls.Add(pb);
            }

            Controls.Add(scorePanel);
        }
        private void RepositionElements()
        {
            pictureBox1.Left = (Width / 2) - (pictureBox1.Width / 2);
            ball.Top = pictureBox1.Top - ball.Height;
            ball.Left = pictureBox1.Left + (pictureBox1.Width / 2) - (ball.Width / 2);
        }

        // Actualizacion de elementos luego de perder una vida
        private void UpdateElements()
        {
            remainingLifes.Text = "x " + DatosJuego.lifes.ToString();
            scorePanel.Controls.Remove(hearts[DatosJuego.lifes]);
            hearts[DatosJuego.lifes] = null;
            if (DatosJuego.lifes == 0)
            {
                MessageBox.Show("Has perdido:(!");
                Form1 window = new Form1();
                DatosJuego.lifes = 3;
                DatosJuego.score = 0;
                window.Show();
                this.Hide();
            }

            if (remainingPb == 0)
            {
                CheckGame();
            }
            
        }
        
        
        
        
        
        
        
        
        
        



    }
}
