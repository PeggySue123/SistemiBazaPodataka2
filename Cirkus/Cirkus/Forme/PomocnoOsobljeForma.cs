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
    public partial class PomocnoOsobljeForma : Form
    {
        public PomocnoOsobljeForma()
        {
            InitializeComponent();
        }

        private void PomocnoOsobljeForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            ListaPomocnogOsoblja.Items.Clear();
            List<PomocnoOsobljeBasic> osoblje = DTOManager.VratiPomocnoOsobljeBasic();
            foreach (PomocnoOsobljeBasic o in osoblje)
            {
                ListViewItem items = new ListViewItem(new string[]
                {
                    o.Id.ToString(),
                    o.Maticni_Broj,
                    o.Licno_Ime,
                    o.Srednje_Slovo,
                    o.Prezime,
                    o.Pol.ToString(),
                    o.Mesto_Rodjenja,
                    o.Datum_Rodjenja.ToString(),
                    o.Direktor_Id.ToString()
                });
                ListaPomocnogOsoblja.Items.Add(items);
            }
        }

        private void DodajPomOs_Click(object sender, EventArgs e)
        {
            PomocnoOsobljeDodajForm forma = new PomocnoOsobljeDodajForm();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void IzmeniPomOs_Click(object sender, EventArgs e)
        {
            if (ListaPomocnogOsoblja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite osoblje koje želite da menjate!");
                return;
            }

            int idPomOs = Int32.Parse(ListaPomocnogOsoblja.SelectedItems[0].SubItems[0].Text);
            PomocnoOsobljeBasic ob = DTOManager.AzurirajPomocnuOsobu(DTOManager.VratiPomocnuOsobu(idPomOs));
            PomocnoOsobljeIzmeniForm formaUpdate = new PomocnoOsobljeIzmeniForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void ObrisiPomOs_Click(object sender, EventArgs e)
        {
            if (ListaPomocnogOsoblja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite osoblje koje želite da obrišete!");
                return;
            }

            int idPomOs = Int32.Parse(ListaPomocnogOsoblja.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabrano osoblje?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiPomocnuOsobu(idPomOs);
                MessageBox.Show("Brisanje pomoćnog osoblja je uspešno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}
