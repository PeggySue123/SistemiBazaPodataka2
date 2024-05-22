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
    public partial class DreseriViseForma : Form
    {
        readonly DreseriBasic dreser;
        public DreseriViseForma()
        {
            InitializeComponent();
        }
        public DreseriViseForma(DreseriBasic d)
        {
            InitializeComponent();
            dreser = d;
        }
        public void PopuniPodacima()
        {
            ListaAsistenata.Items.Clear();
            ListaZivotinja.Items.Clear();
            ListaAsistenata.Columns.Add(new ColumnHeader() { Text = "Id" });
            ListaAsistenata.Columns.Add(new ColumnHeader() { Text = "Ime" });
            ListaAsistenata.Columns.Add(new ColumnHeader() { Text = "Ime roditelja" });
            ListaAsistenata.Columns.Add(new ColumnHeader() { Text = "Prezime" });
            ListaAsistenata.Columns.Add(new ColumnHeader() { Text = "Nadimak" });

            ListaZivotinja.Columns.Add(new ColumnHeader() { Text = "Id" });
            ListaZivotinja.Columns.Add(new ColumnHeader() { Text = "Nadimak" });
            ListaZivotinja.Columns.Add(new ColumnHeader() { Text = "Vrsta" });
            List<AsistentiBasic> asistenti = DTOManager.VratiAsistente(dreser.Id);
            List<ZivotinjaBasic> zivotinje = DTOManager.VratiZivotinjeDresera(dreser.Id);
            txtDreser.Text = dreser.Nadimak;
            foreach(AsistentiBasic asistent in asistenti)
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
            foreach (ZivotinjaBasic zivotinja in zivotinje)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    zivotinja.Id.ToString(),
                    zivotinja.Nadimak,
                    zivotinja.Vrsta
                });
                ListaZivotinja.Items.Add(item);
            }
        }
        private void DreserVise_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
    }
}
