namespace Oefening2_GemiddeldeMDI
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
            this.lbGetallen = new System.Windows.Forms.ListBox();
            this.btNieuwGetal = new System.Windows.Forms.Button();
            this.tbGemiddelde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbGetallen
            // 
            this.lbGetallen.FormattingEnabled = true;
            this.lbGetallen.ItemHeight = 32;
            this.lbGetallen.Location = new System.Drawing.Point(142, 136);
            this.lbGetallen.Name = "lbGetallen";
            this.lbGetallen.Size = new System.Drawing.Size(240, 228);
            this.lbGetallen.TabIndex = 0;
            // 
            // btNieuwGetal
            // 
            this.btNieuwGetal.Location = new System.Drawing.Point(182, 385);
            this.btNieuwGetal.Name = "btNieuwGetal";
            this.btNieuwGetal.Size = new System.Drawing.Size(150, 46);
            this.btNieuwGetal.TabIndex = 1;
            this.btNieuwGetal.Text = "Nieuw getal";
            this.btNieuwGetal.UseVisualStyleBackColor = true;
            this.btNieuwGetal.Click += new System.EventHandler(this.btNieuwGetal_Click);
            // 
            // tbGemiddelde
            // 
            this.tbGemiddelde.Location = new System.Drawing.Point(422, 240);
            this.tbGemiddelde.Name = "tbGemiddelde";
            this.tbGemiddelde.Size = new System.Drawing.Size(200, 39);
            this.tbGemiddelde.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(142, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Getallen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(422, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gemiddelde";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGemiddelde);
            this.Controls.Add(this.btNieuwGetal);
            this.Controls.Add(this.lbGetallen);
            this.Name = "Form2";
            this.Text = "Child Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGetallen;
        private System.Windows.Forms.Button btNieuwGetal;
        private System.Windows.Forms.TextBox tbGemiddelde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}