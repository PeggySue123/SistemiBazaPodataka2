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
    public partial class AkrobataIzmeniForma : Form
    {
        readonly AkrobataBasic akrobata;
        public AkrobataIzmeniForma()
        {
            InitializeComponent();
        }
        public AkrobataIzmeniForma(AkrobataBasic ak)
        {
            InitializeComponent();
            akrobata = ak;
        }
        private void Izmeni_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izmenite informacije o akrobati?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.akrobata.Licno_Ime = txtLicnoIme.Text;
                this.akrobata.Prezime = txtPrezime.Text;
                this.akrobata.Ime_Roditelja = txtImeRoditelja.Text;
                this.akrobata.Nadimak = txtNadimak.Text;
                this.akrobata.Datum_Rodjenja = dtDatumRodjenja.Value;
                this.akrobata.Mesto_Rodjenja = txtMestoRodjenja.Text;
                if (txtMaticniBroj.Text.Length < 13)
                {
                    MessageBox.Show("Maticni broj mora da sadrzi 13 karaktera");
                    return;
                }
                this.akrobata.Maticni_Broj = txtMaticniBroj.Text;
                this.akrobata.Pocetak_Rada = dtPocetakRada.Value;
                this.akrobata.Pol = char.Parse(clbPol.CheckedItems[0].ToString());

                DTOManager.AzurirajAkrobatu(this.akrobata);
                MessageBox.Show("Ažuriranje akrobate je uspešno izvršeno!");
                this.Close();
            }
        }
        public void PopuniPodacima()
        {
            txtLicnoIme.Text = akrobata.Licno_Ime;
            txtPrezime.Text = akrobata.Prezime;
            txtImeRoditelja.Text = akrobata.Ime_Roditelja;
            txtNadimak.Text = akrobata.Nadimak;
            dtDatumRodjenja.Value = akrobata.Datum_Rodjenja;
            txtMestoRodjenja.Text = akrobata.Mesto_Rodjenja;
            txtMaticniBroj.Text = akrobata.Maticni_Broj;
            dtPocetakRada.Value = akrobata.Pocetak_Rada;
        }
        private void AkrobataIzmeni_Load(object sender, EventArgs e)
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
