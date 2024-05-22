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
    public partial class NarucenaPredstavaForma : Form
    {
        readonly NarucenaPredstavaBasic predstava;
        public NarucenaPredstavaForma()
        {
            InitializeComponent();
        }
        public NarucenaPredstavaForma(NarucenaPredstavaBasic p)
        {
            InitializeComponent();
            this.predstava = p;
        }
        private void NarucenaPredstavaForma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
        public void PopuniPodacima()
        {
            lvNarucioc.Clear();
            lvNarucioc.Columns.Add(new ColumnHeader() { Text = "ID" });
            lvNarucioc.Columns.Add(new ColumnHeader() { Text = "Broj telefona" });
            List<TelefonNaruciocaBasic> telefoni = DTOManager.VratiTelefoneNarucioca(this.predstava.Id);
            foreach(TelefonNaruciocaBasic telefon in telefoni)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    telefon.Id.ToString(),
                    telefon.Broj_Telefona
                });
                lvNarucioc.Items.Add(item);
            }
        }
        private void Dodaj_Click(object sender, EventArgs e)
        {
            TelefonNaruciocaDodajForma form = new TelefonNaruciocaDodajForma(this.predstava.Id);
            form.ShowDialog();
            this.PopuniPodacima();
        }
        private void Obrisi_Click(object sender, EventArgs e)
        {
            if (lvNarucioc.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite telefon koji želite da obrišete!");
                return;
            }

            int idTelefon = Int32.Parse(lvNarucioc.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabrani telefon?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiTelefonNarucioca(idTelefon);
                MessageBox.Show("Brisanje telefona je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }
    }
}
