
namespace Cirkus.Forme
{
    partial class GradForma
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
            this.DodajGrad = new System.Windows.Forms.Button();
            this.ObrisiGrad = new System.Windows.Forms.Button();
            this.IzmeniGrad = new System.Windows.Forms.Button();
            this.ListaGradova = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Drzava = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumOd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumDo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Opis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // DodajGrad
            // 
            this.DodajGrad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DodajGrad.ForeColor = System.Drawing.Color.Blue;
            this.DodajGrad.Location = new System.Drawing.Point(674, 179);
            this.DodajGrad.Name = "DodajGrad";
            this.DodajGrad.Size = new System.Drawing.Size(149, 47);
            this.DodajGrad.TabIndex = 1;
            this.DodajGrad.Text = "Dodaj Grad";
            this.DodajGrad.UseVisualStyleBackColor = false;
            this.DodajGrad.Click += new System.EventHandler(this.DodajGrad_Click);
            // 
            // ObrisiGrad
            // 
            this.ObrisiGrad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ObrisiGrad.ForeColor = System.Drawing.Color.Blue;
            this.ObrisiGrad.Location = new System.Drawing.Point(674, 360);
            this.ObrisiGrad.Name = "ObrisiGrad";
            this.ObrisiGrad.Size = new System.Drawing.Size(149, 46);
            this.ObrisiGrad.TabIndex = 2;
            this.ObrisiGrad.Text = "Obriši Grad";
            this.ObrisiGrad.UseVisualStyleBackColor = false;
            this.ObrisiGrad.Click += new System.EventHandler(this.ObrisiGrad_Click);
            // 
            // IzmeniGrad
            // 
            this.IzmeniGrad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.IzmeniGrad.ForeColor = System.Drawing.Color.Blue;
            this.IzmeniGrad.Location = new System.Drawing.Point(674, 270);
            this.IzmeniGrad.Name = "IzmeniGrad";
            this.IzmeniGrad.Size = new System.Drawing.Size(149, 47);
            this.IzmeniGrad.TabIndex = 3;
            this.IzmeniGrad.Text = "Izmeni Grad";
            this.IzmeniGrad.UseVisualStyleBackColor = false;
            this.IzmeniGrad.Click += new System.EventHandler(this.IzmeniGrad_Click);
            // 
            // ListaGradova
            // 
            this.ListaGradova.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Grad,
            this.Drzava,
            this.DatumOd,
            this.DatumDo,
            this.Opis});
            this.ListaGradova.HideSelection = false;
            this.ListaGradova.Location = new System.Drawing.Point(12, 12);
            this.ListaGradova.Margin = new System.Windows.Forms.Padding(4);
            this.ListaGradova.Name = "ListaGradova";
            this.ListaGradova.Size = new System.Drawing.Size(626, 530);
            this.ListaGradova.TabIndex = 4;
            this.ListaGradova.UseCompatibleStateImageBehavior = false;
            this.ListaGradova.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Grad
            // 
            this.Grad.Text = "Ime grada";
            this.Grad.Width = 92;
            // 
            // Drzava
            // 
            this.Drzava.Text = "Država";
            this.Drzava.Width = 88;
            // 
            // DatumOd
            // 
            this.DatumOd.Text = "Od";
            this.DatumOd.Width = 111;
            // 
            // DatumDo
            // 
            this.DatumDo.Text = "Do";
            this.DatumDo.Width = 108;
            // 
            // Opis
            // 
            this.Opis.Text = "Opis";
            this.Opis.Width = 169;
            // 
            // GradForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(848, 554);
            this.Controls.Add(this.ListaGradova);
            this.Controls.Add(this.IzmeniGrad);
            this.Controls.Add(this.ObrisiGrad);
            this.Controls.Add(this.DodajGrad);
            this.Name = "GradForma";
            this.Text = "Gradovi";
            this.Load += new System.EventHandler(this.GradForma_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DodajGrad;
        private System.Windows.Forms.Button ObrisiGrad;
        private System.Windows.Forms.Button IzmeniGrad;
        private System.Windows.Forms.ListView ListaGradova;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Grad;
        private System.Windows.Forms.ColumnHeader Drzava;
        private System.Windows.Forms.ColumnHeader DatumOd;
        private System.Windows.Forms.ColumnHeader DatumDo;
        private System.Windows.Forms.ColumnHeader Opis;
    }
}