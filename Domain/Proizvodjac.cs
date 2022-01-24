using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Proizvodjac
    {
        public int ProizvodjacID { get; set; }
        public string Naziv { get; set; }

        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Mesto { get; set; }
    }
}