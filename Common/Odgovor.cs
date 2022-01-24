using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Odgovor
    {
        public Operacija Operacija { get; set; }
        public bool Uspesnost { get; set; } = true;
        public Object Poruka { get; set; }
    }
}