﻿
namespace Cirkus.Forme
{
    partial class KlovnoviDodajForma
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
            this.clbPol = new System.Windows.Forms.CheckedListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dtDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.dtPocetakRada = new System.Windows.Forms.DateTimePicker();
            this.txtImeRoditelja = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtMestoRodjenja = new System.Windows.Forms.TextBox();
            this.txtMaticniBroj = new System.Windows.Forms.TextBox();
            this.txtNadimak = new System.Windows.Forms.TextBox();
            this.txtLicnoIme = new System.Windows.Forms.TextBox();
            this.lblPol = new System.Windows.Forms.Label();
            this.lblPocetakRada = new System.Windows.Forms.Label();
            this.lblMaticniBroj = new System.Windows.Forms.Label();
            this.lblMestoRodjenja = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblNadimak = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblImeRoditelja = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPredmet = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.txtPredmet = new System.Windows.Forms.TextBox();
            this.cblTip = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIdDirektora = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clbPol
            // 
            this.clbPol.BackColor = System.Drawing.Color.MistyRose;
            this.clbPol.FormattingEnabled = true;
            this.clbPol.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.clbPol.Location = new System.Drawing.Point(114, 206);
            this.clbPol.Name = "clbPol";
            this.clbPol.Size = new System.Drawing.Size(66, 55);
            this.clbPol.TabIndex = 39;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDodaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDodaj.Location = new System.Drawing.Point(266, 364);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(190, 39);
            this.btnDodaj.TabIndex = 38;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.KlovnDodaj_Click);
            // 
            // dtDatumRodjenja
            // 
            this.dtDatumRodjenja.Location = new System.Drawing.Point(398, 15);
            this.dtDatumRodjenja.Name = "dtDatumRodjenja";
            this.dtDatumRodjenja.Size = new System.Drawing.Size(200, 22);
            this.dtDatumRodjenja.TabIndex = 37;
            // 
            // dtPocetakRada
            // 
            this.dtPocetakRada.Location = new System.Drawing.Point(398, 154);
            this.dtPocetakRada.Name = "dtPocetakRada";
            this.dtPocetakRada.Size = new System.Drawing.Size(200, 22);
            this.dtPocetakRada.TabIndex = 36;
            // 
            // txtImeRoditelja
            // 
            this.txtImeRoditelja.Location = new System.Drawing.Point(114, 63);
            this.txtImeRoditelja.Name = "txtImeRoditelja";
            this.txtImeRoditelja.Size = new System.Drawing.Size(100, 22);
            this.txtImeRoditelja.TabIndex = 35;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(114, 116);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 22);
            this.txtPrezime.TabIndex = 34;
            // 
            // txtMestoRodjenja
            // 
            this.txtMestoRodjenja.Location = new System.Drawing.Point(398, 57);
            this.txtMestoRodjenja.Name = "txtMestoRodjenja";
            this.txtMestoRodjenja.Size = new System.Drawing.Size(100, 22);
            this.txtMestoRodjenja.TabIndex = 33;
            // 
            // txtMaticniBroj
            // 
            this.txtMaticniBroj.Location = new System.Drawing.Point(398, 110);
            this.txtMaticniBroj.Name = "txtMaticniBroj";
            this.txtMaticniBroj.Size = new System.Drawing.Size(100, 22);
            this.txtMaticniBroj.TabIndex = 32;
            // 
            // txtNadimak
            // 
            this.txtNadimak.Location = new System.Drawing.Point(114, 162);
            this.txtNadimak.Name = "txtNadimak";
            this.txtNadimak.Size = new System.Drawing.Size(100, 22);
            this.txtNadimak.TabIndex = 31;
            // 
            // txtLicnoIme
            // 
            this.txtLicnoIme.Location = new System.Drawing.Point(114, 15);
            this.txtLicnoIme.Name = "txtLicnoIme";
            this.txtLicnoIme.Size = new System.Drawing.Size(100, 22);
            this.txtLicnoIme.TabIndex = 30;
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPol.Location = new System.Drawing.Point(11, 215);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(33, 20);
            this.lblPol.TabIndex = 29;
            this.lblPol.Text = "Pol";
            // 
            // lblPocetakRada
            // 
            this.lblPocetakRada.AutoSize = true;
            this.lblPocetakRada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPocetakRada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPocetakRada.Location = new System.Drawing.Point(238, 159);
            this.lblPocetakRada.Name = "lblPocetakRada";
            this.lblPocetakRada.Size = new System.Drawing.Size(107, 20);
            this.lblPocetakRada.TabIndex = 28;
            this.lblPocetakRada.Text = "Početak rada";
            // 
            // lblMaticniBroj
            // 
            this.lblMaticniBroj.AutoSize = true;
            this.lblMaticniBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaticniBroj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMaticniBroj.Location = new System.Drawing.Point(238, 113);
            this.lblMaticniBroj.Name = "lblMaticniBroj";
            this.lblMaticniBroj.Size = new System.Drawing.Size(96, 20);
            this.lblMaticniBroj.TabIndex = 27;
            this.lblMaticniBroj.Text = "Matični broj";
            // 
            // lblMestoRodjenja
            // 
            this.lblMestoRodjenja.AutoSize = true;
            this.lblMestoRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMestoRodjenja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMestoRodjenja.Location = new System.Drawing.Point(238, 60);
            this.lblMestoRodjenja.Name = "lblMestoRodjenja";
            this.lblMestoRodjenja.Size = new System.Drawing.Size(115, 20);
            this.lblMestoRodjenja.TabIndex = 26;
            this.lblMestoRodjenja.Text = "Mesto rođenja";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumRodjenja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDatumRodjenja.Location = new System.Drawing.Point(238, 15);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(119, 20);
            this.lblDatumRodjenja.TabIndex = 25;
            this.lblDatumRodjenja.Text = "Datum rođenja";
            // 
            // lblNadimak
            // 
            this.lblNadimak.AutoSize = true;
            this.lblNadimak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNadimak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNadimak.Location = new System.Drawing.Point(11, 162);
            this.lblNadimak.Name = "lblNadimak";
            this.lblNadimak.Size = new System.Drawing.Size(74, 20);
            this.lblNadimak.TabIndex = 24;
            this.lblNadimak.Text = "Nadimak";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPrezime.Location = new System.Drawing.Point(11, 113);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(71, 20);
            this.lblPrezime.TabIndex = 23;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblImeRoditelja
            // 
            this.lblImeRoditelja.AutoSize = true;
            this.lblImeRoditelja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeRoditelja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblImeRoditelja.Location = new System.Drawing.Point(11, 63);
            this.lblImeRoditelja.Name = "lblImeRoditelja";
            this.lblImeRoditelja.Size = new System.Drawing.Size(100, 20);
            this.lblImeRoditelja.TabIndex = 22;
            this.lblImeRoditelja.Text = "Ime roditelja";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblIme.Location = new System.Drawing.Point(11, 15);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(36, 20);
            this.lblIme.TabIndex = 21;
            this.lblIme.Text = "Ime";
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPredmet.Location = new System.Drawing.Point(238, 203);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(153, 20);
            this.lblPredmet.TabIndex = 40;
            this.lblPredmet.Text = "Predmet za zabavu";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(239, 242);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(32, 20);
            this.lblTip.TabIndex = 41;
            this.lblTip.Text = "Tip";
            // 
            // txtPredmet
            // 
            this.txtPredmet.Location = new System.Drawing.Point(398, 203);
            this.txtPredmet.Name = "txtPredmet";
            this.txtPredmet.Size = new System.Drawing.Size(100, 22);
            this.txtPredmet.TabIndex = 42;
            // 
            // cblTip
            // 
            this.cblTip.BackColor = System.Drawing.Color.MistyRose;
            this.cblTip.FormattingEnabled = true;
            this.cblTip.Items.AddRange(new object[] {
            "Tuzan",
            "Smesan"});
            this.cblTip.Location = new System.Drawing.Point(398, 242);
            this.cblTip.Name = "cblTip";
            this.cblTip.Size = new System.Drawing.Size(100, 55);
            this.cblTip.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(238, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "ID direktora:";
            // 
            // txbIdDirektora
            // 
            this.txbIdDirektora.Location = new System.Drawing.Point(398, 311);
            this.txbIdDirektora.Name = "txbIdDirektora";
            this.txbIdDirektora.Size = new System.Drawing.Size(100, 22);
            this.txbIdDirektora.TabIndex = 45;
            // 
            // KlovnoviDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(609, 415);
            this.Controls.Add(this.txbIdDirektora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cblTip);
            this.Controls.Add(this.txtPredmet);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblPredmet);
            this.Controls.Add(this.clbPol);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dtDatumRodjenja);
            this.Controls.Add(this.dtPocetakRada);
            this.Controls.Add(this.txtImeRoditelja);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtMestoRodjenja);
            this.Controls.Add(this.txtMaticniBroj);
            this.Controls.Add(this.txtNadimak);
            this.Controls.Add(this.txtLicnoIme);
            this.Controls.Add(this.lblPol);
            this.Controls.Add(this.lblPocetakRada);
            this.Controls.Add(this.lblMaticniBroj);
            this.Controls.Add(this.lblMestoRodjenja);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.lblNadimak);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblImeRoditelja);
            this.Controls.Add(this.lblIme);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "KlovnoviDodajForma";
            this.Text = "Dodavanje klovnova";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbPol;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DateTimePicker dtDatumRodjenja;
        private System.Windows.Forms.DateTimePicker dtPocetakRada;
        private System.Windows.Forms.TextBox txtImeRoditelja;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtMestoRodjenja;
        private System.Windows.Forms.TextBox txtMaticniBroj;
        private System.Windows.Forms.TextBox txtNadimak;
        private System.Windows.Forms.TextBox txtLicnoIme;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.Label lblPocetakRada;
        private System.Windows.Forms.Label lblMaticniBroj;
        private System.Windows.Forms.Label lblMestoRodjenja;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label lblNadimak;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblImeRoditelja;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPredmet;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox txtPredmet;
        private System.Windows.Forms.CheckedListBox cblTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIdDirektora;
    }
}