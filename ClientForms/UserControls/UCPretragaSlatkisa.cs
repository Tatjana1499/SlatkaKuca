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
    public partial class UCPretragaSlatkisa : UserControl
    {
        PretragaSlatkisaKontroler kontroler;
        public UCPretragaSlatkisa()
        {
            InitializeComponent();
          
            kontroler = new PretragaSlatkisaKontroler(this);
            kontroler.InitData();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            kontroler.PretraziSlatkise();
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            kontroler.DetaljiOdabranog();
        }
    }
}
