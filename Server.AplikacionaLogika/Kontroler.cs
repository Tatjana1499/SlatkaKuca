using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.AplikacionaLogika
{
    public class Kontroler
    {
        private static Kontroler instanca;
        public Kontroler Instanca 
        {
            get
            {
                if (instanca == null) instanca = new Kontroler();
                return instanca;
            }
        }
        private Kontroler() { }



    }
}