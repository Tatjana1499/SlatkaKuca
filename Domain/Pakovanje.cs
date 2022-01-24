using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Pakovanje
    {
        public int PakovanjeID { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public double EnergetskaVrednost { get; set; }
        public double Vlakna { get; set; }
        public double Secer { get; set; }
        public double UgljeniHidrati { get; set; }
        public double Proteini { get; set; }
        public Slatkis Slatkis { get; set; }
    }
}