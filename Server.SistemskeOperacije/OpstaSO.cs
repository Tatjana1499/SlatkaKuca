using Domain;
using Server.Repozitorijum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public abstract class OpstaSO
    {
        protected IRepozitorijum<IDomenskiObjekat> repository = new GenerickiDbRepozitorijum();
        public void ExecuteTemplate()
        {
            try
            {
                repository.OpenConnection();
                repository.BeginTransaction();
                Execute();
                repository.Commit();
            }
            catch (Exception ex)
            {
                repository.Rollback();
                throw;
            }
            finally
            {
                repository.CloseConnection();
            }
        }
        protected abstract void Execute();
    }
}