using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class DodajSlatkiseSO : OpstaSO
    {
        List<Slatkis> slatkisi;
        public DodajSlatkiseSO(Object poruka)
        {
            slatkisi = (List<Slatkis>)poruka;
        }
        protected override void Execute()
        {
            foreach(var item in slatkisi)
            {
                repository.Save(item);
            }
        }
    }
}