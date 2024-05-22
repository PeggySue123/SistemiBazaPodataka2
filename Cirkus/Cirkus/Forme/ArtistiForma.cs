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
    public partial class ArtistiForma : Form
    {
        public ArtistiForma()
        {
            InitializeComponent();
        }
        public void PrikaziArtistu_Click(object sender, EventArgs e)
        {
            switch (TipArtiste.Text)
            {
                case "Akrobate": 
                    AkrobatePregledForma formaAkrobate = new AkrobatePregledForma();
                    formaAkrobate.Show();
                    break;
                case "Asistenti":
                    AsistentiPregledForma formaAsistenti = new AsistentiPregledForma();
                    formaAsistenti.Show();
                    break;
                case "Bacaci Nozeva":
                    BacaciNozevaPregledForma formaBacaci = new BacaciNozevaPregledForma();
                    formaBacaci.Show();
                    break;
                case "Dreseri":
                    DreseriPregledForma formaDreseri = new DreseriPregledForma();
                    formaDreseri.Show();
                    break;
                case "Gutaci Plamena":
                    GutaciPlamenaPregledForma formaGutaci = new GutaciPlamenaPregledForma();
                    formaGutaci.Show();
                    break;
                case "Klovnovi":
                    KlovnoviPregledForma formaKlovnovi = new KlovnoviPregledForma();
                    formaKlovnovi.Show();
                    break;
                case "Zongleri":
                    ZongleriPregledForma formaZongleri = new ZongleriPregledForma();
                    formaZongleri.Show();
                    break;
            }
        }
        private void TipArtiste_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int item = 0; item < TipArtiste.Items.Count; ++item)
                if (item != e.Index) TipArtiste.SetItemChecked(item, false);
        }
    }
}
