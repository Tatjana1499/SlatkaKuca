using Domain;
using Server.BrokerBaze;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repozitorijum
{
    public class GenerickiDbRepozitorijum : IRepozitorijum<IDomenskiObjekat>
    {
        private Broker broker = new Broker();
        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }
        public void CloseConnection()
        {
            broker.CloseConnection();
        }
        public void Commit()
        {
            broker.Commit();
        }
        public void Delete(IDomenskiObjekat obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"DELETE FROM {obj.NazivTabele} WHERE {obj.UslovIzbacivanja}";
            command.ExecuteNonQuery();
        }
        public List<IDomenskiObjekat> GetAll(IDomenskiObjekat obj)
        {
            List<IDomenskiObjekat> result = new List<IDomenskiObjekat>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"SELECT * FROM [{obj.NazivTabele}]";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomenskiObjekat rowObject = obj.ProcitajObjekat(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }
        public void OpenConnection()
        {
            broker.OpenConnection();
        }
        public void Rollback()
        {
            broker.Rollback();
        }
        public void Save(IDomenskiObjekat obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"insert into {obj.NazivTabele} values ({obj.UbaciVrednosti})";
            command.ExecuteNonQuery();
        }
        public List<IDomenskiObjekat> Search(string kriterijum)
        {
            throw new NotImplementedException();
        }
        public void Update(IDomenskiObjekat obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"UPDATE {obj.NazivTabele} SET {obj.PostaviVrednosti} WHERE {obj.UslovIzbacivanja}";
            command.ExecuteNonQuery();
            
        }
    }
}