
namespace Cirkus.Forme
{
    partial class DirektorForma
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
            this.txbVrsta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDirektor = new System.Windows.Forms.TextBox();
            this.txbNadimak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbVrsta
            // 
            this.txbVrsta.Location = new System.Drawing.Point(278, 102);
            this.txbVrsta.Name = "txbVrsta";
            this.txbVrsta.ReadOnly = true;
            this.txbVrsta.Size = new System.Drawing.Size(266, 22);
            this.txbVrsta.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(79, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vrsta životinje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(79, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Direktor životinje:";
            // 
            // txbDirektor
            // 
            this.txbDirektor.Location = new System.Drawing.Point(278, 140);
            this.txbDirektor.Multiline = true;
            this.txbDirektor.Name = "txbDirektor";
            this.txbDirektor.ReadOnly = true;
            this.txbDirektor.Size = new System.Drawing.Size(266, 24);
            this.txbDirektor.TabIndex = 8;
            // 
            // txbNadimak
            // 
            this.txbNadimak.Location = new System.Drawing.Point(278, 63);
            this.txbNadimak.Name = "txbNadimak";
            this.txbNadimak.ReadOnly = true;
            this.txbNadimak.Size = new System.Drawing.Size(266, 22);
            this.txbNadimak.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(79, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nadimak životinje:";
            // 
            // DirektorForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(632, 215);
            this.Controls.Add(this.txbVrsta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbDirektor);
            this.Controls.Add(this.txbNadimak);
            this.Controls.Add(this.label1);
            this.Name = "DirektorForma";
            this.Text = "Direktor životinje";
            this.Load += new System.EventHandler(this.DirektorForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbVrsta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDirektor;
        private System.Windows.Forms.TextBox txbNadimak;
        private System.Windows.Forms.Label label1;
    }
}