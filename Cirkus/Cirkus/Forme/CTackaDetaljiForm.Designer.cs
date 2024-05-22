
namespace Cirkus.Forme
{
    partial class CTackaDetaljiForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbImeTacke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ListaArtista = new System.Windows.Forms.ListView();
            this.ListaZivotinja = new System.Windows.Forms.ListView();
            this.ListaOsoblja = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nadimak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Roditelj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NadimakZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vrsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PolZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDPom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImePom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SSlovo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrezimePom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PolPom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(186, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Detalji tačke:";
            // 
            // txbImeTacke
            // 
            this.txbImeTacke.Location = new System.Drawing.Point(316, 12);
            this.txbImeTacke.Name = "txbImeTacke";
            this.txbImeTacke.ReadOnly = true;
            this.txbImeTacke.Size = new System.Drawing.Size(192, 22);
            this.txbImeTacke.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(97, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Artisti koji su angažovani\r\nna tački:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(97, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "Životinje angažovane\r\nna tački:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(97, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pomoćno osoblje\r\nzaduženo za tačku:";
            // 
            // ListaArtista
            // 
            this.ListaArtista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nadimak,
            this.Ime,
            this.Roditelj,
            this.Prezime,
            this.Pol});
            this.ListaArtista.HideSelection = false;
            this.ListaArtista.Location = new System.Drawing.Point(316, 87);
            this.ListaArtista.Name = "ListaArtista";
            this.ListaArtista.Size = new System.Drawing.Size(426, 167);
            this.ListaArtista.TabIndex = 8;
            this.ListaArtista.UseCompatibleStateImageBehavior = false;
            this.ListaArtista.View = System.Windows.Forms.View.Details;
            // 
            // ListaZivotinja
            // 
            this.ListaZivotinja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdZ,
            this.NadimakZ,
            this.Vrsta,
            this.PolZ});
            this.ListaZivotinja.HideSelection = false;
            this.ListaZivotinja.Location = new System.Drawing.Point(316, 260);
            this.ListaZivotinja.Name = "ListaZivotinja";
            this.ListaZivotinja.Size = new System.Drawing.Size(426, 167);
            this.ListaZivotinja.TabIndex = 9;
            this.ListaZivotinja.UseCompatibleStateImageBehavior = false;
            this.ListaZivotinja.View = System.Windows.Forms.View.Details;
            // 
            // ListaOsoblja
            // 
            this.ListaOsoblja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDPom,
            this.ImePom,
            this.SSlovo,
            this.PrezimePom,
            this.PolPom});
            this.ListaOsoblja.HideSelection = false;
            this.ListaOsoblja.Location = new System.Drawing.Point(316, 433);
            this.ListaOsoblja.Name = "ListaOsoblja";
            this.ListaOsoblja.Size = new System.Drawing.Size(426, 167);
            this.ListaOsoblja.TabIndex = 10;
            this.ListaOsoblja.UseCompatibleStateImageBehavior = false;
            this.ListaOsoblja.View = System.Windows.Forms.View.Details;
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
            // Ime
            // 
            this.Ime.Text = "Ime";
            // 
            // Roditelj
            // 
            this.Roditelj.Text = "Ime roditelja";
            this.Roditelj.Width = 92;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 72;
            // 
            // Pol
            // 
            this.Pol.Text = "Pol";
            // 
            // IdZ
            // 
            this.IdZ.Text = "Id";
            // 
            // NadimakZ
            // 
            this.NadimakZ.Text = "Nadimak";
            this.NadimakZ.Width = 153;
            // 
            // Vrsta
            // 
            this.Vrsta.Text = "Vrsta";
            this.Vrsta.Width = 142;
            // 
            // PolZ
            // 
            this.PolZ.Text = "Pol";
            // 
            // IDPom
            // 
            this.IDPom.Text = "Id";
            // 
            // ImePom
            // 
            this.ImePom.Text = "Ime";
            this.ImePom.Width = 109;
            // 
            // SSlovo
            // 
            this.SSlovo.Text = "S Slovo";
            // 
            // PrezimePom
            // 
            this.PrezimePom.Text = "Prezime";
            this.PrezimePom.Width = 124;
            // 
            // PolPom
            // 
            this.PolPom.Text = "Pol";
            // 
            // CTackaDetaljiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(768, 607);
            this.Controls.Add(this.ListaOsoblja);
            this.Controls.Add(this.ListaZivotinja);
            this.Controls.Add(this.ListaArtista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbImeTacke);
            this.Controls.Add(this.label1);
            this.Name = "CTackaDetaljiForm";
            this.Text = "Detalji cirkuske tačke";
            this.Load += new System.EventHandler(this.CTackaDetaljiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbImeTacke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView ListaArtista;
        private System.Windows.Forms.ListView ListaZivotinja;
        private System.Windows.Forms.ListView ListaOsoblja;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nadimak;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Roditelj;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader Pol;
        private System.Windows.Forms.ColumnHeader IdZ;
        private System.Windows.Forms.ColumnHeader NadimakZ;
        private System.Windows.Forms.ColumnHeader Vrsta;
        private System.Windows.Forms.ColumnHeader PolZ;
        private System.Windows.Forms.ColumnHeader IDPom;
        private System.Windows.Forms.ColumnHeader ImePom;
        private System.Windows.Forms.ColumnHeader SSlovo;
        private System.Windows.Forms.ColumnHeader PrezimePom;
        private System.Windows.Forms.ColumnHeader PolPom;
    }
}