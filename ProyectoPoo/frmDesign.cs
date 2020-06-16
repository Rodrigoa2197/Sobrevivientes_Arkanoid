using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class frmDesign : Form
    {
        private CustomPictureBox[,] cpb;
        public frmDesign()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }

        private void frmDesign_Load(object sender, EventArgs e)
        {
            
            
            LoadTile();
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

                    cpb[i, j].Left = j * pbWidth;
                    cpb[i, j].Top = i * pbHeight;
                    
                    cpb[i,j].BackgroundImage = Image.FromFile("../../../Res/" + (i + 1) + ".png");
                    cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    
                    cpb[i,j].Tag = "titleTag";
                    Controls.Add(cpb[i,j]);
                }
            }
        }
        
        
            
        }
    }
