
namespace Cirkus.Forme
{
    partial class OsobljeForma
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
            this.ListaDirektora = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SSlovo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.DodajDirektora = new System.Windows.Forms.Button();
            this.IzmeniDirektora = new System.Windows.Forms.Button();
            this.ObrisiDirektora = new System.Windows.Forms.Button();
            this.VidiVise = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaDirektora
            // 
            this.ListaDirektora.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.LIme,
            this.SSlovo,
            this.Prezime});
            this.ListaDirektora.HideSelection = false;
            this.ListaDirektora.Location = new System.Drawing.Point(147, 110);
            this.ListaDirektora.Name = "ListaDirektora";
            this.ListaDirektora.Size = new System.Drawing.Size(519, 472);
            this.ListaDirektora.TabIndex = 0;
            this.ListaDirektora.UseCompatibleStateImageBehavior = false;
            this.ListaDirektora.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // LIme
            // 
            this.LIme.Text = "Lično ime";
            this.LIme.Width = 122;
            // 
            // SSlovo
            // 
            this.SSlovo.Text = "Srednje slovo";
            this.SSlovo.Width = 118;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(350, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "DIREKTORI";
            // 
            // DodajDirektora
            // 
            this.DodajDirektora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DodajDirektora.ForeColor = System.Drawing.Color.Blue;
            this.DodajDirektora.Location = new System.Drawing.Point(12, 163);
            this.DodajDirektora.Name = "DodajDirektora";
            this.DodajDirektora.Size = new System.Drawing.Size(117, 59);
            this.DodajDirektora.TabIndex = 4;
            this.DodajDirektora.Text = "Dodaj direktora";
            this.DodajDirektora.UseVisualStyleBackColor = false;
            this.DodajDirektora.Click += new System.EventHandler(this.DodajDirektora_Click);
            // 
            // IzmeniDirektora
            // 
            this.IzmeniDirektora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.IzmeniDirektora.ForeColor = System.Drawing.Color.Blue;
            this.IzmeniDirektora.Location = new System.Drawing.Point(12, 273);
            this.IzmeniDirektora.Name = "IzmeniDirektora";
            this.IzmeniDirektora.Size = new System.Drawing.Size(117, 59);
            this.IzmeniDirektora.TabIndex = 6;
            this.IzmeniDirektora.Text = "Izmeni direktora";
            this.IzmeniDirektora.UseVisualStyleBackColor = false;
            this.IzmeniDirektora.Click += new System.EventHandler(this.IzmeniDirektora_Click);
            // 
            // ObrisiDirektora
            // 
            this.ObrisiDirektora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ObrisiDirektora.ForeColor = System.Drawing.Color.Blue;
            this.ObrisiDirektora.Location = new System.Drawing.Point(12, 376);
            this.ObrisiDirektora.Name = "ObrisiDirektora";
            this.ObrisiDirektora.Size = new System.Drawing.Size(117, 59);
            this.ObrisiDirektora.TabIndex = 7;
            this.ObrisiDirektora.Text = "Obriši direktora";
            this.ObrisiDirektora.UseVisualStyleBackColor = false;
            this.ObrisiDirektora.Click += new System.EventHandler(this.ObrisiDirektora_Click);
            // 
            // VidiVise
            // 
            this.VidiVise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.VidiVise.ForeColor = System.Drawing.Color.Blue;
            this.VidiVise.Location = new System.Drawing.Point(12, 472);
            this.VidiVise.Name = "VidiVise";
            this.VidiVise.Size = new System.Drawing.Size(117, 59);
            this.VidiVise.TabIndex = 10;
            this.VidiVise.Text = "Vidi više o direktoru";
            this.VidiVise.UseVisualStyleBackColor = false;
            this.VidiVise.Click += new System.EventHandler(this.VidiVise_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(699, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 59);
            this.button1.TabIndex = 11;
            this.button1.Text = "Vidi pomoćno osoblje";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OsobljeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(847, 634);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VidiVise);
            this.Controls.Add(this.ObrisiDirektora);
            this.Controls.Add(this.IzmeniDirektora);
            this.Controls.Add(this.DodajDirektora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaDirektora);
            this.Name = "OsobljeForma";
            this.Text = "Osoblje";
            this.Load += new System.EventHandler(this.OsobljeForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListaDirektora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DodajDirektora;
        private System.Windows.Forms.Button IzmeniDirektora;
        private System.Windows.Forms.Button ObrisiDirektora;
        private System.Windows.Forms.Button VidiVise;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader LIme;
        private System.Windows.Forms.ColumnHeader SSlovo;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.Button button1;
    }
}