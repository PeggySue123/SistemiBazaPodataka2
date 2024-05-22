
namespace Cirkus.Forme
{
    partial class PredstaveForma
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
            this.txbBrPredst = new System.Windows.Forms.TextBox();
            this.ListaRedovne = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.izmeniHumanitarnu = new System.Windows.Forms.Button();
            this.obrisiRedovnu = new System.Windows.Forms.Button();
            this.ListaHumanitarne = new System.Windows.Forms.ListView();
            this.IdHum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RazlogHum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prihod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namenjen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListaNarucene = new System.Windows.Forms.ListView();
            this.IdNar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RazlogNar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.obrisiHumanitarnu = new System.Windows.Forms.Button();
            this.dodajHumanitarnu = new System.Windows.Forms.Button();
            this.obrisiNarucenu = new System.Windows.Forms.Button();
            this.dodajNarucenu = new System.Windows.Forms.Button();
            this.izmeniNaruceni = new System.Windows.Forms.Button();
            this.dodajRedovnu = new System.Windows.Forms.Button();
            this.VidiVise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ukupan broj predstava:";
            // 
            // txbBrPredst
            // 
            this.txbBrPredst.Location = new System.Drawing.Point(31, 76);
            this.txbBrPredst.Name = "txbBrPredst";
            this.txbBrPredst.ReadOnly = true;
            this.txbBrPredst.Size = new System.Drawing.Size(153, 22);
            this.txbBrPredst.TabIndex = 1;
            // 
            // ListaRedovne
            // 
            this.ListaRedovne.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id});
            this.ListaRedovne.HideSelection = false;
            this.ListaRedovne.Location = new System.Drawing.Point(211, 33);
            this.ListaRedovne.Name = "ListaRedovne";
            this.ListaRedovne.Size = new System.Drawing.Size(626, 177);
            this.ListaRedovne.TabIndex = 2;
            this.ListaRedovne.UseCompatibleStateImageBehavior = false;
            this.ListaRedovne.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // izmeniHumanitarnu
            // 
            this.izmeniHumanitarnu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.izmeniHumanitarnu.ForeColor = System.Drawing.Color.Blue;
            this.izmeniHumanitarnu.Location = new System.Drawing.Point(866, 276);
            this.izmeniHumanitarnu.Name = "izmeniHumanitarnu";
            this.izmeniHumanitarnu.Size = new System.Drawing.Size(108, 48);
            this.izmeniHumanitarnu.TabIndex = 4;
            this.izmeniHumanitarnu.Text = "Izmeni predstavu";
            this.izmeniHumanitarnu.UseVisualStyleBackColor = false;
            this.izmeniHumanitarnu.Click += new System.EventHandler(this.izmeniHumanitarnu_Click);
            // 
            // obrisiRedovnu
            // 
            this.obrisiRedovnu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.obrisiRedovnu.ForeColor = System.Drawing.Color.Blue;
            this.obrisiRedovnu.Location = new System.Drawing.Point(866, 134);
            this.obrisiRedovnu.Name = "obrisiRedovnu";
            this.obrisiRedovnu.Size = new System.Drawing.Size(108, 49);
            this.obrisiRedovnu.TabIndex = 5;
            this.obrisiRedovnu.Text = "Obriši predstavu";
            this.obrisiRedovnu.UseVisualStyleBackColor = false;
            this.obrisiRedovnu.Click += new System.EventHandler(this.obrisiRedovnu_Click);
            // 
            // ListaHumanitarne
            // 
            this.ListaHumanitarne.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdHum,
            this.RazlogHum,
            this.Prihod,
            this.Namenjen});
            this.ListaHumanitarne.HideSelection = false;
            this.ListaHumanitarne.Location = new System.Drawing.Point(211, 216);
            this.ListaHumanitarne.Name = "ListaHumanitarne";
            this.ListaHumanitarne.Size = new System.Drawing.Size(626, 177);
            this.ListaHumanitarne.TabIndex = 7;
            this.ListaHumanitarne.UseCompatibleStateImageBehavior = false;
            this.ListaHumanitarne.View = System.Windows.Forms.View.Details;
            // 
            // IdHum
            // 
            this.IdHum.Text = "Id";
            // 
            // RazlogHum
            // 
            this.RazlogHum.Text = "Razlog Organizovanja";
            this.RazlogHum.Width = 151;
            // 
            // Prihod
            // 
            this.Prihod.Text = "Prihod";
            this.Prihod.Width = 75;
            // 
            // Namenjen
            // 
            this.Namenjen.Text = "Namenjen";
            this.Namenjen.Width = 98;
            // 
            // ListaNarucene
            // 
            this.ListaNarucene.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdNar,
            this.RazlogNar,
            this.Naziv,
            this.Adresa});
            this.ListaNarucene.HideSelection = false;
            this.ListaNarucene.Location = new System.Drawing.Point(211, 399);
            this.ListaNarucene.Name = "ListaNarucene";
            this.ListaNarucene.Size = new System.Drawing.Size(626, 177);
            this.ListaNarucene.TabIndex = 8;
            this.ListaNarucene.UseCompatibleStateImageBehavior = false;
            this.ListaNarucene.View = System.Windows.Forms.View.Details;
            // 
            // IdNar
            // 
            this.IdNar.Text = "Id";
            // 
            // RazlogNar
            // 
            this.RazlogNar.Text = "Razlog Organizovanja";
            this.RazlogNar.Width = 151;
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            this.Naziv.Width = 100;
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            this.Adresa.Width = 137;
            // 
            // obrisiHumanitarnu
            // 
            this.obrisiHumanitarnu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.obrisiHumanitarnu.ForeColor = System.Drawing.Color.Blue;
            this.obrisiHumanitarnu.Location = new System.Drawing.Point(866, 330);
            this.obrisiHumanitarnu.Name = "obrisiHumanitarnu";
            this.obrisiHumanitarnu.Size = new System.Drawing.Size(108, 49);
            this.obrisiHumanitarnu.TabIndex = 10;
            this.obrisiHumanitarnu.Text = "Obriši predstavu";
            this.obrisiHumanitarnu.UseVisualStyleBackColor = false;
            this.obrisiHumanitarnu.Click += new System.EventHandler(this.obrisiHumanitarnu_Click);
            // 
            // dodajHumanitarnu
            // 
            this.dodajHumanitarnu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dodajHumanitarnu.ForeColor = System.Drawing.Color.Blue;
            this.dodajHumanitarnu.Location = new System.Drawing.Point(866, 223);
            this.dodajHumanitarnu.Name = "dodajHumanitarnu";
            this.dodajHumanitarnu.Size = new System.Drawing.Size(108, 47);
            this.dodajHumanitarnu.TabIndex = 9;
            this.dodajHumanitarnu.Text = "Dodaj predstavu";
            this.dodajHumanitarnu.UseVisualStyleBackColor = false;
            this.dodajHumanitarnu.Click += new System.EventHandler(this.dodajHumanitarnu_Click);
            // 
            // obrisiNarucenu
            // 
            this.obrisiNarucenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.obrisiNarucenu.ForeColor = System.Drawing.Color.Blue;
            this.obrisiNarucenu.Location = new System.Drawing.Point(866, 517);
            this.obrisiNarucenu.Name = "obrisiNarucenu";
            this.obrisiNarucenu.Size = new System.Drawing.Size(108, 49);
            this.obrisiNarucenu.TabIndex = 13;
            this.obrisiNarucenu.Text = "Obriši predstavu";
            this.obrisiNarucenu.UseVisualStyleBackColor = false;
            this.obrisiNarucenu.Click += new System.EventHandler(this.obrisiNarucenu_Click);
            // 
            // dodajNarucenu
            // 
            this.dodajNarucenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dodajNarucenu.ForeColor = System.Drawing.Color.Blue;
            this.dodajNarucenu.Location = new System.Drawing.Point(866, 410);
            this.dodajNarucenu.Name = "dodajNarucenu";
            this.dodajNarucenu.Size = new System.Drawing.Size(108, 47);
            this.dodajNarucenu.TabIndex = 12;
            this.dodajNarucenu.Text = "Dodaj predstavu";
            this.dodajNarucenu.UseVisualStyleBackColor = false;
            this.dodajNarucenu.Click += new System.EventHandler(this.dodajNarucenu_Click);
            // 
            // izmeniNaruceni
            // 
            this.izmeniNaruceni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.izmeniNaruceni.ForeColor = System.Drawing.Color.Blue;
            this.izmeniNaruceni.Location = new System.Drawing.Point(866, 463);
            this.izmeniNaruceni.Name = "izmeniNaruceni";
            this.izmeniNaruceni.Size = new System.Drawing.Size(108, 48);
            this.izmeniNaruceni.TabIndex = 11;
            this.izmeniNaruceni.Text = "Izmeni predstavu";
            this.izmeniNaruceni.UseVisualStyleBackColor = false;
            this.izmeniNaruceni.Click += new System.EventHandler(this.izmeniNaruceni_Click);
            // 
            // dodajRedovnu
            // 
            this.dodajRedovnu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dodajRedovnu.ForeColor = System.Drawing.Color.Blue;
            this.dodajRedovnu.Location = new System.Drawing.Point(866, 64);
            this.dodajRedovnu.Name = "dodajRedovnu";
            this.dodajRedovnu.Size = new System.Drawing.Size(108, 47);
            this.dodajRedovnu.TabIndex = 14;
            this.dodajRedovnu.Text = "Dodaj predstavu";
            this.dodajRedovnu.UseVisualStyleBackColor = false;
            this.dodajRedovnu.Click += new System.EventHandler(this.dodajRedovnu_Click);
            // 
            // VidiVise
            // 
            this.VidiVise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.VidiVise.ForeColor = System.Drawing.Color.Blue;
            this.VidiVise.Location = new System.Drawing.Point(76, 517);
            this.VidiVise.Name = "VidiVise";
            this.VidiVise.Size = new System.Drawing.Size(108, 49);
            this.VidiVise.TabIndex = 15;
            this.VidiVise.Text = "Vidi više o naručenim";
            this.VidiVise.UseVisualStyleBackColor = false;
            this.VidiVise.Click += new System.EventHandler(this.VidiVise_Click);
            // 
            // PredstaveForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1032, 595);
            this.Controls.Add(this.VidiVise);
            this.Controls.Add(this.dodajRedovnu);
            this.Controls.Add(this.obrisiNarucenu);
            this.Controls.Add(this.dodajNarucenu);
            this.Controls.Add(this.izmeniNaruceni);
            this.Controls.Add(this.obrisiHumanitarnu);
            this.Controls.Add(this.dodajHumanitarnu);
            this.Controls.Add(this.ListaNarucene);
            this.Controls.Add(this.ListaHumanitarne);
            this.Controls.Add(this.obrisiRedovnu);
            this.Controls.Add(this.izmeniHumanitarnu);
            this.Controls.Add(this.ListaRedovne);
            this.Controls.Add(this.txbBrPredst);
            this.Controls.Add(this.label1);
            this.Name = "PredstaveForma";
            this.Text = "Cirkuske predstave";
            this.Load += new System.EventHandler(this.PredstaveForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBrPredst;
        private System.Windows.Forms.ListView ListaRedovne;
        private System.Windows.Forms.Button izmeniHumanitarnu;
        private System.Windows.Forms.Button obrisiRedovnu;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ListView ListaHumanitarne;
        private System.Windows.Forms.ColumnHeader IdHum;
        private System.Windows.Forms.ColumnHeader RazlogHum;
        private System.Windows.Forms.ColumnHeader Prihod;
        private System.Windows.Forms.ColumnHeader Namenjen;
        private System.Windows.Forms.ListView ListaNarucene;
        private System.Windows.Forms.ColumnHeader IdNar;
        private System.Windows.Forms.ColumnHeader RazlogNar;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.Button obrisiHumanitarnu;
        private System.Windows.Forms.Button dodajHumanitarnu;
        private System.Windows.Forms.Button obrisiNarucenu;
        private System.Windows.Forms.Button dodajNarucenu;
        private System.Windows.Forms.Button izmeniNaruceni;
        private System.Windows.Forms.Button dodajRedovnu;
        private System.Windows.Forms.Button VidiVise;
    }
}