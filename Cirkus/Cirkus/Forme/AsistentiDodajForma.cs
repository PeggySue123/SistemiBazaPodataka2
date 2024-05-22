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
    public partial class AsistentiDodajForma : Form
    {
        readonly AsistentiBasic asistent;
        public AsistentiDodajForma()
        {
            InitializeComponent();
            asistent = new AsistentiBasic();
        }
        private void AsistentDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novog asistenta?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.asistent.Licno_Ime = txtLicnoIme.Text;
                this.asistent.Prezime = txtPrezime.Text;
                this.asistent.Ime_Roditelja = txtImeRoditelja.Text;
                this.asistent.Nadimak = txtNadimak.Text;
                this.asistent.Datum_Rodjenja = dtDatumRodjenja.Value;
                this.asistent.Mesto_Rodjenja = txtMestoRodjenja.Text;
                if (txtMaticniBroj.Text.Length < 13)
                {
                    MessageBox.Show("Matični broj mora da sadrži 13 karaktera!");
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
                this.asistent.Maticni_Broj = txtMaticniBroj.Text;
                this.asistent.Pocetak_Rada = dtPocetakRada.Value;
                this.asistent.Pol = char.Parse(clbPol.CheckedItems[0].ToString());
                this.asistent.Artista_Sa_Asistentima = DTOManager.VratiArtistu(Int32.Parse(txtGlavni.Text));
                this.asistent.Artista_Sa_Asistentima_Id = Int32.Parse(txtGlavni.Text);
                this.asistent.Direktor = DTOManager.VratiDirektora(Int32.Parse(txbIdDirektora.Text));
                this.asistent.DirektorId = Int32.Parse(txbIdDirektora.Text);

                DTOManager.SacuvajAsistenta(this.asistent);
                MessageBox.Show("Uspešno ste dodali novog asistenta!");
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
