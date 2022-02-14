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
        public static List<ProdajnoMesto> prMesta;
        public static List<Pakovanje> pakovanja;
        public static EventHandler IzmenjenSlatkis;
        public static EventHandler ObrisanSlatkis;
        Form form;

        public GlavnaKontroler(Form form)
        {
            this.form = form;
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
                            form.Invoke(new Action(() =>form.Close()));
                            MessageBox.Show("Server ugašen");
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
                        case Operacija.VratiPakovanja:
                            pakovanja = (List<Pakovanje>)odgovor.Poruka;
                            break;
                        case Operacija.VratiPrMesta:
                            prMesta = (List<ProdajnoMesto>)odgovor.Poruka;
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
                            if (!odgovor.Uspesnost)
                            {
                                MessageBox.Show("Slatkiš nije obrisan.");
                                continue;
                            }
                            MessageBox.Show("Uspešno obrisan slatkiš.");
                            foreach(Slatkis s in slatkisi)
                            {
                                if(s.SlatkisID == ((Slatkis)odgovor.Poruka).SlatkisID)
                                {
                                    slatkisi.Remove(s);
                                    break;
                                }
                            }
                            ObrisanSlatkis(null, EventArgs.Empty);
                            break;
                        case Operacija.DodajPrMesto:
                            if (odgovor.Uspesnost == false)
                            {
                                MessageBox.Show("Prodajno mesto nije dodato.");
                                continue;
                            }
                            MessageBox.Show("Uspešno dodato prodajno mesto.");
                            if (prMesta != null) prMesta.Add((ProdajnoMesto)odgovor.Poruka);
                            break;
                        case Operacija.UnesiDnevnuProdaju:
                            if (odgovor.Uspesnost == false)
                            {
                                MessageBox.Show("Dnevna prodaja nije uneta, ponovljen datum.");
                                continue;
                            }
                            MessageBox.Show("Uspešno uneta dnevna prodaja.");
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
        public void PosaljiKraj()
        {
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.Kraj };
        }
    }
}