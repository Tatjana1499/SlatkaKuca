using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class UnesiDnevnuProdajuSO : OpstaSO
    {

        public DnevnaProdaja DnevnaProdaja { get; set; }

        public UnesiDnevnuProdajuSO(DnevnaProdaja dnevnaProdaja)
        {
            DnevnaProdaja = dnevnaProdaja;
        }

        protected override void Execute()
        {
            repository.Save(DnevnaProdaja);
        }
    }
}