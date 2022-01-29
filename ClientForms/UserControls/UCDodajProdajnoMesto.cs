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
    public partial class UCDodajProdajnoMesto : UserControl
    {
        DodajProdajnoMestoKontroler kontroler;
        public UCDodajProdajnoMesto()
        {
            InitializeComponent();
            kontroler = new DodajProdajnoMestoKontroler(this);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            kontroler.DodajPrMesto();
        }
    }
}
