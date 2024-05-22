
namespace Cirkus.Forme
{
    partial class AkrobataViseForma
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtAkrobata = new System.Windows.Forms.TextBox();
            this.lblAkrobata = new System.Windows.Forms.Label();
            this.ListaVestina = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrGod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDodaj.ForeColor = System.Drawing.Color.Blue;
            this.btnDodaj.Location = new System.Drawing.Point(12, 66);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(123, 39);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj vestinu";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.DodajVestinu_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnIzmeni.ForeColor = System.Drawing.Color.Blue;
            this.btnIzmeni.Location = new System.Drawing.Point(12, 143);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(123, 40);
            this.btnIzmeni.TabIndex = 2;
            this.btnIzmeni.Text = "Izmeni vestinu";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.IzmeniVestinu_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnObrisi.ForeColor = System.Drawing.Color.Blue;
            this.btnObrisi.Location = new System.Drawing.Point(13, 231);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(122, 39);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obrisi vestinu";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.ObrisiVestinu_Click);
            // 
            // txtAkrobata
            // 
            this.txtAkrobata.Location = new System.Drawing.Point(189, 17);
            this.txtAkrobata.Name = "txtAkrobata";
            this.txtAkrobata.ReadOnly = true;
            this.txtAkrobata.Size = new System.Drawing.Size(214, 22);
            this.txtAkrobata.TabIndex = 4;
            // 
            // lblAkrobata
            // 
            this.lblAkrobata.AutoSize = true;
            this.lblAkrobata.Location = new System.Drawing.Point(88, 17);
            this.lblAkrobata.Name = "lblAkrobata";
            this.lblAkrobata.Size = new System.Drawing.Size(69, 17);
            this.lblAkrobata.TabIndex = 5;
            this.lblAkrobata.Text = "Akrobata:";
            // 
            // ListaVestina
            // 
            this.ListaVestina.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Naziv,
            this.BrGod});
            this.ListaVestina.HideSelection = false;
            this.ListaVestina.Location = new System.Drawing.Point(163, 66);
            this.ListaVestina.Name = "ListaVestina";
            this.ListaVestina.Size = new System.Drawing.Size(307, 204);
            this.ListaVestina.TabIndex = 6;
            this.ListaVestina.UseCompatibleStateImageBehavior = false;
            this.ListaVestina.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Naziv
            // 
            this.Naziv.Text = "Veština";
            this.Naziv.Width = 118;
            // 
            // BrGod
            // 
            this.BrGod.Text = "Broj godina";
            this.BrGod.Width = 117;
            // 
            // AkrobataViseForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(491, 282);
            this.Controls.Add(this.ListaVestina);
            this.Controls.Add(this.lblAkrobata);
            this.Controls.Add(this.txtAkrobata);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Name = "AkrobataViseForma";
            this.Text = "Više o akrobati";
            this.Load += new System.EventHandler(this.AkrobataVise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtAkrobata;
        private System.Windows.Forms.Label lblAkrobata;
        private System.Windows.Forms.ListView ListaVestina;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader BrGod;
    }
}