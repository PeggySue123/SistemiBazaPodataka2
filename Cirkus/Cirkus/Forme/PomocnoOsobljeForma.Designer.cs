
namespace Cirkus.Forme
{
    partial class PomocnoOsobljeForma
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
            this.ObrisiPomOs = new System.Windows.Forms.Button();
            this.IzmeniPomOs = new System.Windows.Forms.Button();
            this.DodajPomOs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ListaPomocnogOsoblja = new System.Windows.Forms.ListView();
            this.IdPom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MatBr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LimePom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SslovoPom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrezimePom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdDirektora2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ObrisiPomOs
            // 
            this.ObrisiPomOs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ObrisiPomOs.ForeColor = System.Drawing.Color.Blue;
            this.ObrisiPomOs.Location = new System.Drawing.Point(750, 320);
            this.ObrisiPomOs.Name = "ObrisiPomOs";
            this.ObrisiPomOs.Size = new System.Drawing.Size(117, 59);
            this.ObrisiPomOs.TabIndex = 14;
            this.ObrisiPomOs.Text = "Obriši pomoćno osoblje";
            this.ObrisiPomOs.UseVisualStyleBackColor = false;
            this.ObrisiPomOs.Click += new System.EventHandler(this.ObrisiPomOs_Click);
            // 
            // IzmeniPomOs
            // 
            this.IzmeniPomOs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.IzmeniPomOs.ForeColor = System.Drawing.Color.Blue;
            this.IzmeniPomOs.Location = new System.Drawing.Point(750, 217);
            this.IzmeniPomOs.Name = "IzmeniPomOs";
            this.IzmeniPomOs.Size = new System.Drawing.Size(117, 59);
            this.IzmeniPomOs.TabIndex = 13;
            this.IzmeniPomOs.Text = "Izmeni pomoćno osoblje";
            this.IzmeniPomOs.UseVisualStyleBackColor = false;
            this.IzmeniPomOs.Click += new System.EventHandler(this.IzmeniPomOs_Click);
            // 
            // DodajPomOs
            // 
            this.DodajPomOs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DodajPomOs.ForeColor = System.Drawing.Color.Blue;
            this.DodajPomOs.Location = new System.Drawing.Point(750, 107);
            this.DodajPomOs.Name = "DodajPomOs";
            this.DodajPomOs.Size = new System.Drawing.Size(117, 59);
            this.DodajPomOs.TabIndex = 12;
            this.DodajPomOs.Text = "Dodaj pomoćno osoblje";
            this.DodajPomOs.UseVisualStyleBackColor = false;
            this.DodajPomOs.Click += new System.EventHandler(this.DodajPomOs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(186, -41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "POMOĆNO OSOBLJE";
            // 
            // ListaPomocnogOsoblja
            // 
            this.ListaPomocnogOsoblja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdPom,
            this.MatBr,
            this.LimePom,
            this.SslovoPom,
            this.PrezimePom,
            this.Pol,
            this.Mesto,
            this.Datum,
            this.IdDirektora2});
            this.ListaPomocnogOsoblja.HideSelection = false;
            this.ListaPomocnogOsoblja.Location = new System.Drawing.Point(12, 28);
            this.ListaPomocnogOsoblja.Name = "ListaPomocnogOsoblja";
            this.ListaPomocnogOsoblja.Size = new System.Drawing.Size(709, 472);
            this.ListaPomocnogOsoblja.TabIndex = 10;
            this.ListaPomocnogOsoblja.UseCompatibleStateImageBehavior = false;
            this.ListaPomocnogOsoblja.View = System.Windows.Forms.View.Details;
            // 
            // IdPom
            // 
            this.IdPom.Text = "Id";
            this.IdPom.Width = 38;
            // 
            // MatBr
            // 
            this.MatBr.Text = "Matični broj";
            this.MatBr.Width = 83;
            // 
            // LimePom
            // 
            this.LimePom.Text = "Lično ime";
            this.LimePom.Width = 73;
            // 
            // SslovoPom
            // 
            this.SslovoPom.Text = "Srednje slovo";
            this.SslovoPom.Width = 101;
            // 
            // PrezimePom
            // 
            this.PrezimePom.Text = "Prezime";
            this.PrezimePom.Width = 67;
            // 
            // Pol
            // 
            this.Pol.Text = "Pol";
            this.Pol.Width = 39;
            // 
            // Mesto
            // 
            this.Mesto.Text = "Mesto rođenja";
            this.Mesto.Width = 101;
            // 
            // Datum
            // 
            this.Datum.Text = "Datum rođenja";
            this.Datum.Width = 102;
            // 
            // IdDirektora2
            // 
            this.IdDirektora2.Text = "ID direktora";
            // 
            // PomocnoOsobljeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(893, 512);
            this.Controls.Add(this.ObrisiPomOs);
            this.Controls.Add(this.IzmeniPomOs);
            this.Controls.Add(this.DodajPomOs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListaPomocnogOsoblja);
            this.Name = "PomocnoOsobljeForma";
            this.Text = "Pomoćno osoblje";
            this.Load += new System.EventHandler(this.PomocnoOsobljeForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ObrisiPomOs;
        private System.Windows.Forms.Button IzmeniPomOs;
        private System.Windows.Forms.Button DodajPomOs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView ListaPomocnogOsoblja;
        private System.Windows.Forms.ColumnHeader IdPom;
        private System.Windows.Forms.ColumnHeader MatBr;
        private System.Windows.Forms.ColumnHeader LimePom;
        private System.Windows.Forms.ColumnHeader SslovoPom;
        private System.Windows.Forms.ColumnHeader PrezimePom;
        private System.Windows.Forms.ColumnHeader Pol;
        private System.Windows.Forms.ColumnHeader Mesto;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader IdDirektora2;
    }
}