using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Zahtev
    {
        public Operacija Operacija { get; set; }
        public Object Poruka { get; set; }
        public bool Uspesnost { get; set; }
    }
}