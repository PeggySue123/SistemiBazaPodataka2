
namespace Cirkus.Forme
{
    partial class DirektorIzmeniForm
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
            this.IzmeniDirektora = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPrezime = new System.Windows.Forms.TextBox();
            this.txbSSlovo = new System.Windows.Forms.TextBox();
            this.txbIme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IzmeniDirektora
            // 
            this.IzmeniDirektora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.IzmeniDirektora.ForeColor = System.Drawing.Color.Blue;
            this.IzmeniDirektora.Location = new System.Drawing.Point(113, 251);
            this.IzmeniDirektora.Name = "IzmeniDirektora";
            this.IzmeniDirektora.Size = new System.Drawing.Size(124, 50);
            this.IzmeniDirektora.TabIndex = 13;
            this.IzmeniDirektora.Text = "Ažuriraj";
            this.IzmeniDirektora.UseVisualStyleBackColor = false;
            this.IzmeniDirektora.Click += new System.EventHandler(this.IzmeniDirektora_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(64, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Srednje slovo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(64, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(64, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ime:";
            // 
            // txbPrezime
            // 
            this.txbPrezime.Location = new System.Drawing.Point(220, 160);
            this.txbPrezime.Name = "txbPrezime";
            this.txbPrezime.Size = new System.Drawing.Size(100, 22);
            this.txbPrezime.TabIndex = 9;
            // 
            // txbSSlovo
            // 
            this.txbSSlovo.Location = new System.Drawing.Point(220, 116);
            this.txbSSlovo.Name = "txbSSlovo";
            this.txbSSlovo.Size = new System.Drawing.Size(100, 22);
            this.txbSSlovo.TabIndex = 8;
            // 
            // txbIme
            // 
            this.txbIme.Location = new System.Drawing.Point(220, 72);
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(100, 22);
            this.txbIme.TabIndex = 7;
            // 
            // DirektorIzmeniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(401, 377);
            this.Controls.Add(this.IzmeniDirektora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPrezime);
            this.Controls.Add(this.txbSSlovo);
            this.Controls.Add(this.txbIme);
            this.Name = "DirektorIzmeniForm";
            this.Text = "Izmena direktora";
            this.Load += new System.EventHandler(this.DirektorIzmeniForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IzmeniDirektora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPrezime;
        private System.Windows.Forms.TextBox txbSSlovo;
        private System.Windows.Forms.TextBox txbIme;
    }
}