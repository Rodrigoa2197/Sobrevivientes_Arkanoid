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
           System.ComponentModel.ComponentResourceManager resources =
               new System.ComponentModel.ComponentResourceManager(typeof(ControlTop));
           this.label1 = new System.Windows.Forms.Label();
           this.SuspendLayout();
           // 
           // label1
           // 
           this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
           this.label1.BackColor = System.Drawing.Color.Transparent;
           this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular,
               System.Drawing.GraphicsUnit.Point, ((byte) (0)));
           this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
           this.label1.Location = new System.Drawing.Point(135, 8);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(346, 114);
           this.label1.TabIndex = 1;
           this.label1.Text = "PUNTAJE TOP";
           this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           // 
           // ControlTop
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.BackColor = System.Drawing.SystemColors.ControlDark;
           this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
           this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
           this.Controls.Add(this.label1);
           this.DoubleBuffered = true;
           this.Name = "ControlTop";
           this.Size = new System.Drawing.Size(605, 783);
           this.Load += new System.EventHandler(this.ControlTop_Load);
           this.ResumeLayout(false);
       }

       private System.Windows.Forms.Label label1;

       #endregion
    }
}