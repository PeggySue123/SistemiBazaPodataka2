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
    public partial class AkrobataViseForma : Form
    {
        readonly AkrobataBasic Akrobata;
        public AkrobataViseForma()
        {
            InitializeComponent();
        }
        public AkrobataViseForma(AkrobataBasic a)
        {
            InitializeComponent();
            Akrobata = a;
        }
        public void PopuniPodacima()
        {
            ListaVestina.Clear();
            ListaVestina.Columns.Add(new ColumnHeader() { Text = "Id" });
            ListaVestina.Columns.Add(new ColumnHeader() { Text = "Naziv veštine" });
            ListaVestina.Columns.Add(new ColumnHeader() { Text = "Broj godina" });
            List<VestinaBasic> vestine = DTOManager.VratiVestine(this.Akrobata.Id);
            foreach(VestinaBasic v in vestine)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    v.Id.ToString(),
                    v.Naziv,
                    v.Broj_Godina.ToString()
                });
                ListaVestina.Items.Add(item);
            }
            txtAkrobata.Text = Akrobata.Nadimak;
        }
        private void AkrobataVise_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
        private void DodajVestinu_Click(object sender, EventArgs e)
        {
            VestinaDodajForma formaDodaj = new VestinaDodajForma(Akrobata.Id);
            formaDodaj.ShowDialog();
            this.PopuniPodacima();
        }
        private void IzmeniVestinu_Click(object sender, EventArgs e)
        {
            if (ListaVestina.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vestinu koju želite da menjate!");
                return;
            }

            int idVestine = Int32.Parse(ListaVestina.SelectedItems[0].SubItems[0].Text);
            VestinaBasic ob = DTOManager.AzurirajVestinu(DTOManager.VratiVestinu(idVestine));
            VestinaIzmeniForma formaUpdate = new VestinaIzmeniForma(ob);
            formaUpdate.ShowDialog();

            this.PopuniPodacima();
        }
        private void ObrisiVestinu_Click(object sender, EventArgs e)
        {
            if (ListaVestina.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite akrobatu koga želite da obrišete!");
                return;
            }

            int idVestine = Int32.Parse(ListaVestina.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabranu vestinu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiVestinu(idVestine);
                MessageBox.Show("Brisanje tačke je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }
    }
}
