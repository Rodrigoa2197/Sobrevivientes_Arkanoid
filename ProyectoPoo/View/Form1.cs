using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class Form1 : Form
    {
        private Player currentPlayer;
        public Form1()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            frmRegister window = new frmRegister();
            window.Show();
            window.gn = (string user) =>
            {
                if (PlayerDAO.CreateNewPlayer(user))
                {
                    MessageBox.Show($"Bienvenido Nuevamente {user}");
                }
                else
                {
                    MessageBox.Show($"Gracias por registrarte {user}");
                }
                currentPlayer = new Player(user,0);
                window.Dispose();
                frmDesign design = new frmDesign();
                design.Show();
                this.Hide();
            };

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Se ha agregado un metodo lambda para que habra una ventana aparte y no simultaneamente
            frmTop frame = new frmTop();
            frame.CloseAction = () =>
            {
                Show();
            };
            frame.Show();
            Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {         
            if (MessageBox.Show("¿Seguro que desea salir? ", 
                "ARKANOID GAME ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}