
namespace Cirkus.Forme
{
    partial class HumanitarnaPredstavaDodajForma
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
            this.lblPrihod = new System.Windows.Forms.Label();
            this.lblNamenjenPrihod = new System.Windows.Forms.Label();
            this.txtPrihod = new System.Windows.Forms.TextBox();
            this.txtNamenjenPrihod = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrihod
            // 
            this.lblPrihod.AutoSize = true;
            this.lblPrihod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrihod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPrihod.Location = new System.Drawing.Point(23, 54);
            this.lblPrihod.Name = "lblPrihod";
            this.lblPrihod.Size = new System.Drawing.Size(57, 20);
            this.lblPrihod.TabIndex = 0;
            this.lblPrihod.Text = "Prihod";
            // 
            // lblNamenjenPrihod
            // 
            this.lblNamenjenPrihod.AutoSize = true;
            this.lblNamenjenPrihod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamenjenPrihod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNamenjenPrihod.Location = new System.Drawing.Point(22, 86);
            this.lblNamenjenPrihod.Name = "lblNamenjenPrihod";
            this.lblNamenjenPrihod.Size = new System.Drawing.Size(135, 20);
            this.lblNamenjenPrihod.TabIndex = 1;
            this.lblNamenjenPrihod.Text = "Namenjen prihod";
            // 
            // txtPrihod
            // 
            this.txtPrihod.Location = new System.Drawing.Point(175, 53);
            this.txtPrihod.Name = "txtPrihod";
            this.txtPrihod.Size = new System.Drawing.Size(160, 22);
            this.txtPrihod.TabIndex = 2;
            // 
            // txtNamenjenPrihod
            // 
            this.txtNamenjenPrihod.Location = new System.Drawing.Point(175, 81);
            this.txtNamenjenPrihod.Name = "txtNamenjenPrihod";
            this.txtNamenjenPrihod.Size = new System.Drawing.Size(160, 22);
            this.txtNamenjenPrihod.TabIndex = 3;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSacuvaj.Location = new System.Drawing.Point(109, 134);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(104, 39);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.Sacuvaj_Predstavu_Click);
            // 
            // HumanitarnaPredstavaDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(356, 200);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtNamenjenPrihod);
            this.Controls.Add(this.txtPrihod);
            this.Controls.Add(this.lblNamenjenPrihod);
            this.Controls.Add(this.lblPrihod);
            this.Name = "HumanitarnaPredstavaDodajForma";
            this.Text = "Dodaj humanitarnu predstavu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrihod;
        private System.Windows.Forms.Label lblNamenjenPrihod;
        private System.Windows.Forms.TextBox txtPrihod;
        private System.Windows.Forms.TextBox txtNamenjenPrihod;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}