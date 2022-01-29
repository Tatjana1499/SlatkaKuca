using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientForms
{
    public class Communication
    {
        private static Communication instanca;
        public static Communication Instanca 
        {
            get
            {
                if(instanca == null) instanca = new Communication();
                return instanca;
            }
        }
        private Communication() { }

        Socket socket;

        CommunicationHelper helper;
        public void Connect()
        {
            if (socket == null || !socket.Connected)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);
                helper = new CommunicationHelper(socket);
            }
        }
    
        public T GetResult<T>() where T : class
        {
            T response = helper.Receive<T>();
                return (T)response;
        }

        public void SendRequest<T>(T obj) where T : class
        {
            helper.Send(obj);
        }

        public void Close()
        {
            if (socket == null) return;
            Zahtev request = new Zahtev
            {
                Operacija = Operacija.Kraj,
            };
            helper.Send(request);

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            socket = null;
        }
    }
}