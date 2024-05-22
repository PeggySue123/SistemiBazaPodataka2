
namespace Cirkus.Forme
{
    partial class NarucenaPredstavaForma
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
            this.lvNarucioc = new System.Windows.Forms.ListView();
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvNarucioc
            // 
            this.lvNarucioc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Telefon});
            this.lvNarucioc.HideSelection = false;
            this.lvNarucioc.Location = new System.Drawing.Point(174, 11);
            this.lvNarucioc.Name = "lvNarucioc";
            this.lvNarucioc.Size = new System.Drawing.Size(274, 187);
            this.lvNarucioc.TabIndex = 0;
            this.lvNarucioc.UseCompatibleStateImageBehavior = false;
            this.lvNarucioc.View = System.Windows.Forms.View.Details;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Broj telefona naručioca";
            this.Telefon.Width = 262;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDodaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDodaj.Location = new System.Drawing.Point(12, 41);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(113, 34);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj Telefon";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnObrisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnObrisi.Location = new System.Drawing.Point(12, 116);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(113, 33);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši Telefon";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.Obrisi_Click);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // NarucenaPredstavaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(472, 210);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lvNarucioc);
            this.Name = "NarucenaPredstavaForma";
            this.Text = "Više o naručenim predstavama";
            this.Load += new System.EventHandler(this.NarucenaPredstavaForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvNarucioc;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Id;
    }
}