
namespace Cirkus.Forme
{
    partial class ZongleriPregledForma
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
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.ListaZonglera = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MatBr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nadimak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SSLovo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PocetakRada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direktor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BRoj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnObrisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnObrisi.Location = new System.Drawing.Point(12, 262);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(145, 46);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obriši žonglera";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.ObrisiZonglera_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnIzmeni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnIzmeni.Location = new System.Drawing.Point(12, 191);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(145, 49);
            this.btnIzmeni.TabIndex = 7;
            this.btnIzmeni.Text = "Izmeni žonglera";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.IzmeniZonglera_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDodaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDodaj.Location = new System.Drawing.Point(12, 129);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(145, 45);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj žonglera";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.DodajZonglera_Click);
            // 
            // ListaZonglera
            // 
            this.ListaZonglera.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.MatBr,
            this.Datum,
            this.Nadimak,
            this.Lime,
            this.SSLovo,
            this.Prezime,
            this.PocetakRada,
            this.Pol,
            this.Mesto,
            this.Direktor,
            this.Naziv,
            this.BRoj});
            this.ListaZonglera.HideSelection = false;
            this.ListaZonglera.Location = new System.Drawing.Point(205, 26);
            this.ListaZonglera.Name = "ListaZonglera";
            this.ListaZonglera.Size = new System.Drawing.Size(1012, 395);
            this.ListaZonglera.TabIndex = 5;
            this.ListaZonglera.UseCompatibleStateImageBehavior = false;
            this.ListaZonglera.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // MatBr
            // 
            this.MatBr.Text = "Matični broj";
            this.MatBr.Width = 88;
            // 
            // Datum
            // 
            this.Datum.Text = "Datum rođenja";
            this.Datum.Width = 100;
            // 
            // Nadimak
            // 
            this.Nadimak.Text = "Nadimak";
            this.Nadimak.Width = 69;
            // 
            // Lime
            // 
            this.Lime.Text = "Ime";
            // 
            // SSLovo
            // 
            this.SSLovo.Text = "Ime roditelja";
            this.SSLovo.Width = 93;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 61;
            // 
            // PocetakRada
            // 
            this.PocetakRada.Text = "Početak rada";
            this.PocetakRada.Width = 99;
            // 
            // Pol
            // 
            this.Pol.Text = "Pol";
            this.Pol.Width = 40;
            // 
            // Mesto
            // 
            this.Mesto.Text = "Mesto rođenja";
            this.Mesto.Width = 101;
            // 
            // Direktor
            // 
            this.Direktor.Text = "Direktor";
            // 
            // Naziv
            // 
            this.Naziv.Text = "Predmeti";
            this.Naziv.Width = 69;
            // 
            // BRoj
            // 
            this.BRoj.Text = "Br. predmeta";
            this.BRoj.Width = 98;
            // 
            // ZongleriPregledForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1229, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.ListaZonglera);
            this.Name = "ZongleriPregledForma";
            this.Text = "Žongleri";
            this.Load += new System.EventHandler(this.ZonglerPregledForma_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListView ListaZonglera;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader MatBr;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Nadimak;
        private System.Windows.Forms.ColumnHeader Lime;
        private System.Windows.Forms.ColumnHeader SSLovo;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader PocetakRada;
        private System.Windows.Forms.ColumnHeader Pol;
        private System.Windows.Forms.ColumnHeader Mesto;
        private System.Windows.Forms.ColumnHeader Direktor;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader BRoj;
    }
}