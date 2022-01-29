using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IDomenskiObjekat
    {
        string NazivTabele { get; }
        string UbaciVrednosti { get; }
        string UslovIzbacivanja { get; }

        IDomenskiObjekat ProcitajObjekat(SqlDataReader result);
    }
}