using AutoMapper;
using BusinessLogicLayer.DTOs.Seller.Profile;
using BusinessLogicLayer.DTOs.User;
using DataAccessLayer;
using DataAccessLayer.EF.Models.Seller.Profile;
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
        public static UserDTO GetOneUserById(int UserId)
        {
            // 🏠 ekhane ki amra return type User dibo naki User DTO dibo 
            var result =  DataAccessFactory.UserData().Get(UserId);


            //auto mapper diye convert korte hobe 
            var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<User, UserDTO>(result);



            return Model_DTOMapped;
            //return "";
        }

        // User.3. GetOneUsersProfileById
        public static SellerProfileDTO GetOneUsersProfileById(int UserId)
        {
            var result = DataAccessFactory.SellerProfileData().Get(UserId);
            // Model To DTO
            var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<SellerProfile, SellerProfileDTO>(result);

            return Model_DTOMapped;
        }

        // User.4. GetAllUsersProfile
        public static List<SellerProfileDTO> GetAllUsersProfile()
        {
            var result = DataAccessFactory.SellerProfileData().Get();
            // Model to DTO
            var Model_DTOMapped = AutoMapperConverter.ConvertForList<SellerProfile, SellerProfileDTO>(result);

            return Model_DTOMapped;
        }

        // User.5. UpdateAUserById
        public static UpdateUserDTO UpdateAUserById(int UserId, UpdateUserDTO updateUserDto)
        {
            // Update Only Basic Information

            // DTO to Model

            var DTO_ModelMapped = AutoMapperConverter.ConvertForSingleInstance<UpdateUserDTO, User>(updateUserDto);

            var result = DataAccessFactory.UserData().Update(DTO_ModelMapped);

            // result jeta ashbe .. sheta Model er moto .. lets convert it to DTO 

            var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<User, UpdateUserDTO>(result);// 🏠 ekhane ki UserDTO hobe naki UpdateUserDTO hobe ?


            return Model_DTOMapped;

        }

        // User.6. UpdateAUserProfileById
        public static UpdateSellerProfileDTO UpdateAUserProfileById(int UserId, UpdateSellerProfileDTO updateSellerProfileDto)
        {
            // Update Only Profile Information

            var DTO_ModelMapped = AutoMapperConverter.ConvertForSingleInstance<UpdateSellerProfileDTO, User>(updateSellerProfileDto);

            var result = DataAccessFactory.UserData().Update(DTO_ModelMapped);

            // result jeta ashbe .. sheta Model er moto .. lets convert it to DTO 

            var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<User, UpdateSellerProfileDTO>(result);// 🏠 ekhane ki UserDTO hobe naki UpdateUserDTO hobe ?

            return Model_DTOMapped;   
        }

        // User.7. DeleteAUsersAccountById
        public static bool DeleteAUsersAccountById(int UserId)
        {
            // it will delete Users Basic Data as well as Profile Information
            var result = DataAccessFactory.UserData().Delete(UserId);

            return result;
        }

        // User.8. /////////////////////

        // User.9. /////////////////////

        // User.10. /////////////////////
    }
}
