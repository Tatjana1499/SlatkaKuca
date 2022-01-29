using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Pakovanje : IDomenskiObjekat
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

        public string NazivTabele => "Pakovanje";

        public string UbaciVrednosti => $"{PakovanjeID}, '{Naziv}', {Kolicina}, {EnergetskaVrednost}, {Vlakna}, {Secer}, {UgljeniHidrati}, {Proteini}, {Slatkis.SlatkisID}";

        public string UslovIzbacivanja => $"{PakovanjeID} = Id";

        public IDomenskiObjekat ProcitajObjekat(SqlDataReader reader)
        {
            Pakovanje p = new Pakovanje
            {
                PakovanjeID = (int)reader["PakovanjeID"],
                Naziv = (string)reader["Naziv"],
                UgljeniHidrati = (double)reader["UgljeniHidrati"],
                Proteini = (double)reader["Proteini"],
                EnergetskaVrednost = (double)reader["EnergetskaVrednost"],
                Kolicina = (int)reader["Kolicina"],
                Secer = (double)reader["Secer"],
                Vlakna = (double)reader["Vlakna"],
                Slatkis = new Slatkis 
                { 
                    SlatkisID = (int)reader["SlatkisID"]
                }
            };
            return p;
        }
        public override string ToString()
        {
            return $"{Naziv}";
        }
    }
}