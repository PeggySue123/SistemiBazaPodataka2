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
    public partial class ZivotinjeUpdateForm : Form
    {
        ZivotinjaBasic zivotinja;
        public ZivotinjeUpdateForm()
        {
            InitializeComponent();
        }

        public ZivotinjeUpdateForm(ZivotinjaBasic z)
        {
            InitializeComponent();
            this.zivotinja = z;
        }

        private void ZivotinjeUpadateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text= $"AZURIRANJE ŽIVOTINJE {zivotinja.Nadimak.ToUpper()}";
        }

        public void popuniPodacima()
        {
            txbNadimak.Text = this.zivotinja.Nadimak;
            txbVrsta.Text = this.zivotinja.Vrsta;
            txbPol.Text = this.zivotinja.Pol.ToString();
            txbStarost.Text = this.zivotinja.Starost.ToString();
            txbVremeBoravka.Text = this.zivotinja.Vreme_Boravka.ToString();
            datVetPregleda.Value = this.zivotinja.Datum_Veterinarskog_Pregleda;
            txbBrKaveza.Text = this.zivotinja.Broj_Kaveza.ToString();
            txbTezina.Text = this.zivotinja.Tezina.ToString();
        }

        private void Azuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izmenite informacije o životinji?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.zivotinja.Nadimak = txbNadimak.Text;
                this.zivotinja.Vrsta = txbVrsta.Text;
                this.zivotinja.Pol = char.Parse(txbPol.Text);
                this.zivotinja.Starost = Int32.Parse(txbStarost.Text);
                this.zivotinja.Vreme_Boravka = Int32.Parse(txbVremeBoravka.Text);
                this.zivotinja.Datum_Veterinarskog_Pregleda = datVetPregleda.Value;
                this.zivotinja.Broj_Kaveza = Int32.Parse(txbBrKaveza.Text);
                this.zivotinja.Tezina = Int32.Parse(txbTezina.Text);

                DTOManager.AzurirajZivotinju(this.zivotinja);
                MessageBox.Show("Ažuriranje životinje je uspešno izvršeno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
