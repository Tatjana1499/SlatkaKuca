using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class VratiSlatkiseSO : OpstaSO
    {
        public List<Slatkis> slatkisi;

        protected override void Execute()
        {
            slatkisi = repository.GetAll(new Slatkis()).OfType<Slatkis>().ToList();
        }
    }
}