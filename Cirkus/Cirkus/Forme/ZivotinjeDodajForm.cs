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
    public partial class ZivotinjeDodajForm : Form
    {
        ZivotinjaBasic zivotinja;
        public ZivotinjeDodajForm()
        {
            InitializeComponent();
            zivotinja = new ZivotinjaBasic();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novu životinju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                if(txbPol.Text.Length>1)
                {
                    MessageBox.Show("U polje za unos pola unesite m ili z!");
                    ZivotinjeDodajForm forma = new ZivotinjeDodajForm();
                    forma.ShowDialog();
                }
                else
                {
                    this.zivotinja.Nadimak = txbNadimak.Text;
                    this.zivotinja.Vrsta = txbVrsta.Text;
                    this.zivotinja.Pol = char.Parse(txbPol.Text);
                    this.zivotinja.Starost = Int32.Parse(txbStarost.Text);
                    this.zivotinja.Vreme_Boravka = Int32.Parse(txbVremeBoravka.Text);
                    this.zivotinja.Datum_Veterinarskog_Pregleda = datVetPregleda.Value;
                    this.zivotinja.Broj_Kaveza = Int32.Parse(txbBrKaveza.Text);
                    this.zivotinja.Tezina = Int32.Parse(txbTezina.Text);
                    this.zivotinja.Direktor = DTOManager.VratiDirektora(Int32.Parse(txbDirektor.Text));
                    this.zivotinja.Dreser = DTOManager.VratiDresera(Int32.Parse(txbDreser.Text));
                    this.zivotinja.DreserId = Int32.Parse(txbDreser.Text);
                    this.zivotinja.DirektorId = Int32.Parse(txbDirektor.Text);

                    DTOManager.DodajZivotinju(this.zivotinja);
                    MessageBox.Show("Uspešno ste dodali novu životinju!");
                    this.Close();
                }
            }
            else
            {

            }
        }
    }
}
