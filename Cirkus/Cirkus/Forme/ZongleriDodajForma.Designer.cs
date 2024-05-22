
namespace Cirkus.Forme
{
    partial class ZongleriDodajForma
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
            this.txtPredmet = new System.Windows.Forms.TextBox();
            this.lblBroj = new System.Windows.Forms.Label();
            this.lblPredmet = new System.Windows.Forms.Label();
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
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIdDirektora = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPredmet
            // 
            this.txtPredmet.Location = new System.Drawing.Point(440, 208);
            this.txtPredmet.Name = "txtPredmet";
            this.txtPredmet.Size = new System.Drawing.Size(100, 22);
            this.txtPredmet.TabIndex = 65;
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBroj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBroj.Location = new System.Drawing.Point(233, 247);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(201, 20);
            this.lblBroj.TabIndex = 64;
            this.lblBroj.Text = "Broj predmeta za zabavu:";
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPredmet.Location = new System.Drawing.Point(233, 208);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(131, 20);
            this.lblPredmet.TabIndex = 63;
            this.lblPredmet.Text = "Naziv predmeta:";
            // 
            // clbPol
            // 
            this.clbPol.BackColor = System.Drawing.Color.MistyRose;
            this.clbPol.FormattingEnabled = true;
            this.clbPol.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.clbPol.Location = new System.Drawing.Point(121, 214);
            this.clbPol.Name = "clbPol";
            this.clbPol.Size = new System.Drawing.Size(66, 55);
            this.clbPol.TabIndex = 62;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDodaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDodaj.Location = new System.Drawing.Point(350, 345);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(190, 39);
            this.btnDodaj.TabIndex = 61;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.ZonglerDodaj_Click);
            // 
            // dtDatumRodjenja
            // 
            this.dtDatumRodjenja.Location = new System.Drawing.Point(440, 20);
            this.dtDatumRodjenja.Name = "dtDatumRodjenja";
            this.dtDatumRodjenja.Size = new System.Drawing.Size(200, 22);
            this.dtDatumRodjenja.TabIndex = 60;
            // 
            // dtPocetakRada
            // 
            this.dtPocetakRada.Location = new System.Drawing.Point(440, 159);
            this.dtPocetakRada.Name = "dtPocetakRada";
            this.dtPocetakRada.Size = new System.Drawing.Size(200, 22);
            this.dtPocetakRada.TabIndex = 59;
            // 
            // txtImeRoditelja
            // 
            this.txtImeRoditelja.Location = new System.Drawing.Point(121, 71);
            this.txtImeRoditelja.Name = "txtImeRoditelja";
            this.txtImeRoditelja.Size = new System.Drawing.Size(100, 22);
            this.txtImeRoditelja.TabIndex = 58;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(121, 124);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 22);
            this.txtPrezime.TabIndex = 57;
            // 
            // txtMestoRodjenja
            // 
            this.txtMestoRodjenja.Location = new System.Drawing.Point(440, 62);
            this.txtMestoRodjenja.Name = "txtMestoRodjenja";
            this.txtMestoRodjenja.Size = new System.Drawing.Size(100, 22);
            this.txtMestoRodjenja.TabIndex = 56;
            // 
            // txtMaticniBroj
            // 
            this.txtMaticniBroj.Location = new System.Drawing.Point(440, 115);
            this.txtMaticniBroj.Name = "txtMaticniBroj";
            this.txtMaticniBroj.Size = new System.Drawing.Size(100, 22);
            this.txtMaticniBroj.TabIndex = 55;
            // 
            // txtNadimak
            // 
            this.txtNadimak.Location = new System.Drawing.Point(121, 170);
            this.txtNadimak.Name = "txtNadimak";
            this.txtNadimak.Size = new System.Drawing.Size(100, 22);
            this.txtNadimak.TabIndex = 54;
            // 
            // txtLicnoIme
            // 
            this.txtLicnoIme.Location = new System.Drawing.Point(121, 23);
            this.txtLicnoIme.Name = "txtLicnoIme";
            this.txtLicnoIme.Size = new System.Drawing.Size(100, 22);
            this.txtLicnoIme.TabIndex = 53;
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPol.Location = new System.Drawing.Point(12, 220);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(38, 20);
            this.lblPol.TabIndex = 52;
            this.lblPol.Text = "Pol:";
            // 
            // lblPocetakRada
            // 
            this.lblPocetakRada.AutoSize = true;
            this.lblPocetakRada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPocetakRada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPocetakRada.Location = new System.Drawing.Point(233, 164);
            this.lblPocetakRada.Name = "lblPocetakRada";
            this.lblPocetakRada.Size = new System.Drawing.Size(112, 20);
            this.lblPocetakRada.TabIndex = 51;
            this.lblPocetakRada.Text = "Početak rada:";
            // 
            // lblMaticniBroj
            // 
            this.lblMaticniBroj.AutoSize = true;
            this.lblMaticniBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaticniBroj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMaticniBroj.Location = new System.Drawing.Point(233, 118);
            this.lblMaticniBroj.Name = "lblMaticniBroj";
            this.lblMaticniBroj.Size = new System.Drawing.Size(101, 20);
            this.lblMaticniBroj.TabIndex = 50;
            this.lblMaticniBroj.Text = "Matični broj:";
            // 
            // lblMestoRodjenja
            // 
            this.lblMestoRodjenja.AutoSize = true;
            this.lblMestoRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMestoRodjenja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMestoRodjenja.Location = new System.Drawing.Point(233, 65);
            this.lblMestoRodjenja.Name = "lblMestoRodjenja";
            this.lblMestoRodjenja.Size = new System.Drawing.Size(120, 20);
            this.lblMestoRodjenja.TabIndex = 49;
            this.lblMestoRodjenja.Text = "Mesto rođenja:";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumRodjenja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDatumRodjenja.Location = new System.Drawing.Point(233, 20);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(124, 20);
            this.lblDatumRodjenja.TabIndex = 48;
            this.lblDatumRodjenja.Text = "Datum rođenja:";
            // 
            // lblNadimak
            // 
            this.lblNadimak.AutoSize = true;
            this.lblNadimak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNadimak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNadimak.Location = new System.Drawing.Point(12, 167);
            this.lblNadimak.Name = "lblNadimak";
            this.lblNadimak.Size = new System.Drawing.Size(79, 20);
            this.lblNadimak.TabIndex = 47;
            this.lblNadimak.Text = "Nadimak:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPrezime.Location = new System.Drawing.Point(12, 118);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(76, 20);
            this.lblPrezime.TabIndex = 46;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblImeRoditelja
            // 
            this.lblImeRoditelja.AutoSize = true;
            this.lblImeRoditelja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeRoditelja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblImeRoditelja.Location = new System.Drawing.Point(12, 68);
            this.lblImeRoditelja.Name = "lblImeRoditelja";
            this.lblImeRoditelja.Size = new System.Drawing.Size(105, 20);
            this.lblImeRoditelja.TabIndex = 45;
            this.lblImeRoditelja.Text = "Ime roditelja:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblIme.Location = new System.Drawing.Point(12, 20);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(41, 20);
            this.lblIme.TabIndex = 44;
            this.lblIme.Text = "Ime:";
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(440, 247);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(100, 22);
            this.txtBroj.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(236, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Id direktora:";
            // 
            // txbIdDirektora
            // 
            this.txbIdDirektora.Location = new System.Drawing.Point(440, 281);
            this.txbIdDirektora.Name = "txbIdDirektora";
            this.txbIdDirektora.Size = new System.Drawing.Size(100, 22);
            this.txbIdDirektora.TabIndex = 68;
            // 
            // ZongleriDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(653, 411);
            this.Controls.Add(this.txbIdDirektora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.txtPredmet);
            this.Controls.Add(this.lblBroj);
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
            this.Name = "ZongleriDodajForma";
            this.Text = "Dodaj žonglera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPredmet;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.Label lblPredmet;
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
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIdDirektora;
    }
}