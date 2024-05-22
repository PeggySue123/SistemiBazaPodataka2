
namespace Cirkus.Forme
{
    partial class DreseriForma
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
            this.txbNadimak = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbVrsta = new System.Windows.Forms.TextBox();
            this.txbDreser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(119, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nadimak životinje:";
            // 
            // txbNadimak
            // 
            this.txbNadimak.Location = new System.Drawing.Point(318, 73);
            this.txbNadimak.Name = "txbNadimak";
            this.txbNadimak.ReadOnly = true;
            this.txbNadimak.Size = new System.Drawing.Size(226, 22);
            this.txbNadimak.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(119, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dreser životinje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(119, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vrsta životinje:";
            // 
            // txbVrsta
            // 
            this.txbVrsta.Location = new System.Drawing.Point(318, 112);
            this.txbVrsta.Name = "txbVrsta";
            this.txbVrsta.ReadOnly = true;
            this.txbVrsta.Size = new System.Drawing.Size(226, 22);
            this.txbVrsta.TabIndex = 5;
            // 
            // txbDreser
            // 
            this.txbDreser.Location = new System.Drawing.Point(318, 150);
            this.txbDreser.Multiline = true;
            this.txbDreser.Name = "txbDreser";
            this.txbDreser.ReadOnly = true;
            this.txbDreser.Size = new System.Drawing.Size(226, 24);
            this.txbDreser.TabIndex = 2;
            // 
            // DreseriForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(617, 240);
            this.Controls.Add(this.txbVrsta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbDreser);
            this.Controls.Add(this.txbNadimak);
            this.Controls.Add(this.label1);
            this.Name = "DreseriForma";
            this.Text = "Dreser životinje";
            this.Load += new System.EventHandler(this.Dreseri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNadimak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbVrsta;
        private System.Windows.Forms.TextBox txbDreser;
    }
}