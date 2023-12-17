using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Auth
{
    public class AuthService
    {
        // public korte hobe
        public static bool Authenticate(string email ,string password)
        {
            return DataAccessFactory.AuthData().Authenticate(email, password);
            /*
                ekhon ei authentication ta kivabe hobe .. 


             */
        }
    }
}
