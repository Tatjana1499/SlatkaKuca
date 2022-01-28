using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class VratiProizvodjaceSO : OpstaSO
    {
        public List<Proizvodjac> proizvodjaci;
        protected override void Execute()
        {
            proizvodjaci = repository.GetAll(new Proizvodjac()).OfType<Proizvodjac>().ToList();
        }
    }
}