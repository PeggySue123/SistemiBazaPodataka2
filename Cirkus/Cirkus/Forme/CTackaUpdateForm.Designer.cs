
namespace Cirkus.Forme
{
    partial class CTackaUpdateForm
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
            this.txbIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbOpEfekti = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbUzrast = new System.Windows.Forms.TextBox();
            this.Azuriraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(63, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime cirkuske tačke:";
            // 
            // txbIme
            // 
            this.txbIme.Location = new System.Drawing.Point(294, 68);
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(100, 22);
            this.txbIme.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(66, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip tačke:";
            // 
            // txbTip
            // 
            this.txbTip.Location = new System.Drawing.Point(294, 137);
            this.txbTip.Name = "txbTip";
            this.txbTip.Size = new System.Drawing.Size(100, 22);
            this.txbTip.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(69, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opasni efekti:";
            // 
            // txbOpEfekti
            // 
            this.txbOpEfekti.Location = new System.Drawing.Point(294, 202);
            this.txbOpEfekti.Name = "txbOpEfekti";
            this.txbOpEfekti.Size = new System.Drawing.Size(100, 22);
            this.txbOpEfekti.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(72, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Donja granica uzrasta:";
            // 
            // txbUzrast
            // 
            this.txbUzrast.Location = new System.Drawing.Point(294, 264);
            this.txbUzrast.Name = "txbUzrast";
            this.txbUzrast.Size = new System.Drawing.Size(100, 22);
            this.txbUzrast.TabIndex = 7;
            // 
            // Azuriraj
            // 
            this.Azuriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Azuriraj.ForeColor = System.Drawing.Color.Blue;
            this.Azuriraj.Location = new System.Drawing.Point(187, 369);
            this.Azuriraj.Name = "Azuriraj";
            this.Azuriraj.Size = new System.Drawing.Size(135, 55);
            this.Azuriraj.TabIndex = 8;
            this.Azuriraj.Text = "Ažuriraj";
            this.Azuriraj.UseVisualStyleBackColor = false;
            this.Azuriraj.Click += new System.EventHandler(this.Azuriraj_Click);
            // 
            // CTackaUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(524, 504);
            this.Controls.Add(this.Azuriraj);
            this.Controls.Add(this.txbUzrast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbOpEfekti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbIme);
            this.Controls.Add(this.label1);
            this.Name = "CTackaUpdateForm";
            this.Text = "Ažuriranje cirkuske tačke";
            this.Load += new System.EventHandler(this.CTackaUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbOpEfekti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbUzrast;
        private System.Windows.Forms.Button Azuriraj;
    }
}