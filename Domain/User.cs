using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class User : IDomenskiObjekat
    {
        public int UserID { get; set; }
        public string KorisnickoIme { get; set; }
        public string KorisnickaSifra { get; set; }
        public string Email { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string NazivTabele => "User";

        public string UbaciVrednosti => $"'{KorisnickoIme}', '{KorisnickaSifra}', '{Email}', '{Ime}', '{Prezime}'";

        public string UslovIzbacivanja => $"{UserID} = Id";

        public string PostaviVrednosti => $"KorisnickoIme = '{KorisnickoIme}', KorisnickaSifra = '{KorisnickaSifra}', Email = '{Email}', Ime = '{Ime}', Prezime = '{Prezime}'";

        public IDomenskiObjekat ProcitajObjekat(SqlDataReader reader)
        {
            User u = new User
            {
             //   UserID = (int)reader["UserID"],
                KorisnickoIme = (string)reader["KorisnickoIme"],
                KorisnickaSifra = (string)reader["KorisnickaSifra"],
                Ime = (string)reader["Ime"],
                Email = (string)reader["Email"],
                Prezime = (string)reader["Prezime"]
            };
            return u;
        }
    }
}