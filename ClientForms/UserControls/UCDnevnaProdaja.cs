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
    public partial class UCDnevnaProdaja : UserControl
    {
        UnesiDnevnuProdajuKontroler kontroler;
        public UCDnevnaProdaja()
        {
            InitializeComponent();
            kontroler = new UnesiDnevnuProdajuKontroler(this);
            kontroler.InitData();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            kontroler.PretraziSlatkise();
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            kontroler.UnosDnevnePr();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            kontroler.Unesi();
        }
    }
}
