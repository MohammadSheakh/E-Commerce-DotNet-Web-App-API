using AutoMapper;
using BusinessLogicLayer.DTOs.User;
using DataAccessLayer;
using DataAccessLayer.EF.Models.UserModel;
using E_Commerce_Web_Application.Helper.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.UserService
{
    public class UserService
    {
        // ekhon amra method banabo .. 
        // jeta hit korbe DataAccessFactory er through te Interface ke .. 
        // Interface gula implement kora ase .. Repo te .. 

        // static method banabo ..

        // User.1. Create User Or Registration
        public static UserDTO CreateNewUser(RegistrationDTO registrationDTO)
        {
            // auto mapper diye convert korte hobe 

             var DTO_ModelMapped = AutoMapperConverter.ConvertForSingleInstance<RegistrationDTO, User>(registrationDTO);

            var result = DataAccessFactory.UserData().Create(DTO_ModelMapped);

            var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<User, UserDTO>(result);

            return Model_DTOMapped;

            //var config = new MapperConfiguration(cfg => {
            //    cfg.CreateMap<RegistrationDTO, User>();
            //    cfg.CreateMap<User, RegistrationDTO>();

            //});

            //var mapper2 = new Mapper(config);
        }


        // User.2. GetOneUserById
        public static string GetOneUserById(int UserId)
        {
            return "";
        }

        // User.3. GetOneUsersProfileById
        public static string GetOneUsersProfileById(int UserId)
        {
            return "";
        }

        // User.4. GetAllUsersProfile
        public static string GetAllUsersProfile()
        {
            
            return "";
        }

        // User.5. UpdateAUserById
        public static string UpdateAUserById(int UserId)
        {
            // Update Only Basic Information
            return "";
        }

        // User.6. UpdateAUserProfileById
        public static string UpdateAUserProfileById(int UserId)
        {
            // Update Only Profile Information

            return "";
        }

        // User.7. DeleteAUsersAccountById
        public static string DeleteAUsersAccountById(int UserId)
        {
            // it will delete Users Basic Data as well as Profile Information
            return "";
        }


        // User.8. /////////////////////

        // User.9. /////////////////////

        // User.10. /////////////////////
    }
}
