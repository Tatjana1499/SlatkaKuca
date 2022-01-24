using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.Main
{
    public class Server
    {
        Socket socket;
        public Server()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public void Start()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            socket.Bind(endPoint);
            socket.Listen(10);
        }
        public void HandleClient()
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSocket = socket.Accept();
                    ClientHandler handler = new ClientHandler();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public void Stop()
        {
            socket?.Close();
        }


    }
}