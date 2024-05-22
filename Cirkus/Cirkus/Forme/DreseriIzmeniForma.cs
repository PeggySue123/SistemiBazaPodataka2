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
    public partial class DreseriIzmeniForma : Form
    {
        readonly DreseriBasic dreser;
        public DreseriIzmeniForma()
        {
            InitializeComponent();
        }
        public DreseriIzmeniForma(DreseriBasic dr)
        {
            InitializeComponent();
            dreser = dr;
        }
        private void Izmeni_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izmenite informacije o dreseru?";
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
                this.dreser.Maticni_Broj = txtMaticniBroj.Text;
                this.dreser.Pocetak_Rada = dtPocetakRada.Value;
                this.dreser.Pol = char.Parse(clbPol.CheckedItems[0].ToString());

                DTOManager.AzurirajDresera(this.dreser);
                MessageBox.Show("Ažuriranje dresera je uspešno izvršeno!");
                this.Close();
            }
        }
        public void PopuniPodacima()
        {
            txtLicnoIme.Text = dreser.Licno_Ime;
            txtPrezime.Text = dreser.Prezime;
            txtImeRoditelja.Text = dreser.Ime_Roditelja;
            txtNadimak.Text = dreser.Nadimak;
            dtDatumRodjenja.Value = dreser.Datum_Rodjenja;
            txtMestoRodjenja.Text = dreser.Mesto_Rodjenja;
            txtMaticniBroj.Text = dreser.Maticni_Broj;
            dtPocetakRada.Value = dreser.Pocetak_Rada;
        }
        private void DreseriIzmeni_Load(object sender, EventArgs e)
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
