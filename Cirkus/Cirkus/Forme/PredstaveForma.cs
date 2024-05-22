using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cirkus.Forme
{
    public partial class PredstaveForma : Form
    {
        public PredstaveForma()
        {
            InitializeComponent();
        }

        public int brPredstava = 0;
        public CheckBox last_checked = null;

        private void PredstaveForma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        public void PopuniPodacima()
        {
            this.brPredstava = 0;
            ListaRedovne.Items.Clear();
            ListaHumanitarne.Items.Clear();
            ListaNarucene.Items.Clear();
            List<RedovnaPredstavaBasic> redovne = DTOManager.VratiRedovnePredstave();
            List<HumanitarnaPredstavaBasic> humanitarne = DTOManager.VratiHumanitarnePredstave();
            List<NarucenaPredstavaBasic> narucene = DTOManager.VratiNarucenePredstave();


            foreach (RedovnaPredstavaBasic p in redovne)
            {
                //String tip = p.Razlog_Organizovanja == null ? "Redovna" : (p.Razlog_Organizovanja == 1 ? "Narucena" : "Humanitarna");
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.Id.ToString()
                });
                ListaRedovne.Items.Add(item);
                this.brPredstava++;
            }

            foreach(HumanitarnaPredstavaBasic h in humanitarne)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    h.Id.ToString(),
                    "humanitarna",
                    h.Prihod.ToString(),
                    h.Namenjen_Prihod
                });
                ListaHumanitarne.Items.Add(item);
                this.brPredstava++;
            }

            foreach (NarucenaPredstavaBasic n in narucene)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    n.Id.ToString(),
                    "naručena",
                    n.Naziv,
                    n.Adresa
                });
                ListaNarucene.Items.Add(item);
                this.brPredstava++;
            }

            txbBrPredst.Text = brPredstava.ToString();
        }

        private void dodajRedovnu_Click(object sender, EventArgs e)
        {
            DTOManager.DodajRedovnuPredstavu();
            this.PopuniPodacima();
        }

        private void obrisiRedovnu_Click(object sender, EventArgs e)
        {

            int idPredstave = Int32.Parse(ListaRedovne.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabranu predstavu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiPredstavu(idPredstave);
                MessageBox.Show("Brisanje predstave je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }

        private void dodajHumanitarnu_Click(object sender, EventArgs e)
        {
            HumanitarnaPredstavaDodajForma forma = new HumanitarnaPredstavaDodajForma();
            forma.ShowDialog();
            this.PopuniPodacima();
        }

        private void izmeniHumanitarnu_Click(object sender, EventArgs e)
        {
            if (ListaHumanitarne.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite humanitarnu predstavu koju želite da menjate!");
                return;
            }

            int idPredstave = Int32.Parse(ListaHumanitarne.SelectedItems[0].SubItems[0].Text);
            HumanitarnaPredstavaBasic ob = DTOManager.VratiHumanitarnuPredstavu(idPredstave);
            HumanitarnaPredstavaIzmeniForma formaUpdate = new HumanitarnaPredstavaIzmeniForma(ob);
            formaUpdate.ShowDialog();

            this.PopuniPodacima();
        }

        private void obrisiHumanitarnu_Click(object sender, EventArgs e)
        {
            int idPredstave = Int32.Parse(ListaHumanitarne.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabranu predstavu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiPredstavu(idPredstave);
                MessageBox.Show("Brisanje predstave je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }

        private void dodajNarucenu_Click(object sender, EventArgs e)
        {
            NarucenaPredstavaDodajForma forma = new NarucenaPredstavaDodajForma();
            forma.ShowDialog();
            this.PopuniPodacima();
        }

        private void izmeniNaruceni_Click(object sender, EventArgs e)
        {
            if (ListaNarucene.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite naručenu predstavu koju želite da menjate!");
                return;
            }

            int idPredstave = Int32.Parse(ListaNarucene.SelectedItems[0].SubItems[0].Text);
            NarucenaPredstavaBasic ob = DTOManager.VratiNarucenuPredstavu(idPredstave);
            NarucenaPredstavaIzmeniForma formaUpdate = new NarucenaPredstavaIzmeniForma(ob);
            formaUpdate.ShowDialog();

            this.PopuniPodacima();

        }

        private void obrisiNarucenu_Click(object sender, EventArgs e)
        {
            int idPredstave = Int32.Parse(ListaNarucene.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabranu predstavu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiPredstavu(idPredstave);
                MessageBox.Show("Brisanje predstave je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }

        private void VidiVise_Click(object sender, EventArgs e)
        {
            if(ListaNarucene.SelectedItems.Count==0)
            {
                MessageBox.Show("Izaberite naručenu predstavu čije inofrmacije želite da vidite!");
                return;
            }
            int idPredstave = Int32.Parse(ListaNarucene.SelectedItems[0].SubItems[0].Text);
            NarucenaPredstavaBasic ob = DTOManager.VratiNarucenuPredstavu(idPredstave);
            NarucenaPredstavaForma forma = new NarucenaPredstavaForma(ob);
            forma.ShowDialog();
            this.PopuniPodacima();
        }
    }
}
