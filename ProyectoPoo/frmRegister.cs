using System;
using System.Windows.Forms;
using NpgsqlTypes;

namespace ProyectoPoo
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            frmLevel window = new frmLevel();
            
            UsuarioDAO.CreateNew(textBox1.Text);
            MessageBox.Show("Usuario agregado con exito!",
                "Welcome to the game!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            window.Show();
            this.Hide();
        }

        private void frmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", 
                "ARKANOID GAME", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}