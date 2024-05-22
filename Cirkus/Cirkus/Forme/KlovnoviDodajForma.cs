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
    public partial class KlovnoviDodajForma : Form
    {
        readonly KlovnBasic klovn;
        public KlovnoviDodajForma()
        {
            InitializeComponent();
            klovn = new KlovnBasic();
        }
        private void KlovnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novog asistenta?";
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
                if (txtMaticniBroj.Text.Length < 13 || txtMaticniBroj.Text.Length>13)
                {
                    MessageBox.Show("Matični broj mora da sadrži 13 karaktera");
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
                this.klovn.Maticni_Broj = txtMaticniBroj.Text;
                this.klovn.Pocetak_Rada = dtPocetakRada.Value;
                this.klovn.Pol = clbPol.CheckedItems[0].ToString() == "M" ? 'M' : 'Z';
                this.klovn.Tip = cblTip.CheckedItems[0].ToString() == "Smesan" ? 0 : 1;
                this.klovn.Predmet_Za_Zabavu = txtPredmet.Text;
                this.klovn.Direktor = DTOManager.VratiDirektora(Int32.Parse(txbIdDirektora.Text));
                this.klovn.DirektorId = Int32.Parse(txbIdDirektora.Text);

                DTOManager.SacuvajKlovna(this.klovn);
                MessageBox.Show("Uspešno ste dodali novog klovna!");
                this.Close();
            }
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
