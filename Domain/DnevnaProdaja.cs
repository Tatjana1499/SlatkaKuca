using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class DnevnaProdaja : IDomenskiObjekat
    {
        public ProdajnoMesto ProdajnoMesto { get; set; }
        public Pakovanje Pakovanje { get; set; }
        public DateTime DatumProdaje { get; set; }
        public int KolicinaProdatih { get; set; }
        public string KomentarPrMesta { get; set; }

        public string NazivTabele => "DnevnaProdaja";

        public string UbaciVrednosti => $"{Pakovanje.PakovanjeID}, {ProdajnoMesto.ProdajnoMestoID}, '{DatumProdaje}', {KolicinaProdatih}, '{KomentarPrMesta}'";
        public string PostaviVrednosti => $"KomentarPrMesta = '{KomentarPrMesta}', KolicinaProdatih = {KolicinaProdatih}, DatumProdaje = {DatumProdaje}";

        public string UslovIzbacivanja => $"{DatumProdaje} = Id"; //SREDI!!!!!!!

        public IDomenskiObjekat ProcitajObjekat(SqlDataReader reader)
        {
            DnevnaProdaja p = new DnevnaProdaja
            {
                DatumProdaje = (DateTime)reader["DatumProdaje"],
                KolicinaProdatih = (int)reader["KolicinaProdatih"],
                KomentarPrMesta = (string)reader["KomentarPrMesta"],
                Pakovanje = new Pakovanje 
                {
                    PakovanjeID = (int)reader["PakovanjeID"]
                },
                ProdajnoMesto = new ProdajnoMesto
                {
                    ProdajnoMestoID = (int)reader["ProdajnoMestoID"]
                }
            };
            return p;
        }
    }
}