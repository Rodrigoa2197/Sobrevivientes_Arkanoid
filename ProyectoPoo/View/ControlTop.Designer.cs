using System.ComponentModel;

namespace ProyectoPoo
{
    partial class ControlTop
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
           System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlTop));
           this.label1 = new System.Windows.Forms.Label();
           this.button1 = new System.Windows.Forms.Button();
           this.SuspendLayout();
           // 
           // label1
           // 
           this.label1.BackColor = System.Drawing.Color.Transparent;
           this.label1.Dock = System.Windows.Forms.DockStyle.Top;
           this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
           this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
           this.label1.Location = new System.Drawing.Point(0, 0);
           this.label1.Name = "label1";
<<<<<<< HEAD
           this.label1.Size = new System.Drawing.Size(691, 152);
=======
           this.label1.Size = new System.Drawing.Size(519, 99);
>>>>>>> refs/remotes/origin/master
           this.label1.TabIndex = 1;
           this.label1.Text = "TOP 10";
           this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           // 
           // button1
           // 
           this.button1.BackColor = System.Drawing.Color.Transparent;
           this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
           this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
<<<<<<< HEAD
           this.button1.Location = new System.Drawing.Point(235, 156);
           this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
           this.button1.Name = "button1";
           this.button1.Size = new System.Drawing.Size(215, 64);
=======
           this.button1.Location = new System.Drawing.Point(177, 101);
           this.button1.Name = "button1";
           this.button1.Size = new System.Drawing.Size(161, 42);
>>>>>>> refs/remotes/origin/master
           this.button1.TabIndex = 2;
           this.button1.Text = "MENU";
           this.button1.UseVisualStyleBackColor = false;
           this.button1.Click += new System.EventHandler(this.button1_Click);
           // 
           // ControlTop
           // 
<<<<<<< HEAD
           this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
=======
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
>>>>>>> refs/remotes/origin/master
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.BackColor = System.Drawing.SystemColors.ControlDark;
           this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
           this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
           this.Controls.Add(this.button1);
           this.Controls.Add(this.label1);
           this.DoubleBuffered = true;
           this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
           this.Name = "ControlTop";
<<<<<<< HEAD
           this.Size = new System.Drawing.Size(691, 1044);
=======
           this.Size = new System.Drawing.Size(519, 679);
>>>>>>> refs/remotes/origin/master
           this.Load += new System.EventHandler(this.ControlTop_Load);
           this.ResumeLayout(false);
       }

       private System.Windows.Forms.Button button1;
       private System.Windows.Forms.Label label1;

       #endregion
    }
}