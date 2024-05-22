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
    public partial class GutaciPlamenaDodajForma : Form
    {
        readonly GutaciPlamenaBasic gutac;
        public GutaciPlamenaDodajForma()
        {
            InitializeComponent();
            gutac = new GutaciPlamenaBasic();
        }
        private void GutacDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novog gutača plamena?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.gutac.Licno_Ime = txtLicnoIme.Text;
                this.gutac.Prezime = txtPrezime.Text;
                this.gutac.Ime_Roditelja = txtImeRoditelja.Text;
                this.gutac.Nadimak = txtNadimak.Text;
                this.gutac.Datum_Rodjenja = dtDatumRodjenja.Value;
                this.gutac.Mesto_Rodjenja = txtMestoRodjenja.Text;
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
                this.gutac.Maticni_Broj = txtMaticniBroj.Text;
                this.gutac.Pocetak_Rada = dtPocetakRada.Value;
                this.gutac.Pol = char.Parse(clbPol.CheckedItems[0].ToString());
                this.gutac.Direktor = DTOManager.VratiDirektora(Int32.Parse(txbIdDirektora.Text));
                this.gutac.DirektorId = Int32.Parse(txbIdDirektora.Text);

                DTOManager.SacuvajGutacaPlamena(this.gutac);
                MessageBox.Show("Uspešno ste dodali novog gutača plamena!");
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
