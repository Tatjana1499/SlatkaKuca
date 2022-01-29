using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class ProdajnoMesto : IDomenskiObjekat
    {
        public int ProdajnoMestoID { get; set; }
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public string RadnoVreme { get; set; }
        public string Sajt { get; set; }

        public string NazivTabele => "ProdajnoMesto";
        public string UbaciVrednosti => $"{ProdajnoMestoID}, '{Naziv}', '{Lokacija}', '{RadnoVreme}', '{Sajt}'";

        public string UslovIzbacivanja => $"{ProdajnoMestoID} = Id";

        public IDomenskiObjekat ProcitajObjekat(SqlDataReader reader)
        {
            ProdajnoMesto p = new ProdajnoMesto
            {
                ProdajnoMestoID = (int)reader["ProdajnoMestoID"],
                Naziv = (string)reader["Naziv"],
                Lokacija = (string)reader["Lokacija"],
                RadnoVreme = (string)reader["RadnoVreme"],
                Sajt = (string)reader["Sajt"],
            };
            return p;
        }
        public override string ToString()
        {
            return $"{Naziv}";
        }
    }
}