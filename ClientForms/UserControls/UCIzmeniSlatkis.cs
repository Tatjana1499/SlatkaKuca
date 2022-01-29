using ClientForms.GUIKontroler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForms.UserControls
{
    public partial class UCIzmeniSlatkis : UserControl
    {
        IzmeniSlatkisKontroler kontroler;
        public UCIzmeniSlatkis()
        {
            InitializeComponent();
            kontroler = new IzmeniSlatkisKontroler(this);
            kontroler.InitData();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            kontroler.PrikaziSlatkise();
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            kontroler.IzaberiSlatkis();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            kontroler.IzmeniSlatkis();
        }
    }
}
