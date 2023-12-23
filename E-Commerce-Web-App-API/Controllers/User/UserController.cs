using BusinessLogicLayer.DTOs.Seller.Profile;
using BusinessLogicLayer.DTOs.User;
using BusinessLogicLayer.Services.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E_Commerce_Web_App_API.Controllers.User
{
    public class UserController : ApiController
    {
          
        // User.1. Create User Or Registration //🔰OK- - -🔴🔗

        [HttpPost]
        [Route("api/user/CreateNewUser")]
        public HttpResponseMessage CreateNewUser(RegistrationDTO registrationDTO)
        {
            try
            {
                // It also create profile 
                var data  = UserService.CreateNewUser(registrationDTO);
                //return Request.CreateResponse(HttpStatusCode.OK, "DDD");
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // User.2. GetOneUserById

        [HttpGet]
        [Route("api/user/GetOneUserById/{UserId}")] //🔰OK- - -🔴🔗
        public HttpResponseMessage GetOneUserById(int UserId)
        {
            try
            {
                var data = UserService.GetOneUserById(UserId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // User.3. GetOneUsersProfileById

        [HttpGet]
        [Route("api/user/GetOneUsersProfileById/{UserId}")]
        public HttpResponseMessage GetOneUsersProfileById(int UserId)
        {
            try
            {
                var data = UserService.GetOneUsersProfileById(UserId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // User.4. GetAllUsersProfile

        [HttpGet]
        [Route("api/user/GetAllUsersProfile/")]
        public HttpResponseMessage GetAllUsersProfile()
        {
            try
            {
                var data = UserService.GetAllUsersProfile();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // User.5. UpdateAUserById

        [HttpGet]
        [Route("api/user/UpdateAUserById/{UserId}")]
        public HttpResponseMessage UpdateAUserById(int UserId, UpdateUserDTO updateUserDto)
        {
            try
            {
                var data = UserService.UpdateAUserById(UserId, updateUserDto);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // User.6. UpdateAUserProfileById

        [HttpGet]
        [Route("api/user/UpdateAUserProfileById/{UserId}")]
        public HttpResponseMessage UpdateAUserProfileById(int UserId, UpdateSellerProfileDTO updateSellerProfileDto)
        {
            try
            {
                var data = UserService.UpdateAUserProfileById(UserId, updateSellerProfileDto);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }

        // User.7. DeleteAUsersAccountById


        [HttpGet]
        [Route("api/user/DeleteAUsersAccountById/{UserId}")]
        public HttpResponseMessage DeleteAUsersAccountById(int UserId)
        {
            try
            {
                var data = UserService.DeleteAUsersAccountById(UserId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }





        // User.8. /////////////////////

        // User.9. /////////////////////

        // User.10. /////////////////////


    }
}
