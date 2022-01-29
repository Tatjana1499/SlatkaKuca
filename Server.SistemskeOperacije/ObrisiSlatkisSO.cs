using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class ObrisiSlatkisSO : OpstaSO
    {
        Slatkis slatkis;
        public bool uspesno;
        public ObrisiSlatkisSO(Slatkis slatkis)
        {
            this.slatkis = slatkis;
        }
        protected override void Execute()
        {
            try
            {
                repository.Delete(slatkis);
                uspesno = true;
            }
            catch (Exception ex)
            {
                uspesno = false;
            }
        }
    }
}