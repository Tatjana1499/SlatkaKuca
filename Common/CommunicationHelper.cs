using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CommunicationHelper
    {
        BinaryFormatter formatter;
        NetworkStream stream;

        public CommunicationHelper(Socket socket)
        {
            formatter = new BinaryFormatter();
            stream = new NetworkStream(socket);
        }
        public void Send<T>(T obj) where T : class
        {
            formatter.Serialize(stream, obj);
        }
        public T Receive<T>(T obj) where T : class
        {
            return (T)formatter.Deserialize(stream);
        }
    }
}