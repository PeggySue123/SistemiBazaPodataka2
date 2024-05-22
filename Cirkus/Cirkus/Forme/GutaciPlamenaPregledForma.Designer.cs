
namespace Cirkus.Forme
{
    partial class GutaciPlamenaPregledForma
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
            this.ListaGutaca = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MatBr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nadimak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Roditelj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pocetakrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direktor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnObrisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnObrisi.Location = new System.Drawing.Point(42, 199);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(145, 52);
            this.btnObrisi.TabIndex = 7;
            this.btnObrisi.Text = "Obriši gutača";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnIzmeni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnIzmeni.Location = new System.Drawing.Point(42, 128);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(145, 49);
            this.btnIzmeni.TabIndex = 6;
            this.btnIzmeni.Text = "Izmeni gutača";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDodaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDodaj.Location = new System.Drawing.Point(42, 66);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(145, 45);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj gutača";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // ListaGutaca
            // 
            this.ListaGutaca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.MatBr,
            this.Dat,
            this.Nadimak,
            this.Lime,
            this.Roditelj,
            this.Prezime,
            this.Pocetakrada,
            this.Pol,
            this.Mesto,
            this.Direktor});
            this.ListaGutaca.HideSelection = false;
            this.ListaGutaca.Location = new System.Drawing.Point(239, 29);
            this.ListaGutaca.Name = "ListaGutaca";
            this.ListaGutaca.Size = new System.Drawing.Size(939, 395);
            this.ListaGutaca.TabIndex = 4;
            this.ListaGutaca.UseCompatibleStateImageBehavior = false;
            this.ListaGutaca.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // MatBr
            // 
            this.MatBr.Text = "Matični broj";
            this.MatBr.Width = 105;
            // 
            // Dat
            // 
            this.Dat.Text = "Datum rođenja";
            this.Dat.Width = 102;
            // 
            // Nadimak
            // 
            this.Nadimak.Text = "Nadimak";
            this.Nadimak.Width = 72;
            // 
            // Lime
            // 
            this.Lime.Text = "Ime";
            this.Lime.Width = 76;
            // 
            // Roditelj
            // 
            this.Roditelj.Text = "Ime roditelja";
            this.Roditelj.Width = 91;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 92;
            // 
            // Pocetakrada
            // 
            this.Pocetakrada.Text = "Početak rada";
            this.Pocetakrada.Width = 97;
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
            // 
            // btnVise
            // 
            this.btnVise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnVise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVise.Location = new System.Drawing.Point(42, 341);
            this.btnVise.Name = "btnVise";
            this.btnVise.Size = new System.Drawing.Size(145, 53);
            this.btnVise.TabIndex = 8;
            this.btnVise.Text = "Vidi više";
            this.btnVise.UseVisualStyleBackColor = false;
            this.btnVise.Click += new System.EventHandler(this.btnVise_Click);
            // 
            // GutaciPlamenaPregledForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1210, 450);
            this.Controls.Add(this.btnVise);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.ListaGutaca);
            this.Name = "GutaciPlamenaPregledForma";
            this.Text = "Gutači plamena";
            this.Load += new System.EventHandler(this.GutaciPlamenaPregledForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListView ListaGutaca;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader MatBr;
        private System.Windows.Forms.ColumnHeader Dat;
        private System.Windows.Forms.ColumnHeader Nadimak;
        private System.Windows.Forms.ColumnHeader Lime;
        private System.Windows.Forms.ColumnHeader Roditelj;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader Pocetakrada;
        private System.Windows.Forms.ColumnHeader Pol;
        private System.Windows.Forms.ColumnHeader Mesto;
        private System.Windows.Forms.ColumnHeader Direktor;
        private System.Windows.Forms.Button btnVise;
    }
}