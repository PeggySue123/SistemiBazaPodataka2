
namespace Cirkus.Forme
{
    partial class DirektorDodajForm
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
            this.txbIme = new System.Windows.Forms.TextBox();
            this.txbSSlovo = new System.Windows.Forms.TextBox();
            this.txbPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DodajDirektora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbIme
            // 
            this.txbIme.Location = new System.Drawing.Point(234, 84);
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(100, 22);
            this.txbIme.TabIndex = 0;
            // 
            // txbSSlovo
            // 
            this.txbSSlovo.Location = new System.Drawing.Point(234, 128);
            this.txbSSlovo.Name = "txbSSlovo";
            this.txbSSlovo.Size = new System.Drawing.Size(100, 22);
            this.txbSSlovo.TabIndex = 1;
            // 
            // txbPrezime
            // 
            this.txbPrezime.Location = new System.Drawing.Point(234, 172);
            this.txbPrezime.Name = "txbPrezime";
            this.txbPrezime.Size = new System.Drawing.Size(100, 22);
            this.txbPrezime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(78, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(78, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(78, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Srednje slovo:";
            // 
            // DodajDirektora
            // 
            this.DodajDirektora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DodajDirektora.ForeColor = System.Drawing.Color.Blue;
            this.DodajDirektora.Location = new System.Drawing.Point(127, 263);
            this.DodajDirektora.Name = "DodajDirektora";
            this.DodajDirektora.Size = new System.Drawing.Size(124, 50);
            this.DodajDirektora.TabIndex = 6;
            this.DodajDirektora.Text = "Dodaj";
            this.DodajDirektora.UseVisualStyleBackColor = false;
            this.DodajDirektora.Click += new System.EventHandler(this.DodajDirektora_Click);
            // 
            // DirektorDodajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(447, 409);
            this.Controls.Add(this.DodajDirektora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPrezime);
            this.Controls.Add(this.txbSSlovo);
            this.Controls.Add(this.txbIme);
            this.Name = "DirektorDodajForm";
            this.Text = "Dodavanje direktora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.TextBox txbSSlovo;
        private System.Windows.Forms.TextBox txbPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DodajDirektora;
    }
}