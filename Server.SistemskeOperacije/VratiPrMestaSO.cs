using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class VratiPrMestaSO : OpstaSO
    {
        public List<ProdajnoMesto> prMesta;
        protected override void Execute()
        {
            prMesta = repository.GetAll(new ProdajnoMesto()).OfType<ProdajnoMesto>().ToList();
        }
    }
}