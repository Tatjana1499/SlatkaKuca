using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForms.GUIKontroler
{
    public class PrijavaKontroler
    {
        internal void Prijava(FrmPrijava frmPrijava)
        {
            if ((string.IsNullOrEmpty(frmPrijava.TxtKorIme.Text) || string.IsNullOrWhiteSpace(frmPrijava.TxtKorIme.Text)) &&              (string.IsNullOrWhiteSpace(frmPrijava.TxtSifra.Text) || string.IsNullOrEmpty(frmPrijava.TxtSifra.Text)))
            {
                frmPrijava.TxtKorIme.BackColor = Color.Salmon;
                frmPrijava.TxtSifra.BackColor = Color.Salmon;
                return;
            }
            if (string.IsNullOrEmpty(frmPrijava.TxtKorIme.Text)  || string.IsNullOrWhiteSpace(frmPrijava.TxtKorIme.Text))
            {
                frmPrijava.TxtKorIme.BackColor = Color.Salmon;
                return;
            }
            if (string.IsNullOrWhiteSpace(frmPrijava.TxtSifra.Text) || string.IsNullOrEmpty(frmPrijava.TxtSifra.Text))
            {
                frmPrijava.TxtSifra.BackColor = Color.Salmon;
                return;
            }

        }






    }
}