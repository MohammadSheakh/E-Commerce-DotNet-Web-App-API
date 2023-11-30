using BusinessLogicLayer.Services.Seller;
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

        [HttpGet]
        [Route("api/name/demo/{id}")]
        // person er name send korbo 
        public HttpResponseMessage GetPersonName(int id)
        {
            try
            {
                // eto din ekhanei context baniye felsi .. 
                // context ke call kore disi ..

                // but ekhon .. API layer er kono kichu dorkar hoile ..
                // sheta chabe business layer er kase ..  

                // so, business logic layer e kichu ekta thakte hobe 
                // lets go to business logic layer ..

                var data =  SellerService.GetName(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        //public HttpResponseMessage FindSeller()
        //{

        //}

        [HttpGet] // customized // request override
        [Route("api/seller/")] // custom routing ta add kore dite hobe 
        public HttpResponseMessage GetAllSeller()
        {
            try
            {
                var data = SellerService.GetAllSeller();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet] // customized // request override
        [Route("api/seller/{sellerId}")] // custom routing ta add kore dite hobe 
        public HttpResponseMessage GetOneSeller(int sellerId)
        {
            try
            {
                var data = SellerService.GetOneSeller(sellerId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}
