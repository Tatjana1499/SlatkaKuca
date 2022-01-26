using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForms.GUIKontroler
{
    public class PrijavaKontroler
    {
        internal void Prijava(FrmPrijava frmPrijava)
        {
            if (!Validacija(frmPrijava)) return;
            try
            {
                User user = new User
                {
                    KorisnickoIme = frmPrijava.TxtKorIme.Text,
                    KorisnickaSifra = frmPrijava.TxtSifra.Text
                };

                Communication.Instanca.Connect();

                Sesija.Instanca.User = Communication.Instanca.SendRequestGetResult<User>(Operacija.Prijava, user);
                if (Sesija.Instanca.User != null)
                {
                    MessageBox.Show($"Uspešna prijava, {Sesija.Instanca.User.Ime} {Sesija.Instanca.User.Prezime}!");
                    frmPrijava.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Koeisnik ne postoji!");
                }
            }
            catch (Exception ex)
            {
                //OBRADI
            }
        }

        public void Osvezi(TextBox text)
        {
            text.BackColor = Color.White;
        }
        public bool Validacija(FrmPrijava frmPrijava)
        {
            bool valid = true;
            if ((string.IsNullOrEmpty(frmPrijava.TxtKorIme.Text) || string.IsNullOrWhiteSpace(frmPrijava.TxtKorIme.Text)) && (string.IsNullOrWhiteSpace(frmPrijava.TxtSifra.Text) || string.IsNullOrEmpty(frmPrijava.TxtSifra.Text)))
            {
                frmPrijava.TxtKorIme.BackColor = Color.Salmon;
                frmPrijava.TxtSifra.BackColor = Color.Salmon;
                valid = false;
            }
            if (string.IsNullOrEmpty(frmPrijava.TxtKorIme.Text) || string.IsNullOrWhiteSpace(frmPrijava.TxtKorIme.Text))
            {
                frmPrijava.TxtKorIme.BackColor = Color.Salmon;
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(frmPrijava.TxtSifra.Text) || string.IsNullOrEmpty(frmPrijava.TxtSifra.Text))
            {
                frmPrijava.TxtSifra.BackColor = Color.Salmon;
                valid = false;
            }
            return valid;
        }
    }
}