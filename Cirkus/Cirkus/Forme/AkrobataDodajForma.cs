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
    public partial class AkrobataDodajForma : Form
    {
        readonly AkrobataBasic akrobata;
        public AkrobataDodajForma()
        {
            InitializeComponent();
            akrobata = new AkrobataBasic();
        }
        private void AkrobataDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novog akrobatu?";
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
                if (txtMaticniBroj.Text.Length < 13 || txtMaticniBroj.Text.Length>13)
                {
                    MessageBox.Show("Matični broj mora da sadrži 13 karaktera");
                    return;
                }
                List<ArtistaBasic> lista = DTOManager.VratiSveArtisteBasic();
                foreach(ArtistaBasic a in lista)
                {
                    if(a.Maticni_Broj==txtMaticniBroj.Text)
                    {
                        MessageBox.Show("Već postoji artista sa ovim matičnim brojem!");
                        return;
                    }    
                }
                this.akrobata.Maticni_Broj = txtMaticniBroj.Text;
                this.akrobata.Pocetak_Rada = dtPocetakRada.Value;
                this.akrobata.Pol = char.Parse(clbPol.CheckedItems[0].ToString());
                this.akrobata.Direktor = DTOManager.VratiDirektora(Int32.Parse(txbIdDirektora.Text));
                this.akrobata.DirektorId = Int32.Parse(txbIdDirektora.Text);

                DTOManager.SacuvajAkrobatu(this.akrobata);
                MessageBox.Show("Uspešno ste dodali novog akrobatu!");
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
