using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForms.GUIKontroler
{
    public class GlavnaKontroler
    {
        public static List<Proizvodjac> proizvodjaci;
        public static List<Slatkis> slatkisi;
        public static EventHandler IzmenjenSlatkis;
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
                            if (!odgovor.Uspesnost)
                                MessageBox.Show("Došlo je do greške, proizvođač nije upamćen.");
                            else
                            {
                                MessageBox.Show("Proizvođač je uspešno upamćen.");
                                if(proizvodjaci != null) proizvodjaci.Add((Proizvodjac)odgovor.Poruka);
                            }
                            break;
                        case Operacija.VratiProizvodjace:
                            proizvodjaci = (List<Proizvodjac>)odgovor.Poruka;
                            break;
                        case Operacija.DodajSlatkise:
                            if(!odgovor.Uspesnost)
                            {
                                MessageBox.Show("Slatkiši nisu dodati.");
                                continue;
                            }
                            MessageBox.Show("Uspešno dodati slatkiši.");
                            if(slatkisi != null) foreach (Slatkis s in (List<Slatkis>)odgovor.Poruka) slatkisi.Add(s);
                            break;
                        case Operacija.VratiSlatkise:
                            slatkisi = (List<Slatkis>)odgovor.Poruka;
                            break;
                        case Operacija.ObrisiSlatkis:
                            if (odgovor.Uspesnost)
                            {
                                MessageBox.Show("Uspešno obrisan slatkiš.");

                                ObrisiSlatkisKontroler.slatkisi = new BindingList<Slatkis>(ObrisiSlatkisKontroler.slatkisi.Where(x => x.SlatkisID != ((Slatkis)odgovor.Poruka).SlatkisID).ToList());
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
                        case Operacija.IzmeniSlatkis:
                            if (odgovor.Uspesnost == false)
                            {
                                MessageBox.Show("Slatkiš nije izmenjen.");
                                continue;
                            }
                            foreach(Slatkis s in slatkisi)
                            {
                                if(s.SlatkisID == ((Slatkis)odgovor.Poruka).SlatkisID)
                                {
                                    s.Naziv = ((Slatkis)odgovor.Poruka).Naziv;
                                    s.Proizvodjac = ((Slatkis)odgovor.Poruka).Proizvodjac;
                                    break;
                                }
                            }
                            IzmenjenSlatkis(null, EventArgs.Empty);
                            MessageBox.Show("Uspesno izmenjen slatkiš.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public static Proizvodjac vratiProizvodjaca(Slatkis s)
        {
            foreach (Proizvodjac proizvodjac in proizvodjaci)
            {
                if (proizvodjac.ProizvodjacID == s.Proizvodjac.ProizvodjacID) return proizvodjac;
            }
            return null;
        }
    }
}