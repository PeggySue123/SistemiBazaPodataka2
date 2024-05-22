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
    public partial class AkrobatePregledForma : Form
    {
        public AkrobatePregledForma()
        {
            InitializeComponent();
        }
        private void AkrobataPregledForma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
        public void PopuniPodacima()
        {
            ListaAkrobata.Items.Clear();
            List<AkrobataBasic> listaAkrobata = DTOManager.VratiAkrobate();

            foreach (AkrobataBasic a in listaAkrobata)
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
                ListaAkrobata.Items.Add(item);
            }
        }
        private void DodajAkrobatu_Click(object sender, EventArgs e)
        {
            AkrobataDodajForma formaDodaj = new AkrobataDodajForma();
            formaDodaj.ShowDialog();
            this.PopuniPodacima();
        }
        private void IzmeniAkrobatu_Click(object sender, EventArgs e)
        {
            if (ListaAkrobata.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite akrobatu koga želite da menjate!");
                return;
            }

            int idAkrobate = Int32.Parse(ListaAkrobata.SelectedItems[0].SubItems[0].Text);
            AkrobataBasic ob = DTOManager.VratiAkrobatu(idAkrobate);
            AkrobataIzmeniForma formaUpdate = new AkrobataIzmeniForma(ob);
            formaUpdate.ShowDialog();

            this.PopuniPodacima();
        }
        private void ObrisiAkrobatu_Click(object sender, EventArgs e)
        {
            if (ListaAkrobata.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite akrobatu koga želite da obrišete!");
                return;
            }

            int idAkrobate = Int32.Parse(ListaAkrobata.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabranog akrobatu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiAkrobatuIzSistema(idAkrobate);
                MessageBox.Show("Brisanje akrobate je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }
        private void Detalji_Click(object sender, EventArgs e)
        {
            if (ListaAkrobata.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite akrobatu kog želite da vidite!");
                return;
            }

            int idAkrobate = Int32.Parse(ListaAkrobata.SelectedItems[0].SubItems[0].Text);
            AkrobataBasic akrobata = DTOManager.VratiAkrobatu(idAkrobate);

            AkrobataViseForma forma = new AkrobataViseForma(akrobata);
            forma.ShowDialog();
            this.PopuniPodacima();
        }
    }
}
