using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Proizvodjac : IDomenskiObjekat
    {
        public int ProizvodjacID { get; set; }
        public string Naziv { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Mesto { get; set; }

        public string NazivTabele => "Proizvodjac";
     
        public string UbaciVrednosti => $"{ProizvodjacID}, '{Naziv}', '{Email}', '{Telefon}', '{Mesto}'";

        public IDomenskiObjekat ProcitajObjekat(SqlDataReader reader)
        {
            Proizvodjac p = new Proizvodjac
            {
                ProizvodjacID = (int)reader["ProizvodjacID"],
                Naziv = (string)reader["Naziv"],
                Email = (string)reader["Email"],
                Telefon = (string)reader["Telefon"],
                Mesto = (string)reader["Mesto"],
            };
            return p;
        }

        public override string ToString()
        {
            return $"{Naziv}";
        }
    }
}