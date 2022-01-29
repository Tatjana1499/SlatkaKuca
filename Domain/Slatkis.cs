using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Slatkis : IDomenskiObjekat
    {
        public int SlatkisID { get; set; }
        public string Naziv { get; set; }
        public Proizvodjac Proizvodjac { get; set; }
        public string NazivTabele => "Slatkis";
        public string UbaciVrednosti => $"'{Naziv}', {Proizvodjac.ProizvodjacID}";
        public string PostaviVrednosti => $"Naziv = '{Naziv}', ProizvodjacID = {Proizvodjac.ProizvodjacID}";
        public string UslovIzbacivanja => $"{SlatkisID} = Id";
        public IDomenskiObjekat ProcitajObjekat(SqlDataReader reader)
        {
            Slatkis s = new Slatkis
            {
                Naziv = (string)reader["Naziv"],
                SlatkisID = (int)reader["Id"],
                Proizvodjac = new Proizvodjac 
                { 
                    ProizvodjacID = (int)reader["ProizvodjacID"]
                }
            };
            return s;
        }
        public override string ToString()
        {
            return $"{Naziv}";
        }
    }
}