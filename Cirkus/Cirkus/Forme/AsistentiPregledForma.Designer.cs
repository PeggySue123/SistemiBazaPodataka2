
namespace Cirkus.Forme
{
    partial class AsistentiPregledForma
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
            this.ListaAsistenata = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MatBr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nadimak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Roditelj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direktor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnObrisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnObrisi.Location = new System.Drawing.Point(29, 254);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(145, 52);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obriši asistenta";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.ObrisiAsistenta_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnIzmeni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnIzmeni.Location = new System.Drawing.Point(29, 183);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(145, 49);
            this.btnIzmeni.TabIndex = 7;
            this.btnIzmeni.Text = "Izmeni asistenta";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.IzmeniAsistenta_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDodaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDodaj.Location = new System.Drawing.Point(29, 121);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(145, 45);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj asistenta";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.DodajAsistenta_Click);
            // 
            // ListaAsistenata
            // 
            this.ListaAsistenata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.MatBr,
            this.Datum,
            this.Nadimak,
            this.LIme,
            this.Roditelj,
            this.Prezime,
            this.Rad,
            this.Pol,
            this.Mesto,
            this.Direktor,
            this.Artista});
            this.ListaAsistenata.HideSelection = false;
            this.ListaAsistenata.Location = new System.Drawing.Point(211, 31);
            this.ListaAsistenata.Name = "ListaAsistenata";
            this.ListaAsistenata.Size = new System.Drawing.Size(1010, 395);
            this.ListaAsistenata.TabIndex = 5;
            this.ListaAsistenata.UseCompatibleStateImageBehavior = false;
            this.ListaAsistenata.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // MatBr
            // 
            this.MatBr.Text = "Matični broj";
            this.MatBr.Width = 98;
            // 
            // Datum
            // 
            this.Datum.Text = "Datum rođenja";
            this.Datum.Width = 101;
            // 
            // Nadimak
            // 
            this.Nadimak.Text = "Nadimak";
            this.Nadimak.Width = 69;
            // 
            // LIme
            // 
            this.LIme.Text = "Ime";
            this.LIme.Width = 70;
            // 
            // Roditelj
            // 
            this.Roditelj.Text = "Ime roditelja";
            this.Roditelj.Width = 86;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 87;
            // 
            // Rad
            // 
            this.Rad.Text = "Početak rada";
            this.Rad.Width = 93;
            // 
            // Pol
            // 
            this.Pol.Text = "Pol";
            // 
            // Mesto
            // 
            this.Mesto.Text = "Mesto rođenja";
            this.Mesto.Width = 103;
            // 
            // Direktor
            // 
            this.Direktor.Text = "Direktor";
            this.Direktor.Width = 78;
            // 
            // Artista
            // 
            this.Artista.Text = "Glavni artista";
            this.Artista.Width = 97;
            // 
            // AsistentiPregledForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1244, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.ListaAsistenata);
            this.Name = "AsistentiPregledForma";
            this.Text = "Asistenti";
            this.Load += new System.EventHandler(this.AsistentPregledForma_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListView ListaAsistenata;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader MatBr;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Nadimak;
        private System.Windows.Forms.ColumnHeader LIme;
        private System.Windows.Forms.ColumnHeader Roditelj;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader Rad;
        private System.Windows.Forms.ColumnHeader Pol;
        private System.Windows.Forms.ColumnHeader Mesto;
        private System.Windows.Forms.ColumnHeader Direktor;
        private System.Windows.Forms.ColumnHeader Artista;
    }
}