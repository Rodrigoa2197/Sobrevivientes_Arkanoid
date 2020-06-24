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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesign));
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.tmBox = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer
            // 
            this.picPlayer.Location = new System.Drawing.Point(244, 382);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(142, 20);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // tmBox
            // 
            this.tmBox.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picPlayer);
            this.DoubleBuffered = true;
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