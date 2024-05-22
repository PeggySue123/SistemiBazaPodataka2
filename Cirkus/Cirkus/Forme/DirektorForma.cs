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
    public partial class DirektorForma : Form
    {
        ZivotinjaBasic zivotinja;
        public DirektorForma()
        {
            InitializeComponent();
        }
        public DirektorForma(ZivotinjaBasic z)
        {
            InitializeComponent();
            this.zivotinja = z;
        }
        private void DirektorForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            txbNadimak.Text = this.zivotinja.Nadimak;
            txbVrsta.Text = this.zivotinja.Vrsta;
            txbDirektor.Text = DTOManager.VratiDirektora(this.zivotinja.DirektorId).Licno_Ime;
        }
    }
}
