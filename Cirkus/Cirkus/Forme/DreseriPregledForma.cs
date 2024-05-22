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
    public partial class DreseriPregledForma : Form
    {
        public DreseriPregledForma()
        {
            InitializeComponent();
        }
        private void DreseriPregledForma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
        public void PopuniPodacima()
        {
            ListaDresera.Items.Clear();
            List<DreseriBasic> listaDresera = DTOManager.VratiDresere();

            foreach (DreseriBasic a in listaDresera)
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
                ListaDresera.Items.Add(item);
            }
        }
        private void DodajDresera_Click(object sender, EventArgs e)
        {
            DreseriDodajForma formaDodaj = new DreseriDodajForma();
            formaDodaj.ShowDialog();
            this.PopuniPodacima();
        }
        private void IzmeniDresera_Click(object sender, EventArgs e)
        {
            if (ListaDresera.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite dresera koga želite da menjate!");
                return;
            }

            int idDresera = Int32.Parse(ListaDresera.SelectedItems[0].SubItems[0].Text);
            DreseriBasic ob = DTOManager.VratiDresera(idDresera);
            DreseriIzmeniForma formaUpdate = new DreseriIzmeniForma(ob);
            formaUpdate.ShowDialog();

            this.PopuniPodacima();
        }
        private void ObrisiDresera_Click(object sender, EventArgs e)
        {
            if (ListaDresera.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite dresera koga želite da obrišete!");
                return;
            }

            int idDresera = Int32.Parse(ListaDresera.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabranog dresera?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiDreseraIzSistema(idDresera);
                MessageBox.Show("Brisanje dresera je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }
        private void Detalji_Click(object sender, EventArgs e)
        {
            if (ListaDresera.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite dresera kog želite da vidite!");
                return;
            }

            int idDresera = Int32.Parse(ListaDresera.SelectedItems[0].SubItems[0].Text);
            DreseriBasic dreser = DTOManager.VratiDresera(idDresera);

            DreseriViseForma forma = new DreseriViseForma(dreser);
            forma.ShowDialog();
            this.PopuniPodacima();
        }
    }
}
