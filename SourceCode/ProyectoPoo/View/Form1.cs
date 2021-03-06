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
        private Player currentPlayer;
        private frmDesign ds;
        public Form1()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }
         private void Form1_Load(object sender, EventArgs e)
                {
                    
                }
         
        private void button1_Click(object sender, EventArgs e)
        {
            int localGetId;
            //ds = new frmDesign();
            frmRegister window = new frmRegister();
            window.Show();
            window.gn = (string user) =>
            {

                if (PlayerDAO.verifyPlayer(user))
                {
                    MessageBox.Show($"Bienvenido Nuevamente {user}");
                    localGetId = PlayerDAO.GetIdPlayer(user);
                }
                else
                {
                    MessageBox.Show($"Gracias por registrarte {user}");
                    localGetId = PlayerDAO.GetIdPlayer(user);
                }
                currentPlayer = new Player(localGetId,0);
                window.Dispose();
                frmDesign design = new frmDesign(currentPlayer);
                design.Show();
                this.Hide();
            };
        }
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1);
            tableLayoutPanel1.Controls.Add(new ControlTop());
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