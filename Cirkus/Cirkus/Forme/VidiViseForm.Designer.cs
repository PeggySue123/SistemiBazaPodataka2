
namespace Cirkus.Forme
{
    partial class VidiViseForm
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
            this.DodajMail = new System.Windows.Forms.Button();
            this.ObrisiMail = new System.Windows.Forms.Button();
            this.DodajBroj = new System.Windows.Forms.Button();
            this.ObrisiBroj = new System.Windows.Forms.Button();
            this.ListaMejlova = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListaBrojeva = new System.Windows.Forms.ListView();
            this.IdTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // DodajMail
            // 
            this.DodajMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DodajMail.ForeColor = System.Drawing.Color.Blue;
            this.DodajMail.Location = new System.Drawing.Point(33, 80);
            this.DodajMail.Name = "DodajMail";
            this.DodajMail.Size = new System.Drawing.Size(125, 38);
            this.DodajMail.TabIndex = 0;
            this.DodajMail.Text = "Dodaj e-mail";
            this.DodajMail.UseVisualStyleBackColor = false;
            this.DodajMail.Click += new System.EventHandler(this.DodajMail_Click);
            // 
            // ObrisiMail
            // 
            this.ObrisiMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ObrisiMail.ForeColor = System.Drawing.Color.Blue;
            this.ObrisiMail.Location = new System.Drawing.Point(33, 146);
            this.ObrisiMail.Name = "ObrisiMail";
            this.ObrisiMail.Size = new System.Drawing.Size(125, 38);
            this.ObrisiMail.TabIndex = 1;
            this.ObrisiMail.Text = "Obriši e-mail";
            this.ObrisiMail.UseVisualStyleBackColor = false;
            this.ObrisiMail.Click += new System.EventHandler(this.ObrisiMail_Click);
            // 
            // DodajBroj
            // 
            this.DodajBroj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DodajBroj.ForeColor = System.Drawing.Color.Blue;
            this.DodajBroj.Location = new System.Drawing.Point(33, 274);
            this.DodajBroj.Name = "DodajBroj";
            this.DodajBroj.Size = new System.Drawing.Size(125, 38);
            this.DodajBroj.TabIndex = 2;
            this.DodajBroj.Text = "Dodaj broj";
            this.DodajBroj.UseVisualStyleBackColor = false;
            this.DodajBroj.Click += new System.EventHandler(this.DodajBroj_Click);
            // 
            // ObrisiBroj
            // 
            this.ObrisiBroj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ObrisiBroj.ForeColor = System.Drawing.Color.Blue;
            this.ObrisiBroj.Location = new System.Drawing.Point(33, 338);
            this.ObrisiBroj.Name = "ObrisiBroj";
            this.ObrisiBroj.Size = new System.Drawing.Size(125, 38);
            this.ObrisiBroj.TabIndex = 3;
            this.ObrisiBroj.Text = "Obriši broj";
            this.ObrisiBroj.UseVisualStyleBackColor = false;
            this.ObrisiBroj.Click += new System.EventHandler(this.ObrisiBroj_Click);
            // 
            // ListaMejlova
            // 
            this.ListaMejlova.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.EMail});
            this.ListaMejlova.HideSelection = false;
            this.ListaMejlova.Location = new System.Drawing.Point(251, 55);
            this.ListaMejlova.Name = "ListaMejlova";
            this.ListaMejlova.Size = new System.Drawing.Size(395, 155);
            this.ListaMejlova.TabIndex = 4;
            this.ListaMejlova.UseCompatibleStateImageBehavior = false;
            this.ListaMejlova.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 124;
            // 
            // EMail
            // 
            this.EMail.Text = "E-mail";
            this.EMail.Width = 259;
            // 
            // ListaBrojeva
            // 
            this.ListaBrojeva.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdTel,
            this.Telefon});
            this.ListaBrojeva.HideSelection = false;
            this.ListaBrojeva.Location = new System.Drawing.Point(251, 245);
            this.ListaBrojeva.Name = "ListaBrojeva";
            this.ListaBrojeva.Size = new System.Drawing.Size(395, 155);
            this.ListaBrojeva.TabIndex = 5;
            this.ListaBrojeva.UseCompatibleStateImageBehavior = false;
            this.ListaBrojeva.View = System.Windows.Forms.View.Details;
            // 
            // IdTel
            // 
            this.IdTel.Text = "ID";
            this.IdTel.Width = 64;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Broj telefona";
            this.Telefon.Width = 325;
            // 
            // VidiViseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.ListaBrojeva);
            this.Controls.Add(this.ListaMejlova);
            this.Controls.Add(this.ObrisiBroj);
            this.Controls.Add(this.DodajBroj);
            this.Controls.Add(this.ObrisiMail);
            this.Controls.Add(this.DodajMail);
            this.Name = "VidiViseForm";
            this.Text = "Više o direktoru";
            this.Load += new System.EventHandler(this.VidiViseForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DodajMail;
        private System.Windows.Forms.Button ObrisiMail;
        private System.Windows.Forms.Button DodajBroj;
        private System.Windows.Forms.Button ObrisiBroj;
        private System.Windows.Forms.ListView ListaMejlova;
        private System.Windows.Forms.ListView ListaBrojeva;
        private System.Windows.Forms.ColumnHeader EMail;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader IdTel;
    }
}