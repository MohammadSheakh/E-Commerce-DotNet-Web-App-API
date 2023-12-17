

using DataAccessLayer.EF.Models.UserModel;
using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.UserRepo
{
    internal class UserRepo : Repo, IRepo<User, int, User>, IAuth<bool>
    {
        public bool Authenticate(string email, string password)
        {
            var data = db.Users.FirstOrDefault(u => u.email.Equals(email) && password.Equals(password));
            if (data != null) return true;
            return false;
            // throw new NotImplementedException();
        }

        public User Create(User obj)
        {
            db.Users.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
            //throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var existing = Get(id);
            db.Users.Remove(existing);
            return db.SaveChanges() > 0;
            // throw new NotImplementedException();
        }

        public List<User> Get()
        {
            return db.Users.ToList();
            //throw new NotImplementedException();
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
            //throw new NotImplementedException();
        }

        public User Update(User obj)
        {
            var existing = Get(obj.id);
            db.Entry(existing).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;

            //throw new NotImplementedException();
        }
    }
}
