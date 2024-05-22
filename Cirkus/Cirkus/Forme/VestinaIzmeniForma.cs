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
    public partial class VestinaIzmeniForma : Form
    {
        readonly VestinaBasic vestina;
        public VestinaIzmeniForma()
        {
            InitializeComponent();
        }
        public VestinaIzmeniForma(VestinaBasic v)
        {
            InitializeComponent();
            vestina = v;
        }
        public void PopuniPodacima()
        {
            txtBroj.Text = vestina.Broj_Godina.ToString();
            txtNaziv.Text = vestina.Naziv;
        }
        private void Vestina_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
        private void Sacuvaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izmenite informacije o vestini?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.vestina.Naziv = txtNaziv.Text;
                this.vestina.Broj_Godina = Int32.Parse(txtBroj.Text);

                DTOManager.AzurirajVestinu(this.vestina);
                MessageBox.Show("Ažuriranje vestine je uspešno izvršeno!");
                this.Close();
            }
        }
    }
}
