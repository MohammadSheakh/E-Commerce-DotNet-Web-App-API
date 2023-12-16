using DataAccessLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    internal class Repo
    {
        protected ECommerceContext db;
        protected Repo() 
        {
            db = new ECommerceContext();
        }
    }
}
