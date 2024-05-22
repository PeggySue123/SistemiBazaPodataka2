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
    public partial class PomocnoOsobljeDodajForm : Form
    {
        PomocnoOsobljeBasic osoblje;
        public PomocnoOsobljeDodajForm()
        {
            InitializeComponent();
            osoblje = new PomocnoOsobljeBasic();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novog člana pomoćnog osoblja?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.osoblje.Licno_Ime = txbIme.Text;
                this.osoblje.Srednje_Slovo = txbSSlovo.Text;
                this.osoblje.Prezime = txbPrezime.Text;
                if(txbMatBr.Text.Length<13 || txbMatBr.Text.Length>13)
                {
                    MessageBox.Show("Matični broj mora da sadrži 13 karaktera!");
                    return;
                }
                List<PomocnoOsobljeBasic> lista = DTOManager.VratiPomocnoOsobljeBasic();
                foreach (PomocnoOsobljeBasic a in lista)
                {
                    if (a.Maticni_Broj == txbMatBr.Text)
                    {
                        MessageBox.Show("Već postoji osoba sa ovim matičnim brojem!");
                        return;
                    }
                }
                this.osoblje.Maticni_Broj = txbMatBr.Text;
                this.osoblje.Mesto_Rodjenja = txbMesto.Text;
                this.osoblje.Pol = char.Parse(txbPol.Text);
                this.osoblje.Datum_Rodjenja = datRodj.Value;
                this.osoblje.Direktor_Id = Int32.Parse(txbIdDirektora.Text);

                DTOManager.DodajPomocnuOsobu(this.osoblje);
                MessageBox.Show("Uspešno ste dodali novog člana pomoćnog osoblja!");
                this.Close();
            }
            else
            {

            }
        }

    }
}
