using BusinessLogicLayer.DTOs.Review;
using BusinessLogicLayer.DTOs.User;
using DataAccessLayer;
using DataAccessLayer.EF.Models.Common.Reviews;
using DataAccessLayer.EF.Models.UserModel;
using E_Commerce_Web_Application.Helper.Converter;
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
        public static TokenDTO Authenticate(string email ,string password)
        {
            var res =  DataAccessFactory.AuthData().Authenticate(email, password);
            /*
                ekhon ei authentication ta kivabe hobe .. 
                authentication er pore ashe hocche authorization .. 
                
                authentication er time e amra token ta generate korbo 

                // amader token Repo o lagbe .. karon token create read egula kora lagbe 

             */

            if (res)
            {
                var token = new Token();
                token.userId = email; // logical to hoilo na ⚫🔴🔗🏠
                // email er upor base kore  .. userId ta ke niye ashte hobe

                token.CreatedAt = DateTime.Now;
                token.TKey = Guid.NewGuid().ToString();

                var ret = DataAccessFactory.TokenData().Create(token);
                // she ekta token object return korbe 

                if (ret != null)
                {
                    // Token ke TokenDTO te convert korbo 
                    var mappedData = AutoMapperConverter.ConvertForSingleInstance<Token, TokenDTO>(ret);
                }
            }
            return null; // onno jekono case e null return korbe 
        }
    }
}
