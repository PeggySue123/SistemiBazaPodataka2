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
    public partial class TelefonNaruciocaDodajForma : Form
    {
        readonly TelefonNaruciocaBasic telefon;
        public TelefonNaruciocaDodajForma()
        {
            InitializeComponent();
            telefon = new TelefonNaruciocaBasic();
        }
        public TelefonNaruciocaDodajForma(int id)
        {
            InitializeComponent();
            telefon = new TelefonNaruciocaBasic();
            telefon.Narucioc_Predstave_Id = id;
        }
        private void Dodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate nov broj?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.telefon.Broj_Telefona = txtBroj.Text;
                this.telefon.Narucioc_Predstave = DTOManager.VratiNarucenuPredstavu(telefon.Narucioc_Predstave_Id);

                DTOManager.DodajTelefonNarucioca(telefon);
                MessageBox.Show("Uspešno ste dodali nov broj telefona!");
                this.Close();
            }
        }
    }
}
