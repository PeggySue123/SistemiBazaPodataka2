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
    public partial class ZongleriIzmeniForma : Form
    {
        readonly ZonglerBasic zongler;
        public ZongleriIzmeniForma()
        {
            InitializeComponent();
        }
        public ZongleriIzmeniForma(ZonglerBasic ak)
        {
            InitializeComponent();
            zongler = ak;
        }
        private void Izmeni_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izmenite informacije o zongleru?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.zongler.Licno_Ime = txtLicnoIme.Text;
                this.zongler.Prezime = txtPrezime.Text;
                this.zongler.Ime_Roditelja = txtImeRoditelja.Text;
                this.zongler.Nadimak = txtNadimak.Text;
                this.zongler.Datum_Rodjenja = dtDatumRodjenja.Value;
                this.zongler.Mesto_Rodjenja = txtMestoRodjenja.Text;
                if (txtMaticniBroj.Text.Length < 13)
                {
                    MessageBox.Show("Maticni broj mora da sadrzi 13 karaktera");
                    return;
                }
                this.zongler.Maticni_Broj = txtMaticniBroj.Text;
                this.zongler.Pocetak_Rada = dtPocetakRada.Value;
                this.zongler.Pol = char.Parse(clbPol.CheckedItems[0].ToString());
                this.zongler.Naziv = txtPredmet.Text;
                this.zongler.Broj_Predmeta = Int32.Parse(txtBroj.Text);

                DTOManager.AzurirajZonglera(this.zongler);
                MessageBox.Show("Ažuriranje zonglera je uspešno izvršeno!");
                this.Close();
            }
        }
        public void PopuniPodacima()
        {
            txtLicnoIme.Text = zongler.Licno_Ime;
            txtPrezime.Text = zongler.Prezime;
            txtImeRoditelja.Text = zongler.Ime_Roditelja;
            txtNadimak.Text = zongler.Nadimak;
            dtDatumRodjenja.Value = zongler.Datum_Rodjenja;
            txtMestoRodjenja.Text = zongler.Mesto_Rodjenja;
            txtMaticniBroj.Text = zongler.Maticni_Broj;
            dtPocetakRada.Value = zongler.Pocetak_Rada;
            txtBroj.Text = zongler.Broj_Predmeta.ToString();
            txtPredmet.Text = zongler.Naziv;
        }
        private void ZonglerIzmeni_Load(object sender, EventArgs e)
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
