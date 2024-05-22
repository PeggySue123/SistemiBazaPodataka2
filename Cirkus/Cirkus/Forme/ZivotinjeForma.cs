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
    public partial class ZivotinjeForma : Form
    {
        public ZivotinjeForma()
        {
            InitializeComponent();
        }

        private void ZivotinjeForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            ListaZivotinja.Items.Clear();
            List<ZivotinjaBasic> podaci = DTOManager.VratiZivotinje();

            foreach (ZivotinjaBasic z in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] {
                z.Id.ToString(),
                z.Nadimak,
                z.Vrsta,
                z.Pol.ToString(),
                z.Starost.ToString(),
                z.Vreme_Boravka.ToString(),
                z.Datum_Veterinarskog_Pregleda.ToString(),
                z.Broj_Kaveza.ToString(),
                z.Tezina.ToString(),
                z.DreserId.ToString(),
                z.DirektorId.ToString()
                });
                ListaZivotinja.Items.Add(item);
            }
            ListaZivotinja.Refresh();
        }

        private void DodajZivotinju_Click(object sender, EventArgs e)
        {
            ZivotinjeDodajForm forma = new ZivotinjeDodajForm();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void IzmeniZivotinju_Click(object sender, EventArgs e)
        {
            if(ListaZivotinja.SelectedItems.Count==0)
            {
                MessageBox.Show("Izaberite životinju koju želite da izmenite!");
                return;
            }

            int idZivotinje = Int32.Parse(ListaZivotinja.SelectedItems[0].SubItems[0].Text);
            ZivotinjaBasic ob = DTOManager.AzurirajZivotinju(DTOManager.VratiZivotinju(idZivotinje));
            ZivotinjeUpdateForm forma = new ZivotinjeUpdateForm(ob);
            forma.ShowDialog();

            this.popuniPodacima();
        }

        private void ObrisiZivotinju_Click(object sender, EventArgs e)
        {
            if (ListaZivotinja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite životinju koju želite da obrišete!");
                return;
            }

            int idZivotinje = Int32.Parse(ListaZivotinja.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabranu životinju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiZivotinju(idZivotinje);
                MessageBox.Show("Brisanje životinje je uspešno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void Dreseri_Click(object sender, EventArgs e)
        {
            if (ListaZivotinja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite životinju čije detalje želite da vidite!");
                return;
            }

            int idZivotinje = Int32.Parse(ListaZivotinja.SelectedItems[0].SubItems[0].Text);
            DreseriForma forma = new DreseriForma(DTOManager.VratiZivotinju(idZivotinje));
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void Direktor_Click(object sender, EventArgs e)
        {
            if (ListaZivotinja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite životinju čije detalje želite da vidite!");
                return;
            }

            int idZivotinje = Int32.Parse(ListaZivotinja.SelectedItems[0].SubItems[0].Text);
            DirektorForma forma = new DirektorForma(DTOManager.VratiZivotinju(idZivotinje));
            forma.ShowDialog();
            this.popuniPodacima();
        }
    }
}
