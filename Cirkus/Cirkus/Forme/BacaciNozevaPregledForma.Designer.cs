
namespace Cirkus.Forme
{
    partial class BacaciNozevaPregledForma
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
            this.btnVise = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.ListaBacaca = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MatBr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nadimak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Roditelj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pocetak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direktor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnVise
            // 
            this.btnVise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnVise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVise.Location = new System.Drawing.Point(13, 355);
            this.btnVise.Name = "btnVise";
            this.btnVise.Size = new System.Drawing.Size(145, 53);
            this.btnVise.TabIndex = 14;
            this.btnVise.Text = "Vidi više";
            this.btnVise.UseVisualStyleBackColor = false;
            this.btnVise.Click += new System.EventHandler(this.Detalji_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnObrisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnObrisi.Location = new System.Drawing.Point(12, 200);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(145, 52);
            this.btnObrisi.TabIndex = 13;
            this.btnObrisi.Text = "Obriši bacača noževa";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.ObrisiBacaca_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnIzmeni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnIzmeni.Location = new System.Drawing.Point(12, 129);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(145, 49);
            this.btnIzmeni.TabIndex = 12;
            this.btnIzmeni.Text = "Izmeni bacača noževa";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.BacaciNozevaIzmena_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDodaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDodaj.Location = new System.Drawing.Point(12, 67);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(145, 45);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj bacača noževa";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.DodajBacaca_Click);
            // 
            // ListaBacaca
            // 
            this.ListaBacaca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.MatBr,
            this.Nadimak,
            this.LIme,
            this.Roditelj,
            this.Prezime,
            this.Pocetak,
            this.Pol,
            this.Mesto,
            this.Direktor,
            this.Datum});
            this.ListaBacaca.HideSelection = false;
            this.ListaBacaca.Location = new System.Drawing.Point(196, 33);
            this.ListaBacaca.Name = "ListaBacaca";
            this.ListaBacaca.Size = new System.Drawing.Size(975, 395);
            this.ListaBacaca.TabIndex = 10;
            this.ListaBacaca.UseCompatibleStateImageBehavior = false;
            this.ListaBacaca.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // MatBr
            // 
            this.MatBr.Text = "Matični broj";
            this.MatBr.Width = 99;
            // 
            // Nadimak
            // 
            this.Nadimak.Text = "Nadimak";
            this.Nadimak.Width = 86;
            // 
            // LIme
            // 
            this.LIme.Text = "Ime";
            // 
            // Roditelj
            // 
            this.Roditelj.Text = "Ime roditelja";
            this.Roditelj.Width = 100;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 92;
            // 
            // Pocetak
            // 
            this.Pocetak.Text = "Početak rada";
            this.Pocetak.Width = 104;
            // 
            // Pol
            // 
            this.Pol.Text = "Pol";
            // 
            // Mesto
            // 
            this.Mesto.Text = "Mesto rođenja";
            this.Mesto.Width = 117;
            // 
            // Direktor
            // 
            this.Direktor.Text = "Direktor";
            this.Direktor.Width = 84;
            // 
            // Datum
            // 
            this.Datum.Text = "Datum rođenja";
            this.Datum.Width = 104;
            // 
            // BacaciNozevaPregledForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1199, 450);
            this.Controls.Add(this.btnVise);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.ListaBacaca);
            this.Name = "BacaciNozevaPregledForma";
            this.Text = "Bacači noževa";
            this.Load += new System.EventHandler(this.BacaciPregledForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVise;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListView ListaBacaca;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader MatBr;
        private System.Windows.Forms.ColumnHeader Nadimak;
        private System.Windows.Forms.ColumnHeader LIme;
        private System.Windows.Forms.ColumnHeader Roditelj;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader Pocetak;
        private System.Windows.Forms.ColumnHeader Pol;
        private System.Windows.Forms.ColumnHeader Mesto;
        private System.Windows.Forms.ColumnHeader Direktor;
        private System.Windows.Forms.ColumnHeader Datum;
    }
}