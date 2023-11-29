using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E_Commerce_Web_App_API.Controllers.Seller
{
    public class SellerController : ApiController
    {
        [HttpGet] // customized // request override
        [Route("api/names")] // custom routing ta add kore dite hobe 

        public HttpResponseMessage Get()
        {
            // var data = new { Name = "Tanvir", Id = "1234"};
            var names = new String[] { "Tanvir","Sabbir" };
            return Request.CreateResponse(HttpStatusCode.OK, names);
            // 404 - > not found
            // 200 - > successfull
            // 500 - > bad request 
        }

        [HttpGet] // customized // request override
        [Route("api/name")] // custom routing ta add kore dite hobe 
        public HttpResponseMessage GetName()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Tanvir");  
        }

        [HttpGet] // customized // request override
        [Route("api/name/{st_id}")] // custom routing ta add kore dite hobe 
        public HttpResponseMessage GetNameById(int st_id)
        {
            string name = st_id == 1 ? "Tanvir" : "Not Recognized";
            return Request.CreateResponse(HttpStatusCode.OK, name);
        }

        [HttpPost] // customized // request override
        [Route("api/name/post/")] // custom routing ta add kore dite hobe 
        public HttpResponseMessage Post()
        {
            //string name = st_id == 1 ? "Tanvir" : "Not Recognized";
            return Request.CreateResponse(HttpStatusCode.OK, "Post Received");
        }

        //public HttpResponseMessage FindSeller()
        //{

        //}

    }
}
