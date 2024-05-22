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
    public partial class HumanitarnaPredstavaDodajForma : Form
    {
        HumanitarnaPredstavaBasic p;
        public HumanitarnaPredstavaDodajForma()
        {
            InitializeComponent();
            p = new HumanitarnaPredstavaBasic();
        }

        public void Sacuvaj_Predstavu_Click(object sender, EventArgs e)
        {
            if (txtPrihod.Text == null)
            {
                MessageBox.Show("Unesite prihod predstave!");
                return;
            }
            if (txtNamenjenPrihod.Text == null)
            {
                MessageBox.Show("Unesite kome je namenjen prihod predstave!");
                return;
            }

            p.Prihod = float.Parse(txtPrihod.Text);
            p.Namenjen_Prihod = txtNamenjenPrihod.Text;
            DTOManager.DodajHumanitarnuPredstavu(p);
            this.Close();
        }
    }
}
