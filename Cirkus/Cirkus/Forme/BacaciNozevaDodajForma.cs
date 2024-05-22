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
    public partial class BacaciNozevaDodajForma : Form
    {
        readonly BacaciNozevaBasic bacac;
        public BacaciNozevaDodajForma()
        {
            InitializeComponent();
            bacac = new BacaciNozevaBasic();
        }
        private void BacacDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novog bacaca nozeva?";
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
                List<ArtistaBasic> lista = DTOManager.VratiSveArtisteBasic();
                foreach (ArtistaBasic a in lista)
                {
                    if (a.Maticni_Broj == txtMaticniBroj.Text)
                    {
                        MessageBox.Show("Već postoji artista sa ovim matičnim brojem!");
                        return;
                    }
                }
                this.bacac.Maticni_Broj = txtMaticniBroj.Text;
                this.bacac.Pocetak_Rada = dtPocetakRada.Value;
                this.bacac.Pol = char.Parse(clbPol.CheckedItems[0].ToString());
                this.bacac.Direktor = DTOManager.VratiDirektora(Int32.Parse(txbIdDirektora.Text));
                this.bacac.DirektorId = Int32.Parse(txbIdDirektora.Text);

                DTOManager.SacuvajBacacaNozeva(this.bacac);
                MessageBox.Show("Uspešno ste dodali novog bacaca nozeva!");
                this.Close();
            }
        }
        private void Pol_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int item = 0; item < clbPol.Items.Count; ++item)
                if (item != e.Index) clbPol.SetItemChecked(item, false);
        }
    }
}
