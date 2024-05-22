
namespace Cirkus.Forme
{
    partial class KlovnoviIzmeniForma
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
            this.cblTip = new System.Windows.Forms.CheckedListBox();
            this.txtPredmet = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblPredmet = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // cblTip
            // 
            this.cblTip.BackColor = System.Drawing.Color.MistyRose;
            this.cblTip.FormattingEnabled = true;
            this.cblTip.Items.AddRange(new object[] {
            "Tuzan",
            "Smesan"});
            this.cblTip.Location = new System.Drawing.Point(432, 250);
            this.cblTip.Name = "cblTip";
            this.cblTip.Size = new System.Drawing.Size(100, 38);
            this.cblTip.TabIndex = 66;
            // 
            // txtPredmet
            // 
            this.txtPredmet.Location = new System.Drawing.Point(432, 211);
            this.txtPredmet.Name = "txtPredmet";
            this.txtPredmet.Size = new System.Drawing.Size(100, 22);
            this.txtPredmet.TabIndex = 65;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTip.Location = new System.Drawing.Point(264, 248);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(32, 20);
            this.lblTip.TabIndex = 64;
            this.lblTip.Text = "Tip";
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPredmet.Location = new System.Drawing.Point(264, 209);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(153, 20);
            this.lblPredmet.TabIndex = 63;
            this.lblPredmet.Text = "Predmet za zabavu";
            // 
            // clbPol
            // 
            this.clbPol.BackColor = System.Drawing.Color.MistyRose;
            this.clbPol.FormattingEnabled = true;
            this.clbPol.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.clbPol.Location = new System.Drawing.Point(120, 212);
            this.clbPol.Name = "clbPol";
            this.clbPol.Size = new System.Drawing.Size(66, 55);
            this.clbPol.TabIndex = 62;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnIzmeni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnIzmeni.Location = new System.Drawing.Point(212, 324);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(190, 39);
            this.btnIzmeni.TabIndex = 61;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.Izmeni_Click);
            // 
            // dtDatumRodjenja
            // 
            this.dtDatumRodjenja.Location = new System.Drawing.Point(432, 23);
            this.dtDatumRodjenja.Name = "dtDatumRodjenja";
            this.dtDatumRodjenja.Size = new System.Drawing.Size(200, 22);
            this.dtDatumRodjenja.TabIndex = 60;
            // 
            // dtPocetakRada
            // 
            this.dtPocetakRada.Location = new System.Drawing.Point(432, 162);
            this.dtPocetakRada.Name = "dtPocetakRada";
            this.dtPocetakRada.Size = new System.Drawing.Size(200, 22);
            this.dtPocetakRada.TabIndex = 59;
            // 
            // txtImeRoditelja
            // 
            this.txtImeRoditelja.Location = new System.Drawing.Point(120, 69);
            this.txtImeRoditelja.Name = "txtImeRoditelja";
            this.txtImeRoditelja.Size = new System.Drawing.Size(100, 22);
            this.txtImeRoditelja.TabIndex = 58;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(120, 122);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 22);
            this.txtPrezime.TabIndex = 57;
            // 
            // txtMestoRodjenja
            // 
            this.txtMestoRodjenja.Location = new System.Drawing.Point(432, 65);
            this.txtMestoRodjenja.Name = "txtMestoRodjenja";
            this.txtMestoRodjenja.Size = new System.Drawing.Size(100, 22);
            this.txtMestoRodjenja.TabIndex = 56;
            // 
            // txtMaticniBroj
            // 
            this.txtMaticniBroj.Location = new System.Drawing.Point(432, 118);
            this.txtMaticniBroj.Name = "txtMaticniBroj";
            this.txtMaticniBroj.Size = new System.Drawing.Size(100, 22);
            this.txtMaticniBroj.TabIndex = 55;
            // 
            // txtNadimak
            // 
            this.txtNadimak.Location = new System.Drawing.Point(120, 168);
            this.txtNadimak.Name = "txtNadimak";
            this.txtNadimak.Size = new System.Drawing.Size(100, 22);
            this.txtNadimak.TabIndex = 54;
            // 
            // txtLicnoIme
            // 
            this.txtLicnoIme.Location = new System.Drawing.Point(120, 21);
            this.txtLicnoIme.Name = "txtLicnoIme";
            this.txtLicnoIme.Size = new System.Drawing.Size(100, 22);
            this.txtLicnoIme.TabIndex = 53;
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPol.Location = new System.Drawing.Point(13, 221);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(33, 20);
            this.lblPol.TabIndex = 52;
            this.lblPol.Text = "Pol";
            // 
            // lblPocetakRada
            // 
            this.lblPocetakRada.AutoSize = true;
            this.lblPocetakRada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPocetakRada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPocetakRada.Location = new System.Drawing.Point(264, 165);
            this.lblPocetakRada.Name = "lblPocetakRada";
            this.lblPocetakRada.Size = new System.Drawing.Size(107, 20);
            this.lblPocetakRada.TabIndex = 51;
            this.lblPocetakRada.Text = "Početak rada";
            // 
            // lblMaticniBroj
            // 
            this.lblMaticniBroj.AutoSize = true;
            this.lblMaticniBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaticniBroj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMaticniBroj.Location = new System.Drawing.Point(264, 119);
            this.lblMaticniBroj.Name = "lblMaticniBroj";
            this.lblMaticniBroj.Size = new System.Drawing.Size(96, 20);
            this.lblMaticniBroj.TabIndex = 50;
            this.lblMaticniBroj.Text = "Matični broj";
            // 
            // lblMestoRodjenja
            // 
            this.lblMestoRodjenja.AutoSize = true;
            this.lblMestoRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMestoRodjenja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMestoRodjenja.Location = new System.Drawing.Point(264, 66);
            this.lblMestoRodjenja.Name = "lblMestoRodjenja";
            this.lblMestoRodjenja.Size = new System.Drawing.Size(115, 20);
            this.lblMestoRodjenja.TabIndex = 49;
            this.lblMestoRodjenja.Text = "Mesto rođenja";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumRodjenja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDatumRodjenja.Location = new System.Drawing.Point(264, 21);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(119, 20);
            this.lblDatumRodjenja.TabIndex = 48;
            this.lblDatumRodjenja.Text = "Datum rođenja";
            // 
            // lblNadimak
            // 
            this.lblNadimak.AutoSize = true;
            this.lblNadimak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNadimak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNadimak.Location = new System.Drawing.Point(13, 168);
            this.lblNadimak.Name = "lblNadimak";
            this.lblNadimak.Size = new System.Drawing.Size(74, 20);
            this.lblNadimak.TabIndex = 47;
            this.lblNadimak.Text = "Nadimak";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPrezime.Location = new System.Drawing.Point(13, 119);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(71, 20);
            this.lblPrezime.TabIndex = 46;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblImeRoditelja
            // 
            this.lblImeRoditelja.AutoSize = true;
            this.lblImeRoditelja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeRoditelja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblImeRoditelja.Location = new System.Drawing.Point(13, 69);
            this.lblImeRoditelja.Name = "lblImeRoditelja";
            this.lblImeRoditelja.Size = new System.Drawing.Size(100, 20);
            this.lblImeRoditelja.TabIndex = 45;
            this.lblImeRoditelja.Text = "Ime roditelja";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblIme.Location = new System.Drawing.Point(13, 21);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(36, 20);
            this.lblIme.TabIndex = 44;
            this.lblIme.Text = "Ime";
            // 
            // KlovnoviIzmeniForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(644, 375);
            this.Controls.Add(this.cblTip);
            this.Controls.Add(this.txtPredmet);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblPredmet);
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
            this.Name = "KlovnoviIzmeniForma";
            this.Text = "Izmeni klovnove";
            this.Load += new System.EventHandler(this.KlovnIzmeni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cblTip;
        private System.Windows.Forms.TextBox txtPredmet;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblPredmet;
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
    }
}