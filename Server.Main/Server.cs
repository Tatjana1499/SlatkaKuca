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
        public Server()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public bool Start()
        {
            try
            {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            socket.Bind(endPoint);
            socket.Listen(10);
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
                    Socket klijentskiSocket = socket.Accept();
                    ClientHandler handler = new ClientHandler(klijentskiSocket);
                    Thread thread = new Thread(handler.HandleRequest);
                    thread.IsBackground = true;
                    thread.Start();
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