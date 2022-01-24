using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DnevnaProdaja
    {
        public ProdajnoMesto ProdajnoMesto { get; set; }
        public Pakovanje Pakovanje { get; set; }
        public int DatumProdaje { get; set; }
        public int KolicinaProdatih { get; set; }
        public string KomentarPrMesta { get; set; }
    }
}