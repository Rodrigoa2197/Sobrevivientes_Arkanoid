using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class frmLevel : Form
    {
        public frmLevel()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }

        private void frmLevel_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmLevel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", 
                "ARKANOID GAME", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}