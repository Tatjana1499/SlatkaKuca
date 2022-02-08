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
    public partial class UCDodajSlatkis : UserControl
    {
        DodajSlatkisKontroler kontroler;
        public UCDodajSlatkis()
        {
            InitializeComponent();
            kontroler = new DodajSlatkisKontroler(this);
            kontroler.InitData();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            kontroler.DodajSlatkise();
        }

        private void btnIzbrisiRed_Click(object sender, EventArgs e)
        {
            kontroler.IzbrisiRed();
        }
    }
}