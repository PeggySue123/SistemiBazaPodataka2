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
    public partial class DreseriForma : Form
    {
        ZivotinjaBasic zivotinja;
        public DreseriForma()
        {
            InitializeComponent();
        }
        public DreseriForma(ZivotinjaBasic z)
        {
            InitializeComponent();
            this.zivotinja = z;
        }
        private void Dreseri_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            txbNadimak.Text = this.zivotinja.Nadimak;
            txbVrsta.Text = this.zivotinja.Vrsta;
            txbDreser.Text = DTOManager.VratiDresera(this.zivotinja.DreserId).Licno_Ime;
        }
    }
}
