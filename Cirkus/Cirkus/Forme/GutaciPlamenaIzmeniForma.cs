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
    public partial class GutaciPlamenaIzmeniForma : Form
    {
        readonly GutaciPlamenaBasic gutac;
        public GutaciPlamenaIzmeniForma()
        {
            InitializeComponent();
        }
        public GutaciPlamenaIzmeniForma(GutaciPlamenaBasic gp)
        {
            InitializeComponent();
            gutac = gp;
        }
        private void Izmeni_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izmenite informacije o gutacu plamena?";
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
                    MessageBox.Show("Maticni broj mora da sadrzi 13 karaktera");
                    return;
                }
                this.gutac.Maticni_Broj = txtMaticniBroj.Text;
                this.gutac.Pocetak_Rada = dtPocetakRada.Value;
                this.gutac.Pol = char.Parse(clbPol.CheckedItems[0].ToString());

                DTOManager.AzurirajGutacaPlamena(this.gutac);
                MessageBox.Show("Ažuriranje gutaca plamena je uspešno izvršeno!");
                this.Close();
            }
        }
        public void PopuniPodacima()
        {
            txtLicnoIme.Text = gutac.Licno_Ime;
            txtPrezime.Text = gutac.Prezime;
            txtImeRoditelja.Text = gutac.Ime_Roditelja;
            txtNadimak.Text = gutac.Nadimak;
            dtDatumRodjenja.Value = gutac.Datum_Rodjenja;
            txtMestoRodjenja.Text = gutac.Mesto_Rodjenja;
            txtMaticniBroj.Text = gutac.Maticni_Broj;
            dtPocetakRada.Value = gutac.Pocetak_Rada;
        }
        private void GutacIzmeni_Load(object sender, EventArgs e)
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
