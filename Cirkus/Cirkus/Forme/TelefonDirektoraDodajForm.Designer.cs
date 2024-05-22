
namespace Cirkus.Forme
{
    partial class TelefonDirektoraDodajForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Dodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(27, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefon direktora:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Dodaj
            // 
            this.Dodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Dodaj.ForeColor = System.Drawing.Color.Blue;
            this.Dodaj.Location = new System.Drawing.Point(144, 249);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(130, 49);
            this.Dodaj.TabIndex = 2;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = false;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // TelefonDirektoraDodajFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(464, 372);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "TelefonDirektoraDodajFrom";
            this.Text = "Dodavanje telefona direktora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Dodaj;
    }
}