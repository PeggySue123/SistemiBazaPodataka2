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
    public partial class GutaciPlamenaViseForma : Form
    {
        readonly GutaciPlamenaBasic gutac_plamena;
        public GutaciPlamenaViseForma()
        {
            InitializeComponent();
        }
        public GutaciPlamenaViseForma(GutaciPlamenaBasic gp)
        {
            InitializeComponent();
            gutac_plamena = gp;
        }
        public void PopuniPodacima()
        {
            ListaAsistenata.Clear();
            ListaAsistenata.Columns.Add(new ColumnHeader() { Text = "Id" });
            ListaAsistenata.Columns.Add(new ColumnHeader() { Text = "Ime" });
            ListaAsistenata.Columns.Add(new ColumnHeader() { Text = "Ime roditelja" });
            ListaAsistenata.Columns.Add(new ColumnHeader() { Text = "Prezime" });
            ListaAsistenata.Columns.Add(new ColumnHeader() { Text = "Nadimak" });
            List<AsistentiBasic> asistenti = DTOManager.VratiAsistente(gutac_plamena.Id);
            txtDreser.Text = gutac_plamena.Nadimak;
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
        private void GutacVise_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
    }
}
