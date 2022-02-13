using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class VratiPakovanjaSO : OpstaSO
    {
        public List<Pakovanje> pakovanja;
        protected override void Execute()
        {
            pakovanja = repository.GetAll(new Pakovanje()).OfType<Pakovanje>().ToList();
        }
    }
}