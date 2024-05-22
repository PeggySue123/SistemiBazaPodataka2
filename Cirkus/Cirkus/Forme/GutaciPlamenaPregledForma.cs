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
    public partial class GutaciPlamenaPregledForma : Form
    {
        public GutaciPlamenaPregledForma()
        {
            InitializeComponent();
        }

        private void GutaciPlamenaPregledForma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        public void PopuniPodacima()
        {
            ListaGutaca.Items.Clear();
            List<GutaciPlamenaBasic> lista = DTOManager.VratiGutacePlamena();

            foreach (GutaciPlamenaBasic a in lista)
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
                    a.DirektorId.ToString()
                });
                ListaGutaca.Items.Add(item);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            GutaciPlamenaDodajForma forma = new GutaciPlamenaDodajForma();
            forma.ShowDialog();
            this.PopuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (ListaGutaca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite gutača plamena kog želite da menjate!");
                return;
            }

            int idGutaca = Int32.Parse(ListaGutaca.SelectedItems[0].SubItems[0].Text);
            GutaciPlamenaBasic ob = DTOManager.VratiGutacaPlamena(idGutaca);
            GutaciPlamenaIzmeniForma formaUpdate = new GutaciPlamenaIzmeniForma(ob);
            formaUpdate.ShowDialog();

            this.PopuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (ListaGutaca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite gutača plamena kog želite da obrišete!");
                return;
            }

            int idGutaca = Int32.Parse(ListaGutaca.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabranog gutača plamena?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiGutacaPlamenaIzSistema(idGutaca);
                MessageBox.Show("Brisanje gutača plamena je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }

        private void btnVise_Click(object sender, EventArgs e)
        {
            if (ListaGutaca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite gutača plamena kog želite da vidite!");
                return;
            }

            int idGutaca = Int32.Parse(ListaGutaca.SelectedItems[0].SubItems[0].Text);
            GutaciPlamenaBasic gutac = DTOManager.VratiGutacaPlamena(idGutaca);

            GutaciPlamenaViseForma forma = new GutaciPlamenaViseForma(gutac);
            forma.ShowDialog();
            this.PopuniPodacima();
        }
    }
}
