using System;
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
    public partial class GradDodajForm : Form
    {
        GradBasic grad;
        public GradDodajForm()
        {
            InitializeComponent();
            grad = new GradBasic();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate nov grad?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.grad.Naziv_Grada = txbGrad.Text;
                this.grad.Naziv_Drzave = txbDrzava.Text;
                this.grad.Datum_Od = txbDatOd.Value;
                this.grad.Datum_Do = txbDatDo.Value;
                this.grad.Opis = txbOpis.Text;

                DTOManager.DodajGrad(this.grad);
                MessageBox.Show("Uspešno ste dodali novi grad!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
