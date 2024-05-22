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
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void Gradovi_Click(object sender, EventArgs e)
        {
            GradForma forma = new GradForma();
            forma.ShowDialog();
        }

        private void Predstave_Click(object sender, EventArgs e)
        {
            PredstaveForma forma = new PredstaveForma();
            forma.ShowDialog();
        }

        private void CirkuskeTacke_Click(object sender, EventArgs e)
        {
            CTackeForma forma = new CTackeForma();
            forma.ShowDialog();
        }

        private void Artisti_Click(object sender, EventArgs e)
        {
            ArtistiForma forma = new ArtistiForma();
            forma.ShowDialog();
        }

        private void Zivotinje_Click(object sender, EventArgs e)
        {
            ZivotinjeForma forma = new ZivotinjeForma();
            forma.ShowDialog();
        }

        private void Osoblje_Click(object sender, EventArgs e)
        {
            OsobljeForma forma = new OsobljeForma();
            forma.ShowDialog();
        }
    }
}
