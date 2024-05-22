﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cirkus.Forme
{
    public partial class EMailDodajForm : Form
    {
        EmailDirektoraBasic mejl;
        public EMailDodajForm()
        {
            InitializeComponent();
            mejl = new EmailDirektoraBasic();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate nov E-mail?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.mejl.Email = textBox1.Text;

                DTOManager.DodajEmail(mejl);
                MessageBox.Show("Uspešno ste dodali nov e-mail!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
