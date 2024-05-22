
namespace Cirkus.Forme
{
    partial class ArtistiForma
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
            this.TipArtiste = new System.Windows.Forms.CheckedListBox();
            this.btnPrikaziArtistu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TipArtiste
            // 
            this.TipArtiste.BackColor = System.Drawing.Color.MistyRose;
            this.TipArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipArtiste.FormattingEnabled = true;
            this.TipArtiste.Items.AddRange(new object[] {
            "Akrobate",
            "Asistenti",
            "Bacaci Nozeva",
            "Dreseri",
            "Gutaci Plamena",
            "Klovnovi",
            "Zongleri"});
            this.TipArtiste.Location = new System.Drawing.Point(108, 60);
            this.TipArtiste.Name = "TipArtiste";
            this.TipArtiste.Size = new System.Drawing.Size(197, 137);
            this.TipArtiste.TabIndex = 0;
            // 
            // btnPrikaziArtistu
            // 
            this.btnPrikaziArtistu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPrikaziArtistu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPrikaziArtistu.Location = new System.Drawing.Point(136, 255);
            this.btnPrikaziArtistu.Name = "btnPrikaziArtistu";
            this.btnPrikaziArtistu.Size = new System.Drawing.Size(128, 35);
            this.btnPrikaziArtistu.TabIndex = 1;
            this.btnPrikaziArtistu.Text = "Prikaži artistu";
            this.btnPrikaziArtistu.UseVisualStyleBackColor = false;
            this.btnPrikaziArtistu.Click += new System.EventHandler(this.PrikaziArtistu_Click);
            // 
            // ArtistiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(459, 385);
            this.Controls.Add(this.btnPrikaziArtistu);
            this.Controls.Add(this.TipArtiste);
            this.Name = "ArtistiForma";
            this.Text = "Artisti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox TipArtiste;
        private System.Windows.Forms.Button btnPrikaziArtistu;
    }
}