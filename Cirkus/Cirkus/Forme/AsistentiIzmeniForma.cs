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
    public partial class AsistentiIzmeniForma : Form
    {
        readonly AsistentiBasic asistent;
        public AsistentiIzmeniForma()
        {
            InitializeComponent();
        }
        public AsistentiIzmeniForma(AsistentiBasic ak)
        {
            InitializeComponent();
            asistent = ak;
        }
        private void Izmeni_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izmenite informacije o asistentu?";
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
                    MessageBox.Show("Maticni broj mora da sadrzi 13 karaktera");
                    return;
                }
                this.asistent.Maticni_Broj = txtMaticniBroj.Text;
                this.asistent.Pocetak_Rada = dtPocetakRada.Value;
                this.asistent.Pol = char.Parse(clbPol.CheckedItems[0].ToString());
                this.asistent.Artista_Sa_Asistentima = DTOManager.VratiArtistu(Int32.Parse(txtGlavni.Text));
                this.asistent.Artista_Sa_Asistentima_Id = Int32.Parse(txtGlavni.Text);

                DTOManager.AzurirajAsistenta(this.asistent);
                MessageBox.Show("Ažuriranje asistenta je uspešno izvršeno!");
                this.Close();
            }
        }
        public void PopuniPodacima()
        {
            txtLicnoIme.Text = asistent.Licno_Ime;
            txtPrezime.Text = asistent.Prezime;
            txtImeRoditelja.Text = asistent.Ime_Roditelja;
            txtNadimak.Text = asistent.Nadimak;
            dtDatumRodjenja.Value = asistent.Datum_Rodjenja;
            txtMestoRodjenja.Text = asistent.Mesto_Rodjenja;
            txtMaticniBroj.Text = asistent.Maticni_Broj;
            dtPocetakRada.Value = asistent.Pocetak_Rada;
            txtGlavni.Text = asistent.Artista_Sa_Asistentima_Id.ToString();
        }
        private void AsistentIzmeni_Load(object sender, EventArgs e)
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
