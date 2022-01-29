using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class DodajPrMestoSO : OpstaSO
    {
       
        public ProdajnoMesto ProdajnoMesto { get; set; }

        public DodajPrMestoSO(ProdajnoMesto prodajnoMesto)
        {
            ProdajnoMesto = prodajnoMesto;
        }

        protected override void Execute()
        {
            repository.Save(ProdajnoMesto);
        }
    }
}