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
    public partial class ZongleriDodajForma : Form
    {
        readonly ZonglerBasic zongler;
        public ZongleriDodajForma()
        {
            InitializeComponent();
            zongler = new ZonglerBasic();
        }
        private void ZonglerDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novog asistenta?";
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
                this.zongler.Maticni_Broj = txtMaticniBroj.Text;
                this.zongler.Pocetak_Rada = dtPocetakRada.Value;
                this.zongler.Pol = char.Parse(clbPol.CheckedItems[0].ToString());
                this.zongler.Naziv = txtPredmet.Text;
                this.zongler.Broj_Predmeta = Int32.Parse(txtBroj.Text);
                this.zongler.Direktor = DTOManager.VratiDirektora(Int32.Parse(txbIdDirektora.Text));
                this.zongler.DirektorId = Int32.Parse(txbIdDirektora.Text);

                DTOManager.SacuvajZonglera(this.zongler);
                MessageBox.Show("Uspešno ste dodali novog žonglera!");
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
