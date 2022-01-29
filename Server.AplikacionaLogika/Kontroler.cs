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
        public List<Slatkis> VratiOdabraneSlatkise(Proizvodjac proizvodjac)
        {
            List<Slatkis> sviSl = VratiSlatkise();
            List<Slatkis> odabraniSl = new List<Slatkis>();

            foreach (Slatkis s in sviSl)
            {
                if(s.Proizvodjac.ProizvodjacID == proizvodjac.ProizvodjacID)
                {
                    odabraniSl.Add(s);
                }
            }
            return odabraniSl;
        }

        public bool ObrisiSlatkis(Slatkis slatkis)
        {
            OpstaSO so = new ObrisiSlatkisSO(slatkis);
            so.ExecuteTemplate();
            return ((ObrisiSlatkisSO)so).uspesno;
        }

        /*
        public void SaveInvoice(Invoice i)
        {
        }

        public List<Manufacturer> GetAllManufacturers()
        {
            SystemOperationBase so = new GetAllManufacturersSO();
            so.ExecuteTemplate();
            return ((GetAllManufacturersSO)so).Result;
        }

        public void AddProduct(Product product)
        {
            SystemOperationBase so = new AddProductSO(product);
            so.ExecuteTemplate();
        }

        public void AddAllProducts(List<Product> products)
        {
        }
        */
        public Proizvodjac DodajProizvodjaca(Proizvodjac proizvodjac)
        {
            DodajProizvodjacaSO so = new DodajProizvodjacaSO(proizvodjac);
            so.ExecuteTemplate();
            return so.Proizvodjac;
        }
    }
}