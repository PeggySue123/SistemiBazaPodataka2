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
    public partial class ZongleriPregledForma : Form
    {
        public ZongleriPregledForma()
        {
            InitializeComponent();
        }
        private void ZonglerPregledForma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
        public void PopuniPodacima()
        {
            ListaZonglera.Items.Clear();
            List<ZonglerBasic> listaZonglera = DTOManager.VratiZonglere();

            foreach (ZonglerBasic a in listaZonglera)
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
                    a.Naziv,
                    a.Broj_Predmeta.ToString()
                });
                ListaZonglera.Items.Add(item);
            }
        }
        private void DodajZonglera_Click(object sender, EventArgs e)
        {
            ZongleriDodajForma formaDodaj = new ZongleriDodajForma();
            formaDodaj.ShowDialog();
            this.PopuniPodacima();
        }
        private void IzmeniZonglera_Click(object sender, EventArgs e)
        {
            if (ListaZonglera.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zonglera koga želite da menjate!");
                return;
            }

            int idZonglera = Int32.Parse(ListaZonglera.SelectedItems[0].SubItems[0].Text);
            ZonglerBasic ob = DTOManager.VratiZonglera(idZonglera);
            ZongleriIzmeniForma formaUpdate = new ZongleriIzmeniForma(ob);
            formaUpdate.ShowDialog();

            this.PopuniPodacima();
        }
        private void ObrisiZonglera_Click(object sender, EventArgs e)
        {
            if (ListaZonglera.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zonglera koga želite da obrišete!");
                return;
            }

            int idZonglera = Int32.Parse(ListaZonglera.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabranog zonglera?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiZongleraIzSistema(idZonglera);
                MessageBox.Show("Brisanje zonglera je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }
    }
}
