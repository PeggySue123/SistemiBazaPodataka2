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
    public partial class DirektorDodajForm : Form
    {
        readonly DirektorBasic direktor;
        public DirektorDodajForm()
        {
            InitializeComponent();
            direktor = new DirektorBasic();
        }


        private void DodajDirektora_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novog direktora?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.direktor.Licno_Ime = txbIme.Text;
                this.direktor.Srednje_Slovo = txbSSlovo.Text;
                this.direktor.Prezime = txbPrezime.Text;

                DTOManager.DodajDirektora(this.direktor);
                MessageBox.Show("Uspešno ste dodali novog direktora!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
