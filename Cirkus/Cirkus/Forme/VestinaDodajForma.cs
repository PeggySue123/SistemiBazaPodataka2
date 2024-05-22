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
    public partial class VestinaDodajForma : Form
    {
        public VestinaBasic vestina;
        public VestinaDodajForma()
        {
            InitializeComponent();
        }
        public VestinaDodajForma(int idakrobate)
        {
            InitializeComponent();
            vestina = new VestinaBasic();
            this.vestina.Akrobata = DTOManager.VratiAkrobatu(idakrobate);

            this.vestina.AkrobataId = idakrobate;
        }
        private void Dodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novu vestinu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.vestina.Naziv = txtNaziv.Text;
                this.vestina.Broj_Godina = Int32.Parse(txtBroj.Text);
                

                DTOManager.SacuvajVestinu(this.vestina);
                MessageBox.Show("Uspešno ste dodali novu vestinu!");
                this.Close();
            }
        }
    }
}
