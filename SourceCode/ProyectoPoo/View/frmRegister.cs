using System;
using System.Windows.Forms;
using NpgsqlTypes;

namespace ProyectoPoo
{
    public partial class frmRegister : Form
    {
        public delegate void GetUsuario(string text);
        public GetUsuario gn;
        public frmRegister()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                switch (textBox1.Text)
                {
                    case string aux when aux.Length > 15:
                        throw new ExceededMaxCharactersException("No se puede introducir un nick de mas de 15 car");
                    case string aux when aux.Trim().Length == 0:
                        throw new EmptyNicknameException("No puede dejar campos vacios");
                    default:
                        gn?.Invoke(textBox1.Text);
                        break;
                }
            }
            catch(EmptyNicknameException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ExceededMaxCharactersException ex)
            {
                MessageBox.Show(ex.Message);
            }
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