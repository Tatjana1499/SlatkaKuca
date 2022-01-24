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

namespace ClientForms
{
    public partial class FrmPrijava : Form
    {
        private PrijavaKontroler prijavaKontroler;
        public FrmPrijava()
        {
            InitializeComponent();
            prijavaKontroler = new PrijavaKontroler();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            prijavaKontroler.Prijava(this);
            
        }

        private void txtKorIme_Click(object sender, EventArgs e)
        {
            txtKorIme.BackColor = Color.White;
        }
        private void txtSifra_Click(object sender, EventArgs e)
        {
            txtSifra.BackColor = Color.White;
        }
    }
}
