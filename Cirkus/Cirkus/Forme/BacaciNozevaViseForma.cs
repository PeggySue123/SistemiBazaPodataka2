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
    public partial class BacaciNozevaViseForma : Form
    {
        readonly BacaciNozevaBasic bacac;
        public BacaciNozevaViseForma()
        {
            InitializeComponent();
        }
        public BacaciNozevaViseForma(BacaciNozevaBasic bn)
        {
            InitializeComponent();
            bacac = bn;
        }
        public void PopuniPodacima()
        {
            ListaAsistenata.Clear();
            List<AsistentiBasic> asistenti = DTOManager.VratiAsistente(bacac.Id);
            ListaAsistenata.Columns.Add(new ColumnHeader() { Text = "Id" });
            ListaAsistenata.Columns.Add(new ColumnHeader() { Text = "Lično ime" });
            ListaAsistenata.Columns.Add(new ColumnHeader() { Text = "Ime roditelja" });
            ListaAsistenata.Columns.Add(new ColumnHeader() { Text = "Prezime" });
            ListaAsistenata.Columns.Add(new ColumnHeader() { Text = "Nadimak" });
            txtBacacNozeva.Text = bacac.Nadimak;
            foreach (AsistentiBasic asistent in asistenti)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    asistent.Id.ToString(),
                    asistent.Licno_Ime,
                    asistent.Ime_Roditelja,
                    asistent.Prezime,
                    asistent.Nadimak
                });
                ListaAsistenata.Items.Add(item);
            }
        }
        private void BacacVise_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
    }
}
