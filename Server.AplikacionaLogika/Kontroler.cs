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
            so.ExecuteTemplate();
            return ((VratiProizvodjaceSO)so).proizvodjaci;
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