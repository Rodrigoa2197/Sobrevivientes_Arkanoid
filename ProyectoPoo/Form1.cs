﻿using System;
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
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTop frame = new frmTop();
            frame.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}