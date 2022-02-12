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
                    Zahtev zahtev = helper.Receive<Zahtev>();
                    Odgovor odgovor = KreirajOdgovor(zahtev);
                    helper.Send(odgovor);
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
                        if(odgovor.Poruka == null)  odgovor.Uspesnost = false;
                        break;
                    case Operacija.Kraj:
                        kraj = true;
                        break;
                    case Operacija.DodajProizvodjaca:
                        odgovor.Poruka = Kontroler.Instanca.DodajProizvodjaca((Proizvodjac)zahtev.Poruka);
                        odgovor.Operacija = Operacija.DodajProizvodjaca;
                        if (odgovor.Poruka == null) odgovor.Uspesnost = false;
                        break;
                    case Operacija.VratiProizvodjace:
                        odgovor.Poruka = Kontroler.Instanca.VratiProizvodjace();
                        odgovor.Operacija = Operacija.VratiProizvodjace;
                        if (odgovor.Poruka == null) odgovor.Uspesnost = false;
                        break;
                    case Operacija.DodajSlatkise:
                        odgovor.Poruka = zahtev.Poruka;
                        odgovor.Operacija = Operacija.DodajSlatkise;
                        Kontroler.Instanca.DodajSlatkise(zahtev.Poruka);
                        break;
                    case Operacija.VratiSlatkise:
                        odgovor.Poruka = Kontroler.Instanca.VratiSlatkise();
                        odgovor.Operacija = Operacija.VratiSlatkise;
                        if (odgovor.Poruka == null) odgovor.Uspesnost = false;
                        break;
                    case Operacija.ObrisiSlatkis:
                        odgovor.Poruka = zahtev.Poruka;
                        odgovor.Uspesnost = Kontroler.Instanca.ObrisiSlatkis((Slatkis)zahtev.Poruka);
                        odgovor.Operacija = Operacija.ObrisiSlatkis;
                        break;
                    case Operacija.DodajPrMesto:
                        odgovor.Poruka = zahtev.Poruka;
                        odgovor.Operacija = Operacija.DodajPrMesto;
                        Kontroler.Instanca.DodajPrMesto((ProdajnoMesto)zahtev.Poruka);
                        break;
                    case Operacija.IzmeniSlatkis:
                        odgovor.Poruka = zahtev.Poruka;
                        odgovor.Operacija = Operacija.IzmeniSlatkis;
                        Kontroler.Instanca.IzmeniSlatkis((Slatkis)zahtev.Poruka);
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