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
            UsuarioDAO.CreateNew(textBox1.Text);
            MessageBox.Show("Usuario agregado exitosamente!",
                "Welcome to our game! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            frmDesign design = new frmDesign();
            design.Show();
            this.Hide();
        }
        
        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir? ", 
                "ARKANOID GAME ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}