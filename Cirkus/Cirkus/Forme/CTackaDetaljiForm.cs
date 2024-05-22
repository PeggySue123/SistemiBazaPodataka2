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
    public partial class CTackaDetaljiForm : Form
    {
        readonly CirkuskaTackaBasic tacka;
        
        public CTackaDetaljiForm()
        {
            InitializeComponent();
        }

        public CTackaDetaljiForm(CirkuskaTackaBasic t)
        {
            InitializeComponent();
            this.tacka = t;
        }

        private void CTackaDetaljiForm_Load(object sender, EventArgs e)
        {
            txbImeTacke.Text = tacka.Ime;

            ListaArtista.Items.Clear();
            List<AngazujeArtistuBasic> artisti = DTOManager.VratiAngazovaneArtiste(this.tacka.Id);

            foreach (AngazujeArtistuBasic a in artisti)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    a.Artista.Id.ToString(),
                    a.Artista.Nadimak,
                    a.Artista.Licno_Ime,
                    a.Artista.Ime_Roditelja,
                    a.Artista.Prezime,
                    a.Artista.Pol.ToString()
                });
                ListaArtista.Items.Add(item);
            }

            ListaZivotinja.Items.Clear();
            //List<ZivotinjaBasic> lista = new List<ZivotinjaBasic>();
            List<AngazujeZivotinjuBasic> zivotinje = DTOManager.VratiAngazovaneZivotinje(this.tacka.Id);
            foreach(AngazujeZivotinjuBasic a in zivotinje)
            {
                //lista.Add(DTOManager.VratiZivotinju(a.Zivotinja.Id));
                ListViewItem item = new ListViewItem(new string[]
                {
                    a.Zivotinja.Id.ToString(),
                    a.Zivotinja.Nadimak,
                    a.Zivotinja.Vrsta,
                    a.Zivotinja.Pol.ToString()
                });
                ListaZivotinja.Items.Add(item);
            }

            /*foreach (ZivotinjaBasic a in zivotinje)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    a.Id.ToString(),
                    a.Nadimak,
                    a.Vrsta,
                    a.Pol.ToString()
                });
                ListaZivotinja.Items.Add(item);
            }*/


            ListaOsoblja.Items.Clear();
            List<ZaduzenBasic> osoblje = DTOManager.VratiZaduzeneOsobe(this.tacka.Id);

            foreach (ZaduzenBasic a in osoblje)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    a.Pomocno_Osoblje.Id.ToString(),
                    a.Pomocno_Osoblje.Licno_Ime,
                    a.Pomocno_Osoblje.Srednje_Slovo,
                    a.Pomocno_Osoblje.Prezime,
                    a.Pomocno_Osoblje.Pol.ToString()
                });
                ListaOsoblja.Items.Add(item);
            }
        }
    }
}
