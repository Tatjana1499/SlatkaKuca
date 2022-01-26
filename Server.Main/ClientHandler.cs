using Common;
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

        CommunicationHelper helper;
        public ClientHandler(Socket socket)
        {
            helper = new CommunicationHelper(socket);
        }

        public void HandleRequest()
        {
            try
            {
                while (true)
                {
                    Zahtev request = helper.Receive<Zahtev>();
                  //  Odgovor response = CreateResponse(request);
                  //  helper.Send(response);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            finally
            {
               // CloseSocket();
            }
        }



    }
}