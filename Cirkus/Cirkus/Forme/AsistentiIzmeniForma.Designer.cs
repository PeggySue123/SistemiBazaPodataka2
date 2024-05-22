
namespace Cirkus.Forme
{
    partial class AsistentiIzmeniForma
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
            this.btnIzmeni = new System.Windows.Forms.Button();
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
            this.lblGlavni = new System.Windows.Forms.Label();
            this.txtGlavni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clbPol
            // 
            this.clbPol.BackColor = System.Drawing.Color.MistyRose;
            this.clbPol.FormattingEnabled = true;
            this.clbPol.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.clbPol.Location = new System.Drawing.Point(102, 197);
            this.clbPol.Name = "clbPol";
            this.clbPol.Size = new System.Drawing.Size(47, 38);
            this.clbPol.TabIndex = 58;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnIzmeni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnIzmeni.Location = new System.Drawing.Point(174, 262);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(190, 39);
            this.btnIzmeni.TabIndex = 57;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.Izmeni_Click);
            // 
            // dtDatumRodjenja
            // 
            this.dtDatumRodjenja.Location = new System.Drawing.Point(373, 9);
            this.dtDatumRodjenja.Name = "dtDatumRodjenja";
            this.dtDatumRodjenja.Size = new System.Drawing.Size(200, 22);
            this.dtDatumRodjenja.TabIndex = 56;
            // 
            // dtPocetakRada
            // 
            this.dtPocetakRada.Location = new System.Drawing.Point(373, 148);
            this.dtPocetakRada.Name = "dtPocetakRada";
            this.dtPocetakRada.Size = new System.Drawing.Size(200, 22);
            this.dtPocetakRada.TabIndex = 55;
            // 
            // txtImeRoditelja
            // 
            this.txtImeRoditelja.Location = new System.Drawing.Point(102, 54);
            this.txtImeRoditelja.Name = "txtImeRoditelja";
            this.txtImeRoditelja.Size = new System.Drawing.Size(100, 22);
            this.txtImeRoditelja.TabIndex = 54;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(102, 107);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 22);
            this.txtPrezime.TabIndex = 53;
            // 
            // txtMestoRodjenja
            // 
            this.txtMestoRodjenja.Location = new System.Drawing.Point(373, 51);
            this.txtMestoRodjenja.Name = "txtMestoRodjenja";
            this.txtMestoRodjenja.Size = new System.Drawing.Size(100, 22);
            this.txtMestoRodjenja.TabIndex = 52;
            // 
            // txtMaticniBroj
            // 
            this.txtMaticniBroj.Location = new System.Drawing.Point(373, 104);
            this.txtMaticniBroj.Name = "txtMaticniBroj";
            this.txtMaticniBroj.Size = new System.Drawing.Size(100, 22);
            this.txtMaticniBroj.TabIndex = 51;
            // 
            // txtNadimak
            // 
            this.txtNadimak.Location = new System.Drawing.Point(102, 153);
            this.txtNadimak.Name = "txtNadimak";
            this.txtNadimak.Size = new System.Drawing.Size(100, 22);
            this.txtNadimak.TabIndex = 50;
            // 
            // txtLicnoIme
            // 
            this.txtLicnoIme.Location = new System.Drawing.Point(102, 6);
            this.txtLicnoIme.Name = "txtLicnoIme";
            this.txtLicnoIme.Size = new System.Drawing.Size(100, 22);
            this.txtLicnoIme.TabIndex = 49;
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Location = new System.Drawing.Point(12, 209);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(28, 17);
            this.lblPol.TabIndex = 48;
            this.lblPol.Text = "Pol";
            // 
            // lblPocetakRada
            // 
            this.lblPocetakRada.AutoSize = true;
            this.lblPocetakRada.Location = new System.Drawing.Point(263, 153);
            this.lblPocetakRada.Name = "lblPocetakRada";
            this.lblPocetakRada.Size = new System.Drawing.Size(92, 17);
            this.lblPocetakRada.TabIndex = 47;
            this.lblPocetakRada.Text = "Početak rada";
            // 
            // lblMaticniBroj
            // 
            this.lblMaticniBroj.AutoSize = true;
            this.lblMaticniBroj.Location = new System.Drawing.Point(263, 107);
            this.lblMaticniBroj.Name = "lblMaticniBroj";
            this.lblMaticniBroj.Size = new System.Drawing.Size(80, 17);
            this.lblMaticniBroj.TabIndex = 46;
            this.lblMaticniBroj.Text = "Matični broj";
            // 
            // lblMestoRodjenja
            // 
            this.lblMestoRodjenja.AutoSize = true;
            this.lblMestoRodjenja.Location = new System.Drawing.Point(263, 54);
            this.lblMestoRodjenja.Name = "lblMestoRodjenja";
            this.lblMestoRodjenja.Size = new System.Drawing.Size(98, 17);
            this.lblMestoRodjenja.TabIndex = 45;
            this.lblMestoRodjenja.Text = "Mesto rođenja";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(263, 9);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(101, 17);
            this.lblDatumRodjenja.TabIndex = 44;
            this.lblDatumRodjenja.Text = "Datum rođenja";
            // 
            // lblNadimak
            // 
            this.lblNadimak.AutoSize = true;
            this.lblNadimak.Location = new System.Drawing.Point(12, 156);
            this.lblNadimak.Name = "lblNadimak";
            this.lblNadimak.Size = new System.Drawing.Size(63, 17);
            this.lblNadimak.TabIndex = 43;
            this.lblNadimak.Text = "Nadimak";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(12, 107);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 17);
            this.lblPrezime.TabIndex = 42;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblImeRoditelja
            // 
            this.lblImeRoditelja.AutoSize = true;
            this.lblImeRoditelja.Location = new System.Drawing.Point(12, 57);
            this.lblImeRoditelja.Name = "lblImeRoditelja";
            this.lblImeRoditelja.Size = new System.Drawing.Size(84, 17);
            this.lblImeRoditelja.TabIndex = 41;
            this.lblImeRoditelja.Text = "Ime roditelja";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(12, 9);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(30, 17);
            this.lblIme.TabIndex = 40;
            this.lblIme.Text = "Ime";
            // 
            // lblGlavni
            // 
            this.lblGlavni.AutoSize = true;
            this.lblGlavni.Location = new System.Drawing.Point(266, 217);
            this.lblGlavni.Name = "lblGlavni";
            this.lblGlavni.Size = new System.Drawing.Size(91, 17);
            this.lblGlavni.TabIndex = 59;
            this.lblGlavni.Text = "Glavni artista";
            // 
            // txtGlavni
            // 
            this.txtGlavni.Location = new System.Drawing.Point(373, 217);
            this.txtGlavni.Name = "txtGlavni";
            this.txtGlavni.Size = new System.Drawing.Size(100, 22);
            this.txtGlavni.TabIndex = 60;
            // 
            // AsistentiIzmeniForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(593, 313);
            this.Controls.Add(this.txtGlavni);
            this.Controls.Add(this.lblGlavni);
            this.Controls.Add(this.clbPol);
            this.Controls.Add(this.btnIzmeni);
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
            this.Name = "AsistentiIzmeniForma";
            this.Text = "Izmeni asistenta";
            this.Load += new System.EventHandler(this.AsistentIzmeni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbPol;
        private System.Windows.Forms.Button btnIzmeni;
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
        private System.Windows.Forms.Label lblGlavni;
        private System.Windows.Forms.TextBox txtGlavni;
    }
}