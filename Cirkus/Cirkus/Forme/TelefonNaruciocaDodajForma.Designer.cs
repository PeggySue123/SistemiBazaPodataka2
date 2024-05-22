
namespace Cirkus.Forme
{
    partial class TelefonNaruciocaDodajForma
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
            this.lblTelefonNarucioca = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTelefonNarucioca
            // 
            this.lblTelefonNarucioca.AutoSize = true;
            this.lblTelefonNarucioca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonNarucioca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTelefonNarucioca.Location = new System.Drawing.Point(33, 49);
            this.lblTelefonNarucioca.Name = "lblTelefonNarucioca";
            this.lblTelefonNarucioca.Size = new System.Drawing.Size(142, 20);
            this.lblTelefonNarucioca.TabIndex = 0;
            this.lblTelefonNarucioca.Text = "Telefon naručioca";
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(182, 49);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(177, 22);
            this.txtBroj.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDodaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDodaj.Location = new System.Drawing.Point(111, 100);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(128, 39);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // TelefonNaruciocaDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(388, 165);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.lblTelefonNarucioca);
            this.Name = "TelefonNaruciocaDodajForma";
            this.Text = "Dodaj telefon naručioca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTelefonNarucioca;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Button btnDodaj;
    }
}