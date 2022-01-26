using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientForms
{
    public class Communication
    {


        private Communication instanca;
        public Communication Instanca 
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
            socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            helper = new CommunicationHelper(socket);
        }
        public void Send()
        {
       //     helper.Send();
        }
      










    }
}