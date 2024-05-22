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
    public partial class OsobljeForma : Form
    {
        public OsobljeForma()
        {
            InitializeComponent();
        }

        private void OsobljeForma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        public void PopuniPodacima()
        {
            ListaDirektora.Items.Clear();
            List<DirektorBasic> direktor = DTOManager.VratiSveDirektoreBasic();
            foreach(DirektorBasic d in direktor)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    d.Id.ToString(),
                    d.Licno_Ime,
                    d.Srednje_Slovo,
                    d.Prezime
                });
                ListaDirektora.Items.Add(item);
            }
        }

        private void DodajDirektora_Click(object sender, EventArgs e)
        {
            DirektorDodajForm forma = new DirektorDodajForm();
            forma.ShowDialog();
            this.PopuniPodacima();
        }

        private void IzmeniDirektora_Click(object sender, EventArgs e)
        {
            if (ListaDirektora.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite direktora kog želite da menjate!");
                return;
            }

            int idDir = Int32.Parse(ListaDirektora.SelectedItems[0].SubItems[0].Text);
            DirektorBasic ob = DTOManager.AzurirajDirektora(DTOManager.VratiDirektora(idDir));
            DirektorIzmeniForm formaUpdate = new DirektorIzmeniForm(ob);
            formaUpdate.ShowDialog();

            this.PopuniPodacima();
        }

        private void ObrisiDirektora_Click(object sender, EventArgs e)
        {
            if (ListaDirektora.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite direktora kog želite da obrišete!");
                return;
            }

            int idDir = Int32.Parse(ListaDirektora.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabranog direktora?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiDirektora(idDir);
                MessageBox.Show("Brisanje direktora je uspešno obavljeno!");
                this.PopuniPodacima();
            }
            else
            {

            }
        }

        private void VidiVise_Click(object sender, EventArgs e)
        {
            if (ListaDirektora.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite direktora čije informacije želite da vidite!");
                return;
            }

            int idDir = Int32.Parse(ListaDirektora.SelectedItems[0].SubItems[0].Text);
            DirektorBasic dir = DTOManager.VratiDirektora(idDir);
            VidiViseForm forma = new VidiViseForm(dir);
            forma.ShowDialog();
            this.PopuniPodacima();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PomocnoOsobljeForma forma = new PomocnoOsobljeForma();
            forma.ShowDialog();
            this.PopuniPodacima();
        }
    }
}
