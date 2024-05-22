
namespace Cirkus.Forme
{
    partial class BacaciNozevaViseForma
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
            this.txtBacacNozeva = new System.Windows.Forms.TextBox();
            this.ListaAsistenata = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Roditelj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nadimak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblBacacNozeva = new System.Windows.Forms.Label();
            this.lblAsistenti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBacacNozeva
            // 
            this.txtBacacNozeva.Location = new System.Drawing.Point(274, 12);
            this.txtBacacNozeva.Name = "txtBacacNozeva";
            this.txtBacacNozeva.ReadOnly = true;
            this.txtBacacNozeva.Size = new System.Drawing.Size(173, 22);
            this.txtBacacNozeva.TabIndex = 15;
            // 
            // ListaAsistenata
            // 
            this.ListaAsistenata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.LIme,
            this.Roditelj,
            this.Prezime,
            this.Nadimak});
            this.ListaAsistenata.HideSelection = false;
            this.ListaAsistenata.Location = new System.Drawing.Point(182, 59);
            this.ListaAsistenata.Name = "ListaAsistenata";
            this.ListaAsistenata.Size = new System.Drawing.Size(439, 213);
            this.ListaAsistenata.TabIndex = 14;
            this.ListaAsistenata.UseCompatibleStateImageBehavior = false;
            this.ListaAsistenata.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // LIme
            // 
            this.LIme.Text = "Ime";
            this.LIme.Width = 80;
            // 
            // Roditelj
            // 
            this.Roditelj.Text = "Ime roditelja";
            this.Roditelj.Width = 94;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 95;
            // 
            // Nadimak
            // 
            this.Nadimak.Text = "Nadimak";
            this.Nadimak.Width = 99;
            // 
            // lblBacacNozeva
            // 
            this.lblBacacNozeva.AutoSize = true;
            this.lblBacacNozeva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBacacNozeva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBacacNozeva.Location = new System.Drawing.Point(143, 14);
            this.lblBacacNozeva.Name = "lblBacacNozeva";
            this.lblBacacNozeva.Size = new System.Drawing.Size(115, 20);
            this.lblBacacNozeva.TabIndex = 13;
            this.lblBacacNozeva.Text = "Bacač noževa";
            // 
            // lblAsistenti
            // 
            this.lblAsistenti.AutoSize = true;
            this.lblAsistenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistenti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAsistenti.Location = new System.Drawing.Point(12, 108);
            this.lblAsistenti.Name = "lblAsistenti";
            this.lblAsistenti.Size = new System.Drawing.Size(138, 40);
            this.lblAsistenti.TabIndex = 12;
            this.lblAsistenti.Text = "Asistenti bacača \r\nnoževa";
            // 
            // BacaciNozevaViseForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(635, 293);
            this.Controls.Add(this.txtBacacNozeva);
            this.Controls.Add(this.ListaAsistenata);
            this.Controls.Add(this.lblBacacNozeva);
            this.Controls.Add(this.lblAsistenti);
            this.Name = "BacaciNozevaViseForma";
            this.Text = "Više o bacačima noževa";
            this.Load += new System.EventHandler(this.BacacVise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBacacNozeva;
        private System.Windows.Forms.ListView ListaAsistenata;
        private System.Windows.Forms.Label lblBacacNozeva;
        private System.Windows.Forms.Label lblAsistenti;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader LIme;
        private System.Windows.Forms.ColumnHeader Roditelj;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader Nadimak;
    }
}