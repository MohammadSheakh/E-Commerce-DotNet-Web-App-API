using DataAccessLayer.EF.Models.UserModel;
using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.UserRepo
{
    internal class TokenRepo : Repo, IRepo<Token, string, Token> /*Class, idDataType, returnDataType*/
    {
        public Token Create(Token obj)
        {
            db.Tokens.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
            //throw new NotImplementedException();
        }

        public bool Delete(string id)
        {

            throw new NotImplementedException();
        }

        public List<Token> Get()
        {
            throw new NotImplementedException();
        }

        public Token Get(string id)
        {
            // ekta single token pabo .. etar jonno token object return korte
            // hobe .. 
            return db.Tokens.FirstOrDefault(t => t.TKey.Equals(id));
            // throw new NotImplementedException();
        }

        public Token Update(Token obj)
        {
            var token = Get(obj.TKey); // khuje ber korlam
            db.Entry(token).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return token;
            return null;

            // throw new NotImplementedException();
        }
    }
}
