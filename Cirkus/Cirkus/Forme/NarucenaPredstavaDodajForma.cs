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
    public partial class NarucenaPredstavaDodajForma : Form
    {
        public NarucenaPredstavaDodajForma()
        {
            InitializeComponent();
        }

        public void Sacuvaj_Predstavu_Click(object sender, EventArgs e)
        {
            if (txtIme.Text == null)
            {
                MessageBox.Show("Unesite ime narucioca predstave!");
                return;
            }
            if (txtAdresa.Text == null)
            {
                MessageBox.Show("Unesite adresu narucioca predstave!");
                return;
            }
            DTOManager.DodajNarucenuPredstavu(new NarucenaPredstavaBasic(0, txtIme.Text, txtAdresa.Text));
            this.Close();
        }
    }
}
