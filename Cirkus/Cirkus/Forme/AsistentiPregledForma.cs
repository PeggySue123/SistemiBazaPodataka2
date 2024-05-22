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
    public partial class AsistentiPregledForma : Form
    {
        public AsistentiPregledForma()
        {
            InitializeComponent();
        }
        private void AsistentPregledForma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
        public void PopuniPodacima()
        {
            ListaAsistenata.Items.Clear();
            List<AsistentiBasic> listaAsistenata = DTOManager.VratiSveAsistente();

            foreach (AsistentiBasic a in listaAsistenata)
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
                    a.Artista_Sa_Asistentima_Id.ToString()
                });
                ListaAsistenata.Items.Add(item);
            }
        }
        private void DodajAsistenta_Click(object sender, EventArgs e)
        {
            AsistentiDodajForma formaDodaj = new AsistentiDodajForma();
            formaDodaj.ShowDialog();
            this.PopuniPodacima();
        }
        private void IzmeniAsistenta_Click(object sender, EventArgs e)
        {
            if (ListaAsistenata.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite asistenta koga želite da menjate!");
                return;
            }

            int idAsistenta = Int32.Parse(ListaAsistenata.SelectedItems[0].SubItems[0].Text);
            AsistentiBasic ob = DTOManager.VratiAsistenta(idAsistenta);
            AsistentiIzmeniForma formaUpdate = new AsistentiIzmeniForma(ob);
            formaUpdate.ShowDialog();

            this.PopuniPodacima();
        }
        private void ObrisiAsistenta_Click(object sender, EventArgs e)
        {
            if (ListaAsistenata.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite asistenata koga želite da obrišete!");
                return;
            }

            int idAsistenta = Int32.Parse(ListaAsistenata.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabranog asistenta?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiAsistentaIzSistema(idAsistenta);
                MessageBox.Show("Brisanje asistenta je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }
    }
}
