using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Cirkus.Entiteti;

namespace Cirkus.Forme
{
    public partial class GradForma : Form
    {
        public GradForma()
        {
            InitializeComponent();
        }

        private void GradForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            ListaGradova.Items.Clear();
            List<GradBasic> podaci = DTOManager.VratiSveGradoveBasic();
            
            foreach(GradBasic g in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { g.Id.ToString(), g.Naziv_Drzave.ToString(), g.Naziv_Grada.ToString(), g.Datum_Od.ToString(), g.Datum_Do.ToString(), g.Opis==null ? "/" : g.Opis.ToString() }); ;
                ListaGradova.Items.Add(item);
            }

            ListaGradova.Refresh();
        }
        private void DodajGrad_Click(object sender, EventArgs e)
        {
            GradDodajForm formaDodaj = new GradDodajForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void IzmeniGrad_Click(object sender, EventArgs e)
        {
            if(ListaGradova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite grad koji želite da izmenite.");
                return;
            }

            int idGrada = Int32.Parse(ListaGradova.SelectedItems[0].SubItems[0].Text);
            GradBasic ob = DTOManager.AzurirajGrad(DTOManager.VratiGrad(idGrada));
            GradUpdateForm formaUpdate = new GradUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void ObrisiGrad_Click(object sender, EventArgs e)
        {
            if (ListaGradova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite grad koji želite da obrišete!");
                return;
            }

            int idGrada = Int32.Parse(ListaGradova.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabrani grad?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiGrad(idGrada);
                MessageBox.Show("Brisanje grada je uspešno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}
