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
    public partial class KlovnoviPregledForma : Form
    {
        public KlovnoviPregledForma()
        {
            InitializeComponent();
        }
        private void KlovnPregledForma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
        public void PopuniPodacima()
        {
            ListaKlovnova.Items.Clear();
            List<KlovnBasic> listaKlovnova = DTOManager.VratiKlovnove();

            foreach (KlovnBasic a in listaKlovnova)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    a.Id.ToString(),
                    a.Maticni_Broj,
                    a.Datum_Rodjenja.ToString(),
                    a.Nadimak,
                    a.Licno_Ime,
                    a.Ime_Roditelja,
                    a.Prezime,
                    a.Pocetak_Rada.ToString(),
                    a.Pol.ToString(),
                    a.Mesto_Rodjenja,
                    a.DirektorId.ToString(),
                    a.Tip.ToString(),
                    a.Predmet_Za_Zabavu
                });
                ListaKlovnova.Items.Add(item);
            }
        }
        private void DodajKlovna_Click(object sender, EventArgs e)
        {
            KlovnoviDodajForma formaDodaj = new KlovnoviDodajForma();
            formaDodaj.ShowDialog();
            this.PopuniPodacima();
        }
        private void IzmeniKlovna_Click(object sender, EventArgs e)
        {
            if (ListaKlovnova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite klovna koga želite da menjate!");
                return;
            }

            int idKlovna = Int32.Parse(ListaKlovnova.SelectedItems[0].SubItems[0].Text);
            KlovnBasic ob = DTOManager.VratiKlovna(idKlovna);
            KlovnoviIzmeniForma formaUpdate = new KlovnoviIzmeniForma(ob);
            formaUpdate.ShowDialog();

            this.PopuniPodacima();
        }
        private void ObrisiKlovna_Click(object sender, EventArgs e)
        {
            if (ListaKlovnova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite klovna koga želite da obrišete!");
                return;
            }

            int idKlovna = Int32.Parse(ListaKlovnova.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabranog klovna?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiKlovnaIzSistema(idKlovna);
                MessageBox.Show("Brisanje Klovna je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }
    }
}
