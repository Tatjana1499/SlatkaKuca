using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Main
{
    public class Server
    {
        Socket socket;
        List<ClientHandler> clients;
        ClientHandler client;
        public Server()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clients = new List<ClientHandler>();
            ClientHandler.uspesnoPrijavljen += PrijavljenKorisnik;
            ClientHandler.odjavljenKorisnik += OdjaviKorisnika;
        }
        public bool Start()
        {
            try
            {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            socket.Bind(endPoint);
            socket.Listen(5);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }
        public void HandleClient()
        {
            try
            {
                while (true)
                {
                    if (client == null)
                    {
                        Socket klijentskiSocket = socket.Accept();
                        ClientHandler handler = new ClientHandler(klijentskiSocket);
                        clients.Add(handler);
                        Thread thread = new Thread(handler.HandleRequest);
                        thread.IsBackground = true;
                        thread.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public void Stop()
        {
            client.Zatvori();
            client = null;
            socket?.Close();
            socket = null;
        }
        public void PrijavljenKorisnik(Object sender, EventArgs args)
        {
            if(client != null)
            {
                ((ClientHandler)sender).OnemoguciPrijavu();
                return;
            }
            client = (ClientHandler)sender;
            foreach (ClientHandler handler in clients)
            {
                if(handler != client)
                handler.OnemoguciPrijavu();
            }
            clients = new List<ClientHandler>();
        }
        public void OdjaviKorisnika(Object sender, EventArgs args)
        {
            client = null;
        }
    }
}