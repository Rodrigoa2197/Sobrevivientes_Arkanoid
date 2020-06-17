using System;
using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class frmTop : Form
    {
        public frmTop()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void frmTop_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmTop_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", 
                "ARKANOID GAME", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
