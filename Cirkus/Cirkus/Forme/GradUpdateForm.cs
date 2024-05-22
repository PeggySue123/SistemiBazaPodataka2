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
    public partial class GradUpdateForm : Form
    {
        readonly GradBasic grad;
        public GradUpdateForm()
        {
            InitializeComponent();
        }

        public GradUpdateForm(GradBasic g)
        {
            InitializeComponent();
            this.grad = g;
        }

        private void GradUpdateForm_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
            this.Text = $"AZURIRANJE GRADA {grad.Naziv_Grada.ToUpper()}";
        }

        public void PopuniPodacima()
        {
            txbGrad.Text = this.grad.Naziv_Grada;
            txbDrzava.Text = this.grad.Naziv_Drzave;
            txbDatOd.Value = this.grad.Datum_Od;
            txbDatDo.Value = this.grad.Datum_Do;
            txbOpis.Text = this.grad.Opis;
        }

        private void Azuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izmenite informacije o gradu?";
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

                DTOManager.AzurirajGrad(this.grad);
                MessageBox.Show("Ažuriranje grada je uspešno izvršeno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
