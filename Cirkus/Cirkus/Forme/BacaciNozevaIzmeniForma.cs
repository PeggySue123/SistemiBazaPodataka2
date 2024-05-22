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
    public partial class BacaciNozevaIzmeniForma : Form
    {
        readonly BacaciNozevaBasic bacac;
        public BacaciNozevaIzmeniForma()
        {
            InitializeComponent();
        }
        public BacaciNozevaIzmeniForma(BacaciNozevaBasic bn)
        {
            InitializeComponent();
            bacac = bn;
        }
        private void Izmeni_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izmenite informacije o bacacu nozeva?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.bacac.Licno_Ime = txtLicnoIme.Text;
                this.bacac.Prezime = txtPrezime.Text;
                this.bacac.Ime_Roditelja = txtImeRoditelja.Text;
                this.bacac.Nadimak = txtNadimak.Text;
                this.bacac.Datum_Rodjenja = dtDatumRodjenja.Value;
                this.bacac.Mesto_Rodjenja = txtMestoRodjenja.Text;
                if (txtMaticniBroj.Text.Length < 13)
                {
                    MessageBox.Show("Maticni broj mora da sadrzi 13 karaktera");
                    return;
                }
                this.bacac.Maticni_Broj = txtMaticniBroj.Text;
                this.bacac.Pocetak_Rada = dtPocetakRada.Value;
                this.bacac.Pol = char.Parse(clbPol.CheckedItems[0].ToString());

                DTOManager.AzurirajBacacaNozeva(this.bacac);
                MessageBox.Show("Ažuriranje dresera je uspešno izvršeno!");
                this.Close();
            }
        }
        public void PopuniPodacima()
        {
            txtLicnoIme.Text = bacac.Licno_Ime;
            txtPrezime.Text = bacac.Prezime;
            txtImeRoditelja.Text = bacac.Ime_Roditelja;
            txtNadimak.Text = bacac.Nadimak;
            dtDatumRodjenja.Value = bacac.Datum_Rodjenja;
            txtMestoRodjenja.Text = bacac.Mesto_Rodjenja;
            txtMaticniBroj.Text = bacac.Maticni_Broj;
            dtPocetakRada.Value = bacac.Pocetak_Rada;
        }
        private void BacacIzmeni_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
        private void Pol_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int item = 0; item < clbPol.Items.Count; ++item)
                if (item != e.Index) clbPol.SetItemChecked(item, false);
        }
    }
}
