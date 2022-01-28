using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class DodajProizvodjacaSO : OpstaSO
    {
        public  Proizvodjac Proizvodjac{ get; private set; }
        public DodajProizvodjacaSO(Proizvodjac proizvodjac)
        {
            Proizvodjac = proizvodjac;
        }

        protected override void Execute()
        {
            repository.Save(Proizvodjac);
        }
    }
}
