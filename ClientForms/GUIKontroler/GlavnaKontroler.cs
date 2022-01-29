using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForms.GUIKontroler
{
    public class GlavnaKontroler
    {
        
        public static List<Proizvodjac> proizvodjaci;
        public static List<Slatkis> odabraniSlatkisi;

        public GlavnaKontroler()
        {
            //PRIMI FORMU
        }
        public void PrimiPoruku()
        {
            Odgovor odgovor = new Odgovor();
            try
            {
                while (true)
                {
                    Object obj = Communication.Instanca.GetResult<Object>();
                    if (obj is Zahtev z)
                    {
                        if(z.Operacija == Operacija.Kraj)
                        {
                            //GASENJE KLIJENTA ZBOG GASENJA SERVERA
                        }
                        return;
                    }
                    else{
                        odgovor = (Odgovor)obj;
                    }

                    switch (odgovor.Operacija) 
                    {
                        case Operacija.Kraj:

                            break;
                        case Operacija.DodajProizvodjaca:
                            if (odgovor == null || !odgovor.Uspesnost)
                            {
                                MessageBox.Show("Došlo je do greške, proizvođač nije upamćen.");
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Proizvođač je uspešno upamćen.");

                            }
                            break;
                        case Operacija.VratiProizvodjace:
                            proizvodjaci = (List<Proizvodjac>)odgovor.Poruka;
                            break;
                        case Operacija.DodajSlatkise:
                            if(odgovor.Uspesnost == false)
                            {
                            MessageBox.Show("Slatkisi nisu dodati.");
                                continue;
                            }
                            MessageBox.Show("Uspesno dodati slatkisi.");
                            break;
                        case Operacija.VratiOdabraneSlatkise:
                            odabraniSlatkisi = (List<Slatkis>)odgovor.Poruka;
                            break;
                        case Operacija.ObrisiSlatkis:
                            if (odgovor.Uspesnost)
                            {
                                MessageBox.Show("Uspešno obrisan slatkiš.");
                                continue;
                            }
                            MessageBox.Show("Slatkiš nije obrisan.");

                            break;
                        case Operacija.DodajPrMesto:
                            if (odgovor.Uspesnost == false)
                            {
                                MessageBox.Show("Prodajno mesto nije dodato.");
                                continue;
                            }
                            MessageBox.Show("Uspesno dodato prodajno mesto.");
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(odgovor.Greska);
            }


        }
    }
}