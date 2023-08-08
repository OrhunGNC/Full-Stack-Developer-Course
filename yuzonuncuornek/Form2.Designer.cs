namespace yuzonuncuornek
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beşiktaşGaleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ataşehirGaleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şikayetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beşiktaşGaleriToolStripMenuItem,
            this.ataşehirGaleriToolStripMenuItem,
            this.şikayetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beşiktaşGaleriToolStripMenuItem
            // 
            this.beşiktaşGaleriToolStripMenuItem.Name = "beşiktaşGaleriToolStripMenuItem";
            this.beşiktaşGaleriToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.beşiktaşGaleriToolStripMenuItem.Text = "Beşiktaş Galeri";
            this.beşiktaşGaleriToolStripMenuItem.Click += new System.EventHandler(this.beşiktaşGaleriToolStripMenuItem_Click);
            // 
            // ataşehirGaleriToolStripMenuItem
            // 
            this.ataşehirGaleriToolStripMenuItem.Name = "ataşehirGaleriToolStripMenuItem";
            this.ataşehirGaleriToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ataşehirGaleriToolStripMenuItem.Text = "Ataşehir Galeri";
            this.ataşehirGaleriToolStripMenuItem.Click += new System.EventHandler(this.ataşehirGaleriToolStripMenuItem_Click);
            // 
            // şikayetToolStripMenuItem
            // 
            this.şikayetToolStripMenuItem.Name = "şikayetToolStripMenuItem";
            this.şikayetToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.şikayetToolStripMenuItem.Text = "Şikayet&Talep";
            this.şikayetToolStripMenuItem.Click += new System.EventHandler(this.şikayetToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beşiktaşGaleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ataşehirGaleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şikayetToolStripMenuItem;
    }
}