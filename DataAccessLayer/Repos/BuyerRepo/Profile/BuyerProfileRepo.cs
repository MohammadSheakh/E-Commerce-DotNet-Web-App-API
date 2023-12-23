using DataAccessLayer.EF.Models;
using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.BuyerRepo.Profile
{
    internal class BuyerProfileRepo : Repo, IRepo<BuyerProfile, int, BuyerProfile>
    {
        public BuyerProfile Create(BuyerProfile obj)
        {
            db.BuyerProfiles.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
            //throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BuyerProfile> Get()
        {
            throw new NotImplementedException();
        }

        public BuyerProfile Get(int id)
        {
            throw new NotImplementedException();
        }

        public BuyerProfile Update(BuyerProfile obj)
        {
            throw new NotImplementedException();
        }
    }
}
