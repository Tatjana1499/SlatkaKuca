using Common;
using Domain;
using Server.AplikacionaLogika;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.Main
{
    public class ClientHandler
    {
        Socket socket;
        CommunicationHelper helper;
        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            helper = new CommunicationHelper(socket);
        }

        bool kraj = false;

        public void HandleRequest()
        {
            try
            {
                while (!kraj)
                {
                    Zahtev request = helper.Receive<Zahtev>();
                    Odgovor response = KreirajOdgovor(request);
                    helper.Send(response);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            finally
            {
                CloseSocket();
            }
        }

        public Odgovor KreirajOdgovor(Zahtev zahtev)
        {
            Odgovor odgovor = new Odgovor();
            try
            {
                
                switch (zahtev.Operacija)
                {
                        case Operacija.Prijava:
                            odgovor.Poruka = Kontroler.Instanca.Login((User)zahtev.Poruka);
                            if(odgovor.Poruka == null)
                            {
                                odgovor.Uspesnost = false;
                            odgovor.Greska = "Korisnik ne postoji.";
                            }
                            break;

                        case Operacija.Kraj:
                            kraj = true;

                        break;
                    case Operacija.DodajProizvodjaca:
                        odgovor.Poruka = Kontroler.Instanca.DodajProizvodjaca((Proizvodjac)zahtev.Poruka);
                        odgovor.Operacija = Operacija.DodajProizvodjaca;
                        if (odgovor.Poruka == null)
                        {
                            odgovor.Uspesnost = false;
                            odgovor.Greska = "Proizvodjac nije dodat";
                        }
                        break;
                    case Operacija.VratiProizvodjace:
                        odgovor.Poruka = Kontroler.Instanca.VratiProizvodjace();
                        odgovor.Operacija = Operacija.VratiProizvodjace;
                        if (odgovor.Poruka == null)
                        {
                            odgovor.Uspesnost = false;
                            //poruka o gresci
                        }
                        break;
                    case Operacija.DodajSlatkise:
                        odgovor.Poruka = zahtev.Poruka;
                        odgovor.Operacija = Operacija.DodajSlatkise;
                        Kontroler.Instanca.DodajSlatkise(zahtev.Poruka);
                        break;
                    case Operacija.VratiOdabraneSlatkise:
                        odgovor.Poruka = Kontroler.Instanca.VratiOdabraneSlatkise((Proizvodjac)zahtev.Poruka);
                        odgovor.Operacija = Operacija.VratiOdabraneSlatkise;
                        if (odgovor.Poruka == null)
                        {
                            odgovor.Uspesnost = false;
                            //poruka o gresci
                        }
                        break;
                    case Operacija.ObrisiSlatkis:
                        odgovor.Uspesnost = Kontroler.Instanca.ObrisiSlatkis((Slatkis)zahtev.Poruka);
                        odgovor.Operacija = Operacija.ObrisiSlatkis;
                        if (!odgovor.Uspesnost)
                        {
                            odgovor.Greska = "Slatkis nije obrisan.";
                        }
                        break;
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                odgovor.Uspesnost = false;
                return odgovor;
            }
            return odgovor;
        }


        private object lockobject = new object();
        internal void CloseSocket()
        {
            lock (lockobject)
            {
                if (socket != null)
                {
                    kraj = true;
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    socket = null;
                   // OdjavljenKlijent?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}