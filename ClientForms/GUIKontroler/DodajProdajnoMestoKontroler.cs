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
    public class DodajProdajnoMestoKontroler
    {
        UCDodajProdajnoMesto uc;
        public DodajProdajnoMestoKontroler(UCDodajProdajnoMesto uc)
        {
            this.uc = uc;
        }
        public void DodajPrMesto()
        {
            if(string.IsNullOrEmpty(uc.TxtNaziv.Text) || string.IsNullOrEmpty(uc.TxtLokacija.Text)|| string.IsNullOrEmpty(uc.TxtRadnoVreme.Text)|| string.IsNullOrEmpty(uc.TxtSajt.Text)||string.IsNullOrWhiteSpace(uc.TxtNaziv.Text) || string.IsNullOrWhiteSpace(uc.TxtLokacija.Text) || string.IsNullOrWhiteSpace(uc.TxtRadnoVreme.Text) || string.IsNullOrWhiteSpace(uc.TxtSajt.Text))
            {
                MessageBox.Show("Popunite sve polja.");
                return;
            }
            Zahtev zahtev = new Zahtev() 
            {
                Operacija = Operacija.DodajPrMesto,
                Poruka = new ProdajnoMesto()
                {
                    Naziv = uc.TxtNaziv.Text,
                    Lokacija = uc.TxtLokacija.Text,
                    RadnoVreme = uc.TxtRadnoVreme.Text,
                    Sajt = uc.TxtSajt.Text,
                }
            };
            Communication.Instanca.SendRequest(zahtev);
        }



    }
}