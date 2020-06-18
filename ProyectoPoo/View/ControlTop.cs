using System;
using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class ControlTop : UserControl
    {
        public ControlTop()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void ControlTop_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ScoreDAO.Top10();
        }
    }
}