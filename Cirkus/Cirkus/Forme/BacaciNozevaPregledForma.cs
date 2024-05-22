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
    public partial class BacaciNozevaPregledForma : Form
    {
        public BacaciNozevaPregledForma()
        {
            InitializeComponent();
        }
        private void BacaciPregledForma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
        public void PopuniPodacima()
        {
            ListaBacaca.Items.Clear();
            List<BacaciNozevaBasic> listaBacaca = DTOManager.VratiBacaceNozeva();

            foreach (BacaciNozevaBasic a in listaBacaca)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    a.Id.ToString(),
                    a.Maticni_Broj,
                    a.Nadimak,
                    a.Licno_Ime,
                    a.Ime_Roditelja,
                    a.Prezime,
                    a.Pocetak_Rada.ToString(),
                    a.Pol.ToString(),
                    a.Mesto_Rodjenja,
                    a.DirektorId.ToString(),
                    a.Datum_Rodjenja.ToString()
                });
                ListaBacaca.Items.Add(item);
            }
        }
        private void DodajBacaca_Click(object sender, EventArgs e)
        {
            BacaciNozevaDodajForma formaDodaj = new BacaciNozevaDodajForma();
            formaDodaj.ShowDialog();
            this.PopuniPodacima();
        }
        private void BacaciNozevaIzmena_Click(object sender, EventArgs e)
        {
            if (ListaBacaca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite dresera koga želite da menjate!");
                return;
            }

            int idDresera = Int32.Parse(ListaBacaca.SelectedItems[0].SubItems[0].Text);
            BacaciNozevaBasic ob = DTOManager.VratiBacacaNozeva(idDresera);
            BacaciNozevaIzmeniForma formaUpdate = new BacaciNozevaIzmeniForma(ob);
            formaUpdate.ShowDialog();

            this.PopuniPodacima();
        }
        private void ObrisiBacaca_Click(object sender, EventArgs e)
        {
            if (ListaBacaca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite bacaca nozeva koga želite da obrišete!");
                return;
            }

            int idBacaca = Int32.Parse(ListaBacaca.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabranog bacaca nozeva?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiBacacaNozevaIzSistema(idBacaca);
                MessageBox.Show("Brisanje bacaca nozeva je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }
        private void Detalji_Click(object sender, EventArgs e)
        {
            if (ListaBacaca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite bacaca nozeva kog želite da vidite!");
                return;
            }

            int idDresera = Int32.Parse(ListaBacaca.SelectedItems[0].SubItems[0].Text);
            BacaciNozevaBasic bacac = DTOManager.VratiBacacaNozeva(idDresera);

            BacaciNozevaViseForma forma = new BacaciNozevaViseForma(bacac);
            forma.ShowDialog();
            this.PopuniPodacima();
        }
    }
}
