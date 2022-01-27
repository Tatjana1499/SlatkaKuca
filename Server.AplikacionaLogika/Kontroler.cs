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


        public List<Slatkis> GetAllProducts()
        {
            return new List<Slatkis>();
        }

        public User Login(User user)
        {
            OpstaSO so = new PrijavaSO(user);
            so.ExecuteTemplate();
            return ((PrijavaSO)so).User;
        }

        public string[] GetAllMeasurementUnits()
        {
            //SystemOperationBase so = new GetAllMeasurementUnits(user);
            //so.ExecuteTemplate();
            //return ((GetAllMeasurementUnits)so).Result;
            return new string[] { }; //treba implementirati sistemsku operaciju
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

    }
}