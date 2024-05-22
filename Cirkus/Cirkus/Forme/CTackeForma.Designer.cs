
namespace Cirkus.Forme
{
    partial class CTackeForma
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
            this.ListaCTacaka = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DodajCTacku = new System.Windows.Forms.Button();
            this.IzmeniCTacku = new System.Windows.Forms.Button();
            this.ObrisiCTacku = new System.Windows.Forms.Button();
            this.txbBrCT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Detalji = new System.Windows.Forms.Button();
            this.Tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpasniEf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonjaGr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ListaCTacaka
            // 
            this.ListaCTacaka.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Ime,
            this.Tip,
            this.OpasniEf,
            this.DonjaGr});
            this.ListaCTacaka.HideSelection = false;
            this.ListaCTacaka.Location = new System.Drawing.Point(27, 33);
            this.ListaCTacaka.Name = "ListaCTacaka";
            this.ListaCTacaka.Size = new System.Drawing.Size(648, 490);
            this.ListaCTacaka.TabIndex = 0;
            this.ListaCTacaka.UseCompatibleStateImageBehavior = false;
            this.ListaCTacaka.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 128;
            // 
            // DodajCTacku
            // 
            this.DodajCTacku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DodajCTacku.ForeColor = System.Drawing.Color.Blue;
            this.DodajCTacku.Location = new System.Drawing.Point(733, 180);
            this.DodajCTacku.Name = "DodajCTacku";
            this.DodajCTacku.Size = new System.Drawing.Size(135, 52);
            this.DodajCTacku.TabIndex = 1;
            this.DodajCTacku.Text = "Dodaj cirkusku tačku";
            this.DodajCTacku.UseVisualStyleBackColor = false;
            this.DodajCTacku.Click += new System.EventHandler(this.DodajCTacku_Click);
            // 
            // IzmeniCTacku
            // 
            this.IzmeniCTacku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.IzmeniCTacku.ForeColor = System.Drawing.Color.Blue;
            this.IzmeniCTacku.Location = new System.Drawing.Point(733, 256);
            this.IzmeniCTacku.Name = "IzmeniCTacku";
            this.IzmeniCTacku.Size = new System.Drawing.Size(135, 51);
            this.IzmeniCTacku.TabIndex = 2;
            this.IzmeniCTacku.Text = "Izmeni cirkusku tačku";
            this.IzmeniCTacku.UseVisualStyleBackColor = false;
            this.IzmeniCTacku.Click += new System.EventHandler(this.IzmeniCTacku_Click);
            // 
            // ObrisiCTacku
            // 
            this.ObrisiCTacku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ObrisiCTacku.ForeColor = System.Drawing.Color.Blue;
            this.ObrisiCTacku.Location = new System.Drawing.Point(733, 334);
            this.ObrisiCTacku.Name = "ObrisiCTacku";
            this.ObrisiCTacku.Size = new System.Drawing.Size(135, 51);
            this.ObrisiCTacku.TabIndex = 3;
            this.ObrisiCTacku.Text = "Obriši cirkusku tačku";
            this.ObrisiCTacku.UseVisualStyleBackColor = false;
            this.ObrisiCTacku.Click += new System.EventHandler(this.ObrisiCTacku_Click);
            // 
            // txbBrCT
            // 
            this.txbBrCT.Location = new System.Drawing.Point(711, 88);
            this.txbBrCT.Name = "txbBrCT";
            this.txbBrCT.ReadOnly = true;
            this.txbBrCT.Size = new System.Drawing.Size(187, 22);
            this.txbBrCT.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(708, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ukupan broj cirkuskih tačaka\r\nu našem cirkusu:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(708, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Upravljajte cirkuskim tačkama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(721, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pogledaj detalje o tački:";
            // 
            // Detalji
            // 
            this.Detalji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Detalji.ForeColor = System.Drawing.Color.Blue;
            this.Detalji.Location = new System.Drawing.Point(733, 480);
            this.Detalji.Name = "Detalji";
            this.Detalji.Size = new System.Drawing.Size(135, 43);
            this.Detalji.TabIndex = 8;
            this.Detalji.Text = "Vidi detalje";
            this.Detalji.UseVisualStyleBackColor = false;
            this.Detalji.Click += new System.EventHandler(this.Detalji_Click);
            // 
            // Tip
            // 
            this.Tip.Text = "Tip";
            this.Tip.Width = 106;
            // 
            // OpasniEf
            // 
            this.OpasniEf.Text = "Opasni efekti";
            this.OpasniEf.Width = 160;
            // 
            // DonjaGr
            // 
            this.DonjaGr.Text = "Donja granica uzrasta";
            this.DonjaGr.Width = 143;
            // 
            // CTackeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(930, 554);
            this.Controls.Add(this.Detalji);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbBrCT);
            this.Controls.Add(this.ObrisiCTacku);
            this.Controls.Add(this.IzmeniCTacku);
            this.Controls.Add(this.DodajCTacku);
            this.Controls.Add(this.ListaCTacaka);
            this.Name = "CTackeForma";
            this.Text = "Cirkuske tačke";
            this.Load += new System.EventHandler(this.CTackeForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListaCTacaka;
        private System.Windows.Forms.Button DodajCTacku;
        private System.Windows.Forms.Button IzmeniCTacku;
        private System.Windows.Forms.Button ObrisiCTacku;
        private System.Windows.Forms.TextBox txbBrCT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Detalji;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Tip;
        private System.Windows.Forms.ColumnHeader OpasniEf;
        private System.Windows.Forms.ColumnHeader DonjaGr;
    }
}