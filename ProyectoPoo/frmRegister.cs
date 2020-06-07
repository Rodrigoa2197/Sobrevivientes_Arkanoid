using System;
using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioDAO.CreateNew(textBox1.Text);
            MessageBox.Show("Usuario agregado con exito!",
                "Welcome to the game!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}