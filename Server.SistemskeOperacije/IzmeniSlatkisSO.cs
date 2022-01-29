using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class IzmeniSlatkisSO : OpstaSO
    {
        Slatkis slatkis;
        public IzmeniSlatkisSO(Slatkis slatkis)
        {
            this.slatkis = slatkis;
        }
        protected override void Execute()
        {
            repository.Update(slatkis);
        }
    }
}