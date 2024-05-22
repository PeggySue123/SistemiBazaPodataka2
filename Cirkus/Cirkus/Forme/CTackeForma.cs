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
    public partial class CTackeForma : Form
    {
        public CTackeForma()
        {
            InitializeComponent();
        }
        public int brCirkTacaka = 0;
        public CheckBox last_checked = null;
        private void CTackeForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            this.brCirkTacaka = 0;
            ListaCTacaka.Items.Clear();
            List<CirkuskaTackaBasic> listaCTacaka = DTOManager.VratiSveCirkuskeTackeBasic();
            
            foreach(CirkuskaTackaBasic c in listaCTacaka)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    c.Id.ToString(),
                    c.Ime,
                    c.Tip ?? "/",
                    c.Opasni_Efekti ?? "/",
                    c.Donja_Granica_Uzrasta.ToString()
                });
                ListaCTacaka.Items.Add(item);
                this.brCirkTacaka++;
            }
            txbBrCT.Text = brCirkTacaka.ToString();
        }

        private void DodajCTacku_Click(object sender, EventArgs e)
        {
            CTackaDodajForm formaDodaj = new CTackaDodajForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void IzmeniCTacku_Click(object sender, EventArgs e)
        {
            if(ListaCTacaka.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite tačku koju želite da menjate!");
                return;
            }

            int idTacke = Int32.Parse(ListaCTacaka.SelectedItems[0].SubItems[0].Text);
            CirkuskaTackaBasic ob = DTOManager.VratiCirkuskuTacku(idTacke);
            CTackaUpdateForm formaUpdate = new CTackaUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void ObrisiCTacku_Click(object sender, EventArgs e)
        {
            if(ListaCTacaka.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite tačku koju želite da obrišete!");
                return;
            }

            int idTacke = Int32.Parse(ListaCTacaka.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabranu tačku?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiCirkuskuTackuIzSistema(idTacke);
                MessageBox.Show("Brisanje tačke je uspešno obavljeno!");
                this.popuniPodacima();
            }
        }

        private void Detalji_Click(object sender, EventArgs e)
        {
            if (ListaCTacaka.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite tačku koju želite da vidite!");
                return;
            }

            int idTacke = Int32.Parse(ListaCTacaka.SelectedItems[0].SubItems[0].Text);
            CirkuskaTackaBasic ob = DTOManager.VratiCirkuskuTacku(idTacke);

            CTackaDetaljiForm forma = new CTackaDetaljiForm(ob);
            forma.ShowDialog();
            this.popuniPodacima();
        }
    }
}
