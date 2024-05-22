
namespace Cirkus.Forme
{
    partial class DreseriViseForma
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
            this.lblZivotinje = new System.Windows.Forms.Label();
            this.lblAsistenti = new System.Windows.Forms.Label();
            this.lblDreser = new System.Windows.Forms.Label();
            this.ListaZivotinja = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nadimak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vrsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListaAsistenata = new System.Windows.Forms.ListView();
            this.IdAs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IMe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Roditelj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NadAs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDreser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblZivotinje
            // 
            this.lblZivotinje.AutoSize = true;
            this.lblZivotinje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZivotinje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblZivotinje.Location = new System.Drawing.Point(32, 88);
            this.lblZivotinje.Name = "lblZivotinje";
            this.lblZivotinje.Size = new System.Drawing.Size(70, 40);
            this.lblZivotinje.TabIndex = 0;
            this.lblZivotinje.Text = "Životinje\r\ndresera";
            // 
            // lblAsistenti
            // 
            this.lblAsistenti.AutoSize = true;
            this.lblAsistenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistenti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAsistenti.Location = new System.Drawing.Point(32, 281);
            this.lblAsistenti.Name = "lblAsistenti";
            this.lblAsistenti.Size = new System.Drawing.Size(74, 40);
            this.lblAsistenti.TabIndex = 1;
            this.lblAsistenti.Text = "Asistenti\r\ndresera";
            // 
            // lblDreser
            // 
            this.lblDreser.AutoSize = true;
            this.lblDreser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDreser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDreser.Location = new System.Drawing.Point(179, 31);
            this.lblDreser.Name = "lblDreser";
            this.lblDreser.Size = new System.Drawing.Size(61, 20);
            this.lblDreser.TabIndex = 2;
            this.lblDreser.Text = "Dreser";
            // 
            // ListaZivotinja
            // 
            this.ListaZivotinja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nadimak,
            this.Vrsta});
            this.ListaZivotinja.HideSelection = false;
            this.ListaZivotinja.Location = new System.Drawing.Point(134, 88);
            this.ListaZivotinja.Name = "ListaZivotinja";
            this.ListaZivotinja.Size = new System.Drawing.Size(552, 176);
            this.ListaZivotinja.TabIndex = 3;
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
            this.Nadimak.Width = 151;
            // 
            // Vrsta
            // 
            this.Vrsta.Text = "Vrsta";
            this.Vrsta.Width = 160;
            // 
            // ListaAsistenata
            // 
            this.ListaAsistenata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdAs,
            this.IMe,
            this.Roditelj,
            this.Prezime,
            this.NadAs});
            this.ListaAsistenata.HideSelection = false;
            this.ListaAsistenata.Location = new System.Drawing.Point(134, 270);
            this.ListaAsistenata.Name = "ListaAsistenata";
            this.ListaAsistenata.Size = new System.Drawing.Size(552, 168);
            this.ListaAsistenata.TabIndex = 4;
            this.ListaAsistenata.UseCompatibleStateImageBehavior = false;
            this.ListaAsistenata.View = System.Windows.Forms.View.Details;
            // 
            // IdAs
            // 
            this.IdAs.Text = "Id";
            // 
            // IMe
            // 
            this.IMe.Text = "Ime";
            this.IMe.Width = 75;
            // 
            // Roditelj
            // 
            this.Roditelj.Text = "Ime roditelja";
            this.Roditelj.Width = 98;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 89;
            // 
            // NadAs
            // 
            this.NadAs.Text = "Nadimak";
            this.NadAs.Width = 107;
            // 
            // txtDreser
            // 
            this.txtDreser.Location = new System.Drawing.Point(271, 28);
            this.txtDreser.Name = "txtDreser";
            this.txtDreser.ReadOnly = true;
            this.txtDreser.Size = new System.Drawing.Size(173, 22);
            this.txtDreser.TabIndex = 5;
            // 
            // DreseriViseForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.txtDreser);
            this.Controls.Add(this.ListaAsistenata);
            this.Controls.Add(this.ListaZivotinja);
            this.Controls.Add(this.lblDreser);
            this.Controls.Add(this.lblAsistenti);
            this.Controls.Add(this.lblZivotinje);
            this.Name = "DreseriViseForma";
            this.Text = "Više o dreserima";
            this.Load += new System.EventHandler(this.DreserVise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZivotinje;
        private System.Windows.Forms.Label lblAsistenti;
        private System.Windows.Forms.Label lblDreser;
        private System.Windows.Forms.ListView ListaZivotinja;
        private System.Windows.Forms.ListView ListaAsistenata;
        private System.Windows.Forms.TextBox txtDreser;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nadimak;
        private System.Windows.Forms.ColumnHeader Vrsta;
        private System.Windows.Forms.ColumnHeader IdAs;
        private System.Windows.Forms.ColumnHeader IMe;
        private System.Windows.Forms.ColumnHeader Roditelj;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader NadAs;
    }
}