using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class PrijavaSO : OpstaSO
    {
        public User User { get; private set; }

        public List<User> List { get; private set; }
        public PrijavaSO(User user)
        {
            this.User = user;
        }

        protected override void Execute()
        {
            List = repository.GetAll(new User()).OfType<User>().ToList();
            foreach (var item in List)
            {
                if(User.KorisnickoIme==item.KorisnickoIme && User.KorisnickaSifra == item.KorisnickaSifra)
                {
                    User = item;
                    return;
                }
            }
            User = null;
        }
    }
}