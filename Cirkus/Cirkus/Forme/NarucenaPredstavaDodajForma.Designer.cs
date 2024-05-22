
namespace Cirkus.Forme
{
    partial class NarucenaPredstavaDodajForma
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
            this.lblImeNarucioca = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblImeNarucioca
            // 
            this.lblImeNarucioca.AutoSize = true;
            this.lblImeNarucioca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeNarucioca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblImeNarucioca.Location = new System.Drawing.Point(29, 59);
            this.lblImeNarucioca.Name = "lblImeNarucioca";
            this.lblImeNarucioca.Size = new System.Drawing.Size(114, 20);
            this.lblImeNarucioca.TabIndex = 0;
            this.lblImeNarucioca.Text = "Ime naručioca";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAdresa.Location = new System.Drawing.Point(28, 90);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(140, 20);
            this.lblAdresa.TabIndex = 1;
            this.lblAdresa.Text = "Adresa naručioca";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(229, 58);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(161, 22);
            this.txtIme.TabIndex = 2;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(229, 90);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(161, 22);
            this.txtAdresa.TabIndex = 3;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSacuvaj.Location = new System.Drawing.Point(158, 170);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(122, 46);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.Sacuvaj_Predstavu_Click);
            // 
            // NarucenaPredstavaDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(454, 247);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblImeNarucioca);
            this.Name = "NarucenaPredstavaDodajForma";
            this.Text = "Dodaj narucenu predstavu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImeNarucioca;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}