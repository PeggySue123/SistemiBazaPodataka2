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
    public partial class PomocnoOsobljeIzmeniForm : Form
    {
        readonly PomocnoOsobljeBasic osoblje;
        public PomocnoOsobljeIzmeniForm()
        {
            InitializeComponent();
        }
        public PomocnoOsobljeIzmeniForm(PomocnoOsobljeBasic p)
        {
            InitializeComponent();
            this.osoblje = p;
        }
        public void PopuniPodacima()
        {
            txbIme.Text = this.osoblje.Licno_Ime;
            txbSSlovo.Text = this.osoblje.Srednje_Slovo;
            txbPrezime.Text = this.osoblje.Prezime;
            txbMatBr.Text = this.osoblje.Maticni_Broj;
            txbMesto.Text = this.osoblje.Mesto_Rodjenja;
            txbPol.Text = this.osoblje.Pol.ToString();
            datRodj.Value = (DateTime)(DateTime?)this.osoblje.Datum_Rodjenja;
        }
        private void PomocnoOsobljeIzmeniForm_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
            this.Text = $"AZURIRANJE POMOĆNOG OSOBLJA {osoblje.Licno_Ime.ToUpper()}";
        }

        private void Azuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izmenite informacije o pomoćnom osoblju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.osoblje.Licno_Ime = txbIme.Text;
                this.osoblje.Srednje_Slovo = txbSSlovo.Text;
                this.osoblje.Prezime = txbPrezime.Text;
                this.osoblje.Maticni_Broj = txbMatBr.Text;
                this.osoblje.Mesto_Rodjenja = txbMesto.Text;
                this.osoblje.Pol = char.Parse(txbPol.Text);
                this.osoblje.Datum_Rodjenja = datRodj.Value;

                DTOManager.AzurirajPomocnuOsobu(this.osoblje);
                MessageBox.Show("Uspešno ste izmenili osoblje!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
