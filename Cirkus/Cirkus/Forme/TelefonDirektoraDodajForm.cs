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
    public partial class TelefonDirektoraDodajForm : Form
    {
        readonly TelefonDirektoraBasic telefon;
        //DirektorBasic direktor;
        public TelefonDirektoraDodajForm()
        {
            InitializeComponent();
        }

        public TelefonDirektoraDodajForm(int id)
        {
            InitializeComponent();
            telefon = new TelefonDirektoraBasic();
            telefon.Direktor_Id = id;
        }
        private void Dodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novu tačku?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.telefon.Broj_Telefona = textBox1.Text;

                DTOManager.DodajTelefon(telefon);
                MessageBox.Show("Uspešno ste dodali nov broj telefona!");
                this.Close();
            }
        }
    }
}
