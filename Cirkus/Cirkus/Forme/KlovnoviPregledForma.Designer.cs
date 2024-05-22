
namespace Cirkus.Forme
{
    partial class KlovnoviPregledForma
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
            this.ListaKlovnova = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MatBr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nadimak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Roditelj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Poc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direktor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Predmeti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnObrisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnObrisi.Location = new System.Drawing.Point(12, 257);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(145, 52);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obriši klovna";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.ObrisiKlovna_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnIzmeni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnIzmeni.Location = new System.Drawing.Point(12, 186);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(145, 49);
            this.btnIzmeni.TabIndex = 7;
            this.btnIzmeni.Text = "Izmeni klovna";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.IzmeniKlovna_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDodaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDodaj.Location = new System.Drawing.Point(12, 124);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(145, 45);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj klovna";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.DodajKlovna_Click);
            // 
            // ListaKlovnova
            // 
            this.ListaKlovnova.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.MatBr,
            this.Datum,
            this.Nadimak,
            this.Ime,
            this.Roditelj,
            this.Prezime,
            this.Poc,
            this.Pol,
            this.Mesto,
            this.Direktor,
            this.Tip,
            this.Predmeti});
            this.ListaKlovnova.HideSelection = false;
            this.ListaKlovnova.Location = new System.Drawing.Point(173, 22);
            this.ListaKlovnova.Name = "ListaKlovnova";
            this.ListaKlovnova.Size = new System.Drawing.Size(1104, 395);
            this.ListaKlovnova.TabIndex = 5;
            this.ListaKlovnova.UseCompatibleStateImageBehavior = false;
            this.ListaKlovnova.View = System.Windows.Forms.View.Details;
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
            this.Datum.Width = 101;
            // 
            // Nadimak
            // 
            this.Nadimak.Text = "Nadimak";
            this.Nadimak.Width = 70;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 75;
            // 
            // Roditelj
            // 
            this.Roditelj.Text = "Ime roditelja";
            this.Roditelj.Width = 92;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 80;
            // 
            // Poc
            // 
            this.Poc.Text = "Početak rada";
            this.Poc.Width = 98;
            // 
            // Pol
            // 
            this.Pol.Text = "Pol";
            // 
            // Mesto
            // 
            this.Mesto.Text = "Mesto rođenja";
            this.Mesto.Width = 102;
            // 
            // Direktor
            // 
            this.Direktor.Text = "Direktor";
            this.Direktor.Width = 71;
            // 
            // Tip
            // 
            this.Tip.Text = "Tip";
            // 
            // Predmeti
            // 
            this.Predmeti.Text = "Predmeti za zabavu";
            this.Predmeti.Width = 137;
            // 
            // KlovnoviPregledForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1289, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.ListaKlovnova);
            this.Name = "KlovnoviPregledForma";
            this.Text = "Klovnovi";
            this.Load += new System.EventHandler(this.KlovnPregledForma_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListView ListaKlovnova;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader MatBr;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Nadimak;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Roditelj;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader Poc;
        private System.Windows.Forms.ColumnHeader Pol;
        private System.Windows.Forms.ColumnHeader Mesto;
        private System.Windows.Forms.ColumnHeader Direktor;
        private System.Windows.Forms.ColumnHeader Tip;
        private System.Windows.Forms.ColumnHeader Predmeti;
    }
}