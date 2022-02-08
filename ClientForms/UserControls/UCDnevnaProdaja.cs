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
    }
}
