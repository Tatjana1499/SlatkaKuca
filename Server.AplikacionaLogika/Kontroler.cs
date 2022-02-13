using Domain;
using Server.SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.AplikacionaLogika
{
    public class Kontroler
    {
        private static Kontroler instanca;
        public static Kontroler Instanca 
        {
            get
            {
                if (instanca == null) instanca = new Kontroler();
                return instanca;
            }
        }
        private Kontroler() { }

        public User Login(User user)
        {
            OpstaSO so = new PrijavaSO(user);
            so.ExecuteTemplate();
            return ((PrijavaSO)so).User;
        }
        public void DodajSlatkise(Object poruka)
        {
            OpstaSO so = new DodajSlatkiseSO(poruka);
            so.ExecuteTemplate();
        }
        public List<Proizvodjac> VratiProizvodjace()
        {
            OpstaSO so = new VratiProizvodjaceSO();
            try
            {
                so.ExecuteTemplate();
            }
           catch (Exception ex)
            {
                throw;
            }
            return ((VratiProizvodjaceSO)so).proizvodjaci;
        }
        public List<ProdajnoMesto> VratiPrMesta()
        {
            OpstaSO so = new VratiPrMestaSO();
            try
            {
                so.ExecuteTemplate();
            }
            catch (Exception ex)
            {
                throw;
            }
            return ((VratiPrMestaSO)so).prMesta;
        }
        
             public List<Pakovanje> VratiPakovanja()
        {
            OpstaSO so = new VratiPakovanjaSO();
            try
            {
                so.ExecuteTemplate();
            }
            catch (Exception ex)
            {
                throw;
            }
            return ((VratiPakovanjaSO)so).pakovanja;
        }
        public List<Slatkis> VratiSlatkise()
        {
            OpstaSO so = new VratiSlatkiseSO();
            try
            {
                so.ExecuteTemplate();
            }
            catch (Exception ex)
            {
                throw;
            }
            return ((VratiSlatkiseSO)so).slatkisi;

        }
        public bool ObrisiSlatkis(Slatkis slatkis)
        {
            OpstaSO so = new ObrisiSlatkisSO(slatkis);
            so.ExecuteTemplate();
            return ((ObrisiSlatkisSO)so).uspesno;
        }
        public void IzmeniSlatkis(Slatkis slatkis)
        {
            IzmeniSlatkisSO so = new IzmeniSlatkisSO(slatkis);
            so.ExecuteTemplate();
        }
        public Proizvodjac DodajProizvodjaca(Proizvodjac proizvodjac)
        {
            DodajProizvodjacaSO so = new DodajProizvodjacaSO(proizvodjac);
            so.ExecuteTemplate();
            return so.Proizvodjac;
        }
        public void DodajPrMesto(ProdajnoMesto prodajnoMesto)
        {
            OpstaSO so = new DodajPrMestoSO(prodajnoMesto);
            so.ExecuteTemplate();
        }
        public void UnesiDnevnuProdaju(DnevnaProdaja dnevnaProdaja)
        {
            OpstaSO so = new UnesiDnevnuProdajuSO(dnevnaProdaja);
            so.ExecuteTemplate();
        }
    }
}