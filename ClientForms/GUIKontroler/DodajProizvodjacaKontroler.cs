using ClientForms.UserControls;
using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForms.GUIKontroler
{
    public class DodajProizvodjacaKontroler
    {
        UCDodajProizvodjaca uC;
        public DodajProizvodjacaKontroler(UCDodajProizvodjaca uCDodaj)
        {
            uC = uCDodaj;
        }
        private bool Validacija()
        {
            if (string.IsNullOrEmpty(uC.TxtEmail.Text) || string.IsNullOrWhiteSpace(uC.TxtEmail.Text) || string.IsNullOrEmpty(uC.TxtMesto.Text) || string.IsNullOrWhiteSpace(uC.TxtMesto.Text) || string.IsNullOrEmpty(uC.TxtNaziv.Text) || string.IsNullOrWhiteSpace(uC.TxtNaziv.Text) || string.IsNullOrEmpty(uC.TxtTelefon.Text) || string.IsNullOrWhiteSpace(uC.TxtTelefon.Text))
            {
                MessageBox.Show("Popuni sva polja!");
                return false;
            }
            if(!uC.TxtEmail.Text.Contains("@") || uC.TxtEmail.Text[0] == '@' || uC.TxtEmail.Text[uC.TxtEmail.Text.Length-1] == '@')
            {
                MessageBox.Show("Neispravan email!");
                return false;
            }
            if (uC.TxtTelefon.Text.Any(x => char.IsLetter(x)))
            {
                MessageBox.Show("Broj telefona ne sme da sadrži slova!");
                return false;
            }
            return true;
        }
        public void DodajProizvodjaca()
        {
            if (!Validacija()) return;
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.DodajProizvodjaca,
                    Poruka = new Proizvodjac()
                    {
                        Email = uC.TxtEmail.Text,
                        Mesto = uC.TxtMesto.Text,
                        Naziv = uC.TxtNaziv.Text,
                        Telefon = uC.TxtTelefon.Text
                    }
                };
                Communication.Instanca.SendRequest(zahtev);
                uC.TxtEmail.Text = "";
                uC.TxtMesto.Text = "";
                uC.TxtNaziv.Text = "";
                uC.TxtTelefon.Text = "";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}