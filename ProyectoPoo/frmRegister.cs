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
    }
}