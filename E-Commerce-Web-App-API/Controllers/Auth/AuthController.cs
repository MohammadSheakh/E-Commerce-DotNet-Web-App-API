using BusinessLogicLayer.Services.Auth;
using E_Commerce_Web_App_API.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E_Commerce_Web_App_API.Controllers.Auth
{
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route("api/login")]
        public HttpResponseMessage Login(LoginModel loginModel)
        {
            try
            {
                var res = AuthService.Authenticate(loginModel.email, loginModel.password);

                // AuthService er kase shob kichu thik thak thakle ekta token
                // ashbe .. naile null ashbe .. 
                if(res != null)
                {
                    return  Request.CreateResponse(HttpStatusCode.OK, res);// token ta return kore diye dilam
                }
                else
                {
                    // kono authentication na hole
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { Message = "User not found " });
                }

            }catch (Exception ex)
            {
                // anonymous object .. 
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }

        }
    }
}
