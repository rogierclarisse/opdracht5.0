namespace Oefening3_Kleuren
{
    partial class Rechthoek
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voegRechthoekToeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verwijderRechthoekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voegRechthoekToeToolStripMenuItem,
            this.verwijderRechthoekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voegRechthoekToeToolStripMenuItem
            // 
            this.voegRechthoekToeToolStripMenuItem.Name = "voegRechthoekToeToolStripMenuItem";
            this.voegRechthoekToeToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.voegRechthoekToeToolStripMenuItem.Text = "Voeg rechthoek toe";
            this.voegRechthoekToeToolStripMenuItem.Click += new System.EventHandler(this.voegRechthoekToeToolStripMenuItem_Click);
            // 
            // verwijderRechthoekToolStripMenuItem
            // 
            this.verwijderRechthoekToolStripMenuItem.Name = "verwijderRechthoekToolStripMenuItem";
            this.verwijderRechthoekToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.verwijderRechthoekToolStripMenuItem.Text = "Verwijder rechthoek";
            // 
            // Rechthoek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 544);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Rechthoek";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voegRechthoekToeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verwijderRechthoekToolStripMenuItem;
    }
}

