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
        public Output SendRequestGetResult<Output>(Operacija op, object i = null) where Output : class
        {
            SendRequest(op, i);
            return GetResult<Output>();
        }
        public void SendRequestNoResult(Operacija op, object i)
        {
            SendRequest(op, i);
            GetResult();
        }
        private T GetResult<T>() where T : class
        {
            Odgovor response = helper.Receive<Odgovor>();
            if (response.Uspesnost)
            {
                return (T)response.Poruka;
            }
            else
            {
                throw new Exception();
            }
        }
        private void GetResult()
        {
            Odgovor response = helper.Receive<Odgovor>();
            if (!response.Uspesnost)
            {
                throw new Exception();
            }
        }
        private void SendRequest(Operacija operation, object requestObject = null)
        {
            try
            {
                Zahtev r = new Zahtev
                {
                    Operacija = operation,
                    Poruka = requestObject
                };
                helper.Send(r);
            }
            catch (IOException ex)
            {
                throw new IOException(ex.Message);
            }
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