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
    public partial class DirektorIzmeniForm : Form
    {
        DirektorBasic direktor;
        public DirektorIzmeniForm()
        {
            InitializeComponent();
        }
        public DirektorIzmeniForm(DirektorBasic d)
        {
            InitializeComponent();
            this.direktor = d;
        }
        private void IzmeniDirektora_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izmenite informacije o direktoru?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.direktor.Licno_Ime = txbIme.Text;
                this.direktor.Srednje_Slovo = txbSSlovo.Text;
                this.direktor.Prezime = txbPrezime.Text;

                DTOManager.AzurirajDirektora(this.direktor);
                MessageBox.Show("Uspešno ste izmenili direktora!");
                this.Close();
            }
            else
            {

            }
        }

        public void popuniPodacima()
        {
            txbIme.Text = this.direktor.Licno_Ime;
            txbSSlovo.Text = this.direktor.Srednje_Slovo;
            txbPrezime.Text = this.direktor.Prezime;
        }

        private void DirektorIzmeniForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE DIREKTORA {direktor.Licno_Ime.ToUpper()}";
        }
    }
}
