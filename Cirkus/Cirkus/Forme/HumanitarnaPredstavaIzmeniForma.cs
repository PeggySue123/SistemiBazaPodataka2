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
    public partial class HumanitarnaPredstavaIzmeniForma : Form
    {
        readonly HumanitarnaPredstavaBasic predstava;
        public HumanitarnaPredstavaIzmeniForma()
        {
            InitializeComponent();
        }

        public HumanitarnaPredstavaIzmeniForma(HumanitarnaPredstavaBasic p)
        {
            InitializeComponent();
            this.predstava = p;
        
        }
        private void IzmeniHumanitarnuPredstavuForm_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
        public void PopuniPodacima()
        {
            this.txtPrihod.Text = predstava.Prihod.ToString();
            this.txtNamenjenPrihod.Text = predstava.Namenjen_Prihod;
        }
        private void Sacuvaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izmenite informacije o humanitarnoj predstavi?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.predstava.Prihod = float.Parse(txtPrihod.Text);
                this.predstava.Namenjen_Prihod = txtNamenjenPrihod.Text;

                DTOManager.AzurirajHumanitarnuPredstavu(this.predstava);
                MessageBox.Show("Uspešno ste izmenili predstavu!");
                this.Close();
            }
        }
    }
}
