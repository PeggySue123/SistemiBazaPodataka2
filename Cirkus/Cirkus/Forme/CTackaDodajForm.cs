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
    public partial class CTackaDodajForm : Form
    {
        readonly CirkuskaTackaBasic tacka;
        public CTackaDodajForm()
        {
            InitializeComponent();
            tacka = new CirkuskaTackaBasic();
        }

        private void CTackaDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novu tačku?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.tacka.Ime = txbImeTacke.Text;
                this.tacka.Tip = txbTip.Text;
                this.tacka.Opasni_Efekti = txbOpEfekti.Text;
                this.tacka.Donja_Granica_Uzrasta = Int32.Parse(txbUzrast.Text);
                this.tacka.Pripada_Predstavi = DTOManager.VratiPredstavu(Int32.Parse(txbIDPredstave.Text));
                this.tacka.Predstava_Id = Int32.Parse(txbIDPredstave.Text);

                DTOManager.DodajCirkuskuTacku(this.tacka);
                MessageBox.Show("Uspešno ste dodali novu tačku!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
