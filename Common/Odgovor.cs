using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Odgovor
    {
        public string Greska { get; set; }
        public bool Uspesnost { get; set; } = true;
        public Object Poruka { get; set; }
        public Operacija Operacija { get; set; }
    }
}