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
    public partial class UCDodajProizvodjaca : UserControl
    {
        DodajProizvodjacaKontroler kontroler;
        public UCDodajProizvodjaca()
        {
            InitializeComponent();
            kontroler = new DodajProizvodjacaKontroler(this);
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            kontroler.DodajProizvodjaca();
        }
    }
}