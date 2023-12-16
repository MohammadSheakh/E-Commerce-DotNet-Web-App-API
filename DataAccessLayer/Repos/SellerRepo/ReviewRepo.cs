using DataAccessLayer.EF.Models.Seller.Profile.Reviews;

using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.Seller
{
    internal class ReviewRepo : Repo, IRepo<Review, int, Review>
    {
        public Review Create(Review obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Review> Get()
        {
            throw new NotImplementedException();
        }

        public Review Get(int id)
        {
            throw new NotImplementedException();
        }

        public Review Update(Review obj)
        {
            throw new NotImplementedException();
        }
    }
}
