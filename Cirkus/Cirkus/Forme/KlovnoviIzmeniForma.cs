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
    public partial class KlovnoviIzmeniForma : Form
    {
        readonly KlovnBasic klovn;
        public KlovnoviIzmeniForma()
        {
            InitializeComponent();
        }
        public KlovnoviIzmeniForma(KlovnBasic ak)
        {
            InitializeComponent();
            klovn = ak;
        }
        private void Izmeni_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izmenite informacije o asistentu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.klovn.Licno_Ime = txtLicnoIme.Text;
                this.klovn.Prezime = txtPrezime.Text;
                this.klovn.Ime_Roditelja = txtImeRoditelja.Text;
                this.klovn.Nadimak = txtNadimak.Text;
                this.klovn.Datum_Rodjenja = dtDatumRodjenja.Value;
                this.klovn.Mesto_Rodjenja = txtMestoRodjenja.Text;
                if (txtMaticniBroj.Text.Length < 13)
                {
                    MessageBox.Show("Maticni broj mora da sadrzi 13 karaktera");
                    return;
                }
                this.klovn.Maticni_Broj = txtMaticniBroj.Text;
                this.klovn.Pocetak_Rada = dtPocetakRada.Value;
                this.klovn.Pol = char.Parse(clbPol.CheckedItems[0].ToString());
                this.klovn.Tip = cblTip.CheckedItems[0].ToString() == "Smesan" ? 0 : 1;
                this.klovn.Predmet_Za_Zabavu = txtPredmet.Text;

                DTOManager.AzurirajKlovna(this.klovn);
                MessageBox.Show("Ažuriranje klovna je uspešno izvršeno!");
                this.Close();
            }
        }
        public void PopuniPodacima()
        {
            txtLicnoIme.Text = klovn.Licno_Ime;
            txtPrezime.Text = klovn.Prezime;
            txtImeRoditelja.Text = klovn.Ime_Roditelja;
            txtNadimak.Text = klovn.Nadimak;
            dtDatumRodjenja.Value = klovn.Datum_Rodjenja;
            txtMestoRodjenja.Text = klovn.Mesto_Rodjenja;
            txtMaticniBroj.Text = klovn.Maticni_Broj;
            dtPocetakRada.Value = klovn.Pocetak_Rada;
            txtPredmet.Text = klovn.Predmet_Za_Zabavu;
        }
        private void KlovnIzmeni_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
        private void Pol_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int item = 0; item < clbPol.Items.Count; ++item)
                if (item != e.Index) clbPol.SetItemChecked(item, false);
        }
        private void Tip_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int item = 0; item < cblTip.Items.Count; ++item)
                if (item != e.Index) cblTip.SetItemChecked(item, false);
        }
    }
}
