
namespace Cirkus.Forme
{
    partial class VestinaDodajForma
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblBrojGodina = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDodaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDodaj.Location = new System.Drawing.Point(145, 181);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(114, 48);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(226, 112);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(100, 22);
            this.txtBroj.TabIndex = 8;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(226, 62);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 22);
            this.txtNaziv.TabIndex = 7;
            // 
            // lblBrojGodina
            // 
            this.lblBrojGodina.AutoSize = true;
            this.lblBrojGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojGodina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBrojGodina.Location = new System.Drawing.Point(48, 112);
            this.lblBrojGodina.Name = "lblBrojGodina";
            this.lblBrojGodina.Size = new System.Drawing.Size(94, 20);
            this.lblBrojGodina.TabIndex = 6;
            this.lblBrojGodina.Text = "Broj godina";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNaziv.Location = new System.Drawing.Point(48, 62);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(51, 20);
            this.lblNaziv.TabIndex = 5;
            this.lblNaziv.Text = "Naziv";
            // 
            // VestinaDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(396, 254);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblBrojGodina);
            this.Controls.Add(this.lblNaziv);
            this.Name = "VestinaDodajForma";
            this.Text = "Dodaj veštine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblBrojGodina;
        private System.Windows.Forms.Label lblNaziv;
    }
}