using ClientForms.GUIKontroler;
using ClientForms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForms
{
    public partial class FrmGlavna : Form
    {
        GlavnaKontroler kontroler;
        public FrmGlavna()
        {
            InitializeComponent();
            kontroler = new GlavnaKontroler();
            Thread thread = new Thread(kontroler.PrimiPoruku);
            thread.IsBackground = true;
            thread.Start();
        }

        private void kreirajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromeniPanel(new UCDodajProizvodjaca());
        }

        private void kreirajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PromeniPanel(new UCDodajSlatkis());
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromeniPanel(new UCPretragaSlatkisa());
        }

        private void brisanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromeniPanel(new UCObrisiSlatkis());
        }

        private void PromeniPanel(UserControl userControl)
        {
            pnlGlavni.Controls.Clear();
            pnlGlavni.Controls.Add(userControl);
        }

        private void FrmGlavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Communication.Instanca.Close();
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>>> FormClosed event >>>>>" + ex.Message);
            }
        }

        private void kreirajToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PromeniPanel(new UCDodajProdajnoMesto());
        }
    }
}