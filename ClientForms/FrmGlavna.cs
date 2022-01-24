using ClientForms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForms
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void kreirajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCDodajProizvodjaca dodajProizvodjaca = new UCDodajProizvodjaca();
            pnlGlavni.Controls.Clear();
            pnlGlavni.Controls.Add(dodajProizvodjaca);
        }

        private void kreirajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UCDodajSlatkis dodajSlatkis = new UCDodajSlatkis();
            pnlGlavni.Controls.Clear();
            pnlGlavni.Controls.Add(dodajSlatkis);
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCPretragaSlatkisa pretragaSlatkisa = new UCPretragaSlatkisa();
            pnlGlavni.Controls.Clear();
            pnlGlavni.Controls.Add(pretragaSlatkisa);
        }

        private void brisanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCObrisiSlatkis obrisiSlatkis = new UCObrisiSlatkis();
            pnlGlavni.Controls.Clear();
            pnlGlavni.Controls.Add(obrisiSlatkis);
        }
    }
}
