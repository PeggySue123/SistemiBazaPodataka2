
namespace Cirkus.Forme
{
    partial class GutaciPlamenaViseForma
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
            this.txtDreser = new System.Windows.Forms.TextBox();
            this.ListaAsistenata = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Roditelj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nadimak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblGutacPlamena = new System.Windows.Forms.Label();
            this.lblAsistenti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDreser
            // 
            this.txtDreser.Location = new System.Drawing.Point(274, 17);
            this.txtDreser.Name = "txtDreser";
            this.txtDreser.ReadOnly = true;
            this.txtDreser.Size = new System.Drawing.Size(173, 22);
            this.txtDreser.TabIndex = 11;
            // 
            // ListaAsistenata
            // 
            this.ListaAsistenata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Ime,
            this.Roditelj,
            this.Prezime,
            this.Nadimak});
            this.ListaAsistenata.HideSelection = false;
            this.ListaAsistenata.Location = new System.Drawing.Point(188, 64);
            this.ListaAsistenata.Name = "ListaAsistenata";
            this.ListaAsistenata.Size = new System.Drawing.Size(515, 213);
            this.ListaAsistenata.TabIndex = 10;
            this.ListaAsistenata.UseCompatibleStateImageBehavior = false;
            this.ListaAsistenata.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 85;
            // 
            // Roditelj
            // 
            this.Roditelj.Text = "Ime roditelja";
            this.Roditelj.Width = 115;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 101;
            // 
            // Nadimak
            // 
            this.Nadimak.Text = "Nadimak";
            this.Nadimak.Width = 141;
            // 
            // lblGutacPlamena
            // 
            this.lblGutacPlamena.AutoSize = true;
            this.lblGutacPlamena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGutacPlamena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblGutacPlamena.Location = new System.Drawing.Point(137, 19);
            this.lblGutacPlamena.Name = "lblGutacPlamena";
            this.lblGutacPlamena.Size = new System.Drawing.Size(122, 20);
            this.lblGutacPlamena.TabIndex = 8;
            this.lblGutacPlamena.Text = "Gutač plamena";
            // 
            // lblAsistenti
            // 
            this.lblAsistenti.AutoSize = true;
            this.lblAsistenti.BackColor = System.Drawing.Color.MistyRose;
            this.lblAsistenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistenti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAsistenti.Location = new System.Drawing.Point(35, 100);
            this.lblAsistenti.Name = "lblAsistenti";
            this.lblAsistenti.Size = new System.Drawing.Size(127, 40);
            this.lblAsistenti.TabIndex = 7;
            this.lblAsistenti.Text = "Asistenti \r\ngutača plamena";
            // 
            // GutaciPlamenaViseForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(715, 299);
            this.Controls.Add(this.txtDreser);
            this.Controls.Add(this.ListaAsistenata);
            this.Controls.Add(this.lblGutacPlamena);
            this.Controls.Add(this.lblAsistenti);
            this.Name = "GutaciPlamenaViseForma";
            this.Text = "Više o gutačima plamena";
            this.Load += new System.EventHandler(this.GutacVise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDreser;
        private System.Windows.Forms.ListView ListaAsistenata;
        private System.Windows.Forms.Label lblGutacPlamena;
        private System.Windows.Forms.Label lblAsistenti;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Roditelj;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader Nadimak;
    }
}