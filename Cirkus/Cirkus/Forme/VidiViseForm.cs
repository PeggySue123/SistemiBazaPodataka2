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
    public partial class VidiViseForm : Form
    {
        readonly DirektorBasic direktor;
        public VidiViseForm()
        {
            InitializeComponent();
        }

        public VidiViseForm(DirektorBasic d)
        {
            InitializeComponent();
            this.direktor = d;
        }

        private void VidiViseForm_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        public void PopuniPodacima()
        {
            ListaMejlova.Items.Clear();
            ListaBrojeva.Items.Clear();
            List<EmailDirektoraPregled> mejlovi = (List<EmailDirektoraPregled>)DTOManager.VratiEmailoveDirektora(this.direktor.Id);
            List<TelefonDirektoraPregled> telefoni = (List<TelefonDirektoraPregled>)DTOManager.VratiTelefoneDirektora(this.direktor.Id);
            foreach(EmailDirektoraPregled m in mejlovi)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    m.Id.ToString(),
                    m.Email
                });
                ListaMejlova.Items.Add(item);
            }

            foreach(TelefonDirektoraPregled t in telefoni)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    t.Id.ToString(),
                    t.Broj_Telefona
                });
                ListaBrojeva.Items.Add(item);
            }
        }

        private void DodajMail_Click(object sender, EventArgs e)
        {
            EMailDodajForm form = new EMailDodajForm();
            form.ShowDialog();
            this.PopuniPodacima();
        }

        private void ObrisiMail_Click(object sender, EventArgs e)
        {
            if (ListaMejlova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite mejl koji želite da obrišete!");
                return;
            }

            int idMejl = Int32.Parse(ListaMejlova.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabrani mejl?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiEmail(idMejl);
                MessageBox.Show("Brisanje mejla je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }

        private void DodajBroj_Click(object sender, EventArgs e)
        {
            TelefonDirektoraDodajForm forma = new TelefonDirektoraDodajForm(this.direktor.Id);
            forma.ShowDialog();
            this.PopuniPodacima();
        }

        private void ObrisiBroj_Click(object sender, EventArgs e)
        {
            if (ListaBrojeva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite broj koji želite da obrišete!");
                return;
            }

            int idBr = Int32.Parse(ListaBrojeva.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabrani broj?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiTelefon(idBr);
                MessageBox.Show("Brisanje broja telefona je uspešno obavljeno!");
                this.PopuniPodacima();
            }
        }
    }
}
