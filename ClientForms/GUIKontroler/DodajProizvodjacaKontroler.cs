using ClientForms.UserControls;
using Common;
using Domain;
using System;
using System.Collections.Generic;
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
                return false;
            }
            return true;
        }
        public void DodajProizvodjaca()
        {
            if (!Validacija())
            {
                MessageBox.Show("Popuni sva polja!");
                return;
            }
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
               // Communication.Instanca.SendRequest(Operacija.DodajProizvodjaca, p);
               
            }
            catch (Exception ex)
            {
                //OBRADI
            }





        }
    }
}