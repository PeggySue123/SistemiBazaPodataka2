
namespace Cirkus.Forme
{
    partial class ZivotinjeForma
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
            this.ListaZivotinja = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nadimak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vrsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Starost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VremeBoravka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojKaveza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tezina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DodajZivotinju = new System.Windows.Forms.Button();
            this.IzmeniZivotinju = new System.Windows.Forms.Button();
            this.ObrisiZivotinju = new System.Windows.Forms.Button();
            this.Dreseri = new System.Windows.Forms.Button();
            this.Direktor = new System.Windows.Forms.Button();
            this.IDDresera = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDdirektora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ListaZivotinja
            // 
            this.ListaZivotinja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nadimak,
            this.Vrsta,
            this.Pol,
            this.Starost,
            this.VremeBoravka,
            this.Datum,
            this.BrojKaveza,
            this.Tezina,
            this.IDDresera,
            this.IDdirektora});
            this.ListaZivotinja.HideSelection = false;
            this.ListaZivotinja.Location = new System.Drawing.Point(13, 13);
            this.ListaZivotinja.Name = "ListaZivotinja";
            this.ListaZivotinja.Size = new System.Drawing.Size(892, 425);
            this.ListaZivotinja.TabIndex = 0;
            this.ListaZivotinja.UseCompatibleStateImageBehavior = false;
            this.ListaZivotinja.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Nadimak
            // 
            this.Nadimak.Text = "Nadimak";
            this.Nadimak.Width = 77;
            // 
            // Vrsta
            // 
            this.Vrsta.Text = "Vrsta";
            // 
            // Pol
            // 
            this.Pol.Text = "Pol";
            // 
            // Starost
            // 
            this.Starost.Text = "Starost";
            // 
            // VremeBoravka
            // 
            this.VremeBoravka.Text = "Vreme boravka";
            this.VremeBoravka.Width = 116;
            // 
            // Datum
            // 
            this.Datum.Text = "Datum vet. pregleda";
            this.Datum.Width = 135;
            // 
            // BrojKaveza
            // 
            this.BrojKaveza.Text = "Broj kaveza";
            this.BrojKaveza.Width = 88;
            // 
            // Tezina
            // 
            this.Tezina.Text = "Težina";
            // 
            // DodajZivotinju
            // 
            this.DodajZivotinju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DodajZivotinju.ForeColor = System.Drawing.Color.Blue;
            this.DodajZivotinju.Location = new System.Drawing.Point(911, 43);
            this.DodajZivotinju.Name = "DodajZivotinju";
            this.DodajZivotinju.Size = new System.Drawing.Size(147, 46);
            this.DodajZivotinju.TabIndex = 1;
            this.DodajZivotinju.Text = "Dodaj životinju";
            this.DodajZivotinju.UseVisualStyleBackColor = false;
            this.DodajZivotinju.Click += new System.EventHandler(this.DodajZivotinju_Click);
            // 
            // IzmeniZivotinju
            // 
            this.IzmeniZivotinju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.IzmeniZivotinju.ForeColor = System.Drawing.Color.Blue;
            this.IzmeniZivotinju.Location = new System.Drawing.Point(911, 110);
            this.IzmeniZivotinju.Name = "IzmeniZivotinju";
            this.IzmeniZivotinju.Size = new System.Drawing.Size(147, 46);
            this.IzmeniZivotinju.TabIndex = 2;
            this.IzmeniZivotinju.Text = "Izmeni životinju";
            this.IzmeniZivotinju.UseVisualStyleBackColor = false;
            this.IzmeniZivotinju.Click += new System.EventHandler(this.IzmeniZivotinju_Click);
            // 
            // ObrisiZivotinju
            // 
            this.ObrisiZivotinju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ObrisiZivotinju.ForeColor = System.Drawing.Color.Blue;
            this.ObrisiZivotinju.Location = new System.Drawing.Point(911, 178);
            this.ObrisiZivotinju.Name = "ObrisiZivotinju";
            this.ObrisiZivotinju.Size = new System.Drawing.Size(147, 46);
            this.ObrisiZivotinju.TabIndex = 3;
            this.ObrisiZivotinju.Text = "Obriši životinju";
            this.ObrisiZivotinju.UseVisualStyleBackColor = false;
            this.ObrisiZivotinju.Click += new System.EventHandler(this.ObrisiZivotinju_Click);
            // 
            // Dreseri
            // 
            this.Dreseri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Dreseri.ForeColor = System.Drawing.Color.Blue;
            this.Dreseri.Location = new System.Drawing.Point(911, 300);
            this.Dreseri.Name = "Dreseri";
            this.Dreseri.Size = new System.Drawing.Size(147, 46);
            this.Dreseri.TabIndex = 4;
            this.Dreseri.Text = "Dreser";
            this.Dreseri.UseVisualStyleBackColor = false;
            this.Dreseri.Click += new System.EventHandler(this.Dreseri_Click);
            // 
            // Direktor
            // 
            this.Direktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Direktor.ForeColor = System.Drawing.Color.Blue;
            this.Direktor.Location = new System.Drawing.Point(911, 361);
            this.Direktor.Name = "Direktor";
            this.Direktor.Size = new System.Drawing.Size(147, 46);
            this.Direktor.TabIndex = 5;
            this.Direktor.Text = "Direktor";
            this.Direktor.UseVisualStyleBackColor = false;
            this.Direktor.Click += new System.EventHandler(this.Direktor_Click);
            // 
            // IDDresera
            // 
            this.IDDresera.Text = "ID Dresera";
            this.IDDresera.Width = 81;
            // 
            // IDdirektora
            // 
            this.IDdirektora.Text = "ID Direktora";
            this.IDdirektora.Width = 89;
            // 
            // ZivotinjeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1080, 450);
            this.Controls.Add(this.Direktor);
            this.Controls.Add(this.Dreseri);
            this.Controls.Add(this.ObrisiZivotinju);
            this.Controls.Add(this.IzmeniZivotinju);
            this.Controls.Add(this.DodajZivotinju);
            this.Controls.Add(this.ListaZivotinja);
            this.Name = "ZivotinjeForma";
            this.Text = "Životinje";
            this.Load += new System.EventHandler(this.ZivotinjeForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListaZivotinja;
        private System.Windows.Forms.Button DodajZivotinju;
        private System.Windows.Forms.Button IzmeniZivotinju;
        private System.Windows.Forms.Button ObrisiZivotinju;
        private System.Windows.Forms.Button Dreseri;
        private System.Windows.Forms.Button Direktor;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nadimak;
        private System.Windows.Forms.ColumnHeader Vrsta;
        private System.Windows.Forms.ColumnHeader Pol;
        private System.Windows.Forms.ColumnHeader Starost;
        private System.Windows.Forms.ColumnHeader VremeBoravka;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader BrojKaveza;
        private System.Windows.Forms.ColumnHeader Tezina;
        private System.Windows.Forms.ColumnHeader IDDresera;
        private System.Windows.Forms.ColumnHeader IDdirektora;
    }
}