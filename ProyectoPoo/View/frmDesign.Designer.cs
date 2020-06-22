using System.ComponentModel;

namespace ProyectoPoo
{
    partial class frmDesign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.tmBox = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer
            // 
<<<<<<< HEAD
            this.pictureBox1.Location = new System.Drawing.Point(326, 588);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 31);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
=======
            this.picPlayer.Location = new System.Drawing.Point(244, 382);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(142, 20);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
>>>>>>> refs/remotes/origin/master
            // 
            // tmBox
            // 
            this.tmBox.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
=======
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picPlayer);
>>>>>>> refs/remotes/origin/master
            this.Name = "frmDesign";
            this.Text = "frmDesign";
            this.Load += new System.EventHandler(this.frmDesign_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDesign_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDesign_MouseMove);
            ((System.ComponentModel.ISupportInitialize) (this.picPlayer)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Timer tmBox;

        #endregion
    }
}