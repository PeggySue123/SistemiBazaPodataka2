
namespace Cirkus.Forme
{
    partial class GradDodajForm
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
            this.Dodaj = new System.Windows.Forms.Button();
            this.txbGrad = new System.Windows.Forms.TextBox();
            this.txbDrzava = new System.Windows.Forms.TextBox();
            this.txbOpis = new System.Windows.Forms.TextBox();
            this.txbDatOd = new System.Windows.Forms.DateTimePicker();
            this.txbDatDo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Dodaj
            // 
            this.Dodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Dodaj.ForeColor = System.Drawing.Color.Blue;
            this.Dodaj.Location = new System.Drawing.Point(192, 358);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(103, 39);
            this.Dodaj.TabIndex = 0;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = false;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // txbGrad
            // 
            this.txbGrad.Location = new System.Drawing.Point(292, 66);
            this.txbGrad.Name = "txbGrad";
            this.txbGrad.Size = new System.Drawing.Size(100, 22);
            this.txbGrad.TabIndex = 1;
            // 
            // txbDrzava
            // 
            this.txbDrzava.Location = new System.Drawing.Point(292, 119);
            this.txbDrzava.Name = "txbDrzava";
            this.txbDrzava.Size = new System.Drawing.Size(100, 22);
            this.txbDrzava.TabIndex = 2;
            // 
            // txbOpis
            // 
            this.txbOpis.Location = new System.Drawing.Point(292, 291);
            this.txbOpis.Name = "txbOpis";
            this.txbOpis.Size = new System.Drawing.Size(100, 22);
            this.txbOpis.TabIndex = 5;
            // 
            // txbDatOd
            // 
            this.txbDatOd.Location = new System.Drawing.Point(292, 171);
            this.txbDatOd.Name = "txbDatOd";
            this.txbDatOd.Size = new System.Drawing.Size(200, 22);
            this.txbDatOd.TabIndex = 6;
            // 
            // txbDatDo
            // 
            this.txbDatDo.Location = new System.Drawing.Point(292, 230);
            this.txbDatDo.Name = "txbDatDo";
            this.txbDatDo.Size = new System.Drawing.Size(200, 22);
            this.txbDatDo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(109, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Opis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(109, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(109, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(109, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Naziv države:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(109, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Naziv grada:";
            // 
            // GradDodajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(592, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbDatDo);
            this.Controls.Add(this.txbDatOd);
            this.Controls.Add(this.txbOpis);
            this.Controls.Add(this.txbDrzava);
            this.Controls.Add(this.txbGrad);
            this.Controls.Add(this.Dodaj);
            this.Name = "GradDodajForm";
            this.Text = "Dodavanje grada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.TextBox txbGrad;
        private System.Windows.Forms.TextBox txbDrzava;
        private System.Windows.Forms.TextBox txbOpis;
        private System.Windows.Forms.DateTimePicker txbDatOd;
        private System.Windows.Forms.DateTimePicker txbDatDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}