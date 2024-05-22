
namespace Cirkus.Forme
{
    partial class VestinaIzmeniForma
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblBrojGodina = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNaziv.Location = new System.Drawing.Point(45, 57);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(51, 20);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblBrojGodina
            // 
            this.lblBrojGodina.AutoSize = true;
            this.lblBrojGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojGodina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBrojGodina.Location = new System.Drawing.Point(45, 107);
            this.lblBrojGodina.Name = "lblBrojGodina";
            this.lblBrojGodina.Size = new System.Drawing.Size(94, 20);
            this.lblBrojGodina.TabIndex = 1;
            this.lblBrojGodina.Text = "Broj godina";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(217, 57);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 22);
            this.txtNaziv.TabIndex = 2;
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(217, 107);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(100, 22);
            this.txtBroj.TabIndex = 3;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSacuvaj.Location = new System.Drawing.Point(134, 161);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(117, 46);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.Sacuvaj_Click);
            // 
            // VestinaIzmeniForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(414, 235);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblBrojGodina);
            this.Controls.Add(this.lblNaziv);
            this.Name = "VestinaIzmeniForma";
            this.Text = "Izmeni veštine";
            this.Load += new System.EventHandler(this.Vestina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblBrojGodina;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}