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
    public partial class CTackaUpdateForm : Form
    {
        CirkuskaTackaBasic tacka;
        public CTackaUpdateForm()
        {
            InitializeComponent();
        }

        public CTackaUpdateForm(CirkuskaTackaBasic ct)
        {
            InitializeComponent();
            this.tacka = ct;
        }

        private void Azuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izmenite informacije o cirkuskoj tački?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.tacka.Ime = txbIme.Text;
                this.tacka.Tip = txbTip.Text;
                this.tacka.Opasni_Efekti = txbOpEfekti.Text;
                this.tacka.Donja_Granica_Uzrasta = Int32.Parse(txbUzrast.Text);

                DTOManager.AzurirajCirkuskuTacku(this.tacka);
                MessageBox.Show("Ažuriranje tačke je uspešno izvršeno!");
                this.Close();
            }
            else
            {

            }
        }

        public void popuniPodacima()
        {
            txbIme.Text = this.tacka.Ime;
            txbTip.Text = this.tacka.Tip;
            txbOpEfekti.Text = this.tacka.Opasni_Efekti;
            txbUzrast.Text = this.tacka.Donja_Granica_Uzrasta.ToString();
        }

        private void CTackaUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE TAČKE {tacka.Ime.ToUpper()}";
        }
    }
}
