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
    public partial class DreseriDodajForma : Form
    {
        readonly DreseriBasic dreser;
        public DreseriDodajForma()
        {
            InitializeComponent();
            dreser = new DreseriBasic();
        }
        private void DreserDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novog dresera?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.dreser.Licno_Ime = txtLicnoIme.Text;
                this.dreser.Prezime = txtPrezime.Text;
                this.dreser.Ime_Roditelja = txtImeRoditelja.Text;
                this.dreser.Nadimak = txtNadimak.Text;
                this.dreser.Datum_Rodjenja = dtDatumRodjenja.Value;
                this.dreser.Mesto_Rodjenja = txtMestoRodjenja.Text;
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
                this.dreser.Maticni_Broj = txtMaticniBroj.Text;
                this.dreser.Pocetak_Rada = dtPocetakRada.Value;
                this.dreser.Pol = char.Parse(clbPol.CheckedItems[0].ToString());
                this.dreser.Direktor = DTOManager.VratiDirektora(Int32.Parse(txbIdDirektora.Text));
                this.dreser.DirektorId = Int32.Parse(txbIdDirektora.Text);

                DTOManager.SacuvajDresera(this.dreser);
                MessageBox.Show("Uspešno ste dodali novog dresera!");
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
