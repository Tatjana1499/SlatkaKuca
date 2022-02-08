using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForms.GUIKontroler
{
    public class PrijavaKontroler
    {
        public void Prijava(FrmPrijava frmPrijava)
        {
            if (!Validacija(frmPrijava)) return;
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.Prijava,
                    Poruka = new User
                    {
                        KorisnickoIme = frmPrijava.TxtKorIme.Text,
                        KorisnickaSifra = frmPrijava.TxtSifra.Text
                    }
                };
                Communication.Instanca.Connect();
                Communication.Instanca.SendRequest(zahtev);
                Odgovor odgovor = Communication.Instanca.GetResult<Odgovor>();
                Sesija.Instanca.User = (User)odgovor.Poruka;

                if (Sesija.Instanca.User != null)
                {
                    MessageBox.Show($"Uspešna prijava, {Sesija.Instanca.User.Ime} {Sesija.Instanca.User.Prezime}!");
                    frmPrijava.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Korisnik ne postoji!");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Greska pri radu sa serverom.");
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