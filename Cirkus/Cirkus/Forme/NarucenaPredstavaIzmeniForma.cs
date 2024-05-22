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
    public partial class NarucenaPredstavaIzmeniForma : Form
    {
        readonly NarucenaPredstavaBasic predstava;
        public NarucenaPredstavaIzmeniForma()
        {
            InitializeComponent();
        }
        public NarucenaPredstavaIzmeniForma(NarucenaPredstavaBasic p)
        {
            InitializeComponent();
            this.predstava = p;
        }
        
        public void PopuniPodacima()
        {
            this.txtIme.Text = predstava.Naziv;
            this.txtAdresa.Text = predstava.Adresa;
        }
        private void Sacuvaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izmenite informacije o narucenoj predstavi?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.predstava.Naziv = txtIme.Text;
                this.predstava.Adresa = txtAdresa.Text;

                DTOManager.AzurirajNarucenuPredstavu(this.predstava);
                MessageBox.Show("Uspešno ste izmenili predstavu!");
                this.Close();
            }
            else
            {

            }
        }

        private void NarucenaPredstavaIzmeniForma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
    }
}
