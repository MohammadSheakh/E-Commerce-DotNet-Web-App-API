using BusinessLogicLayer.DTOs.Conversation;
using BusinessLogicLayer.DTOs.Product;
using BusinessLogicLayer.DTOs.Review;
using BusinessLogicLayer.DTOs.Seller;

using BusinessLogicLayer.DTOs.User;
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

        


        /////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////




        
        
        
        



        





        

       

        //  7. paymentCompleteOfPreOrder [Product]



        //  8. orderStatusPending [Product]



        

        




        // 11. Seller Login basic/jwt [Seller]

        [HttpPost]
        [Route("api/seller/sellerLoginJWT")]
        public HttpResponseMessage SellerLoginJWT(LoginDTO loginDTO)
        {
            try
            {
                //SellerService.SellerLoginJWT(loginDTO);
                return Request.CreateResponse(HttpStatusCode.OK, "Login Successful");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // 12. Seller Logout[Seller]

        [HttpGet]
        [Route("api/seller/logout")]
        public HttpResponseMessage Logout()
        {
            try
            {
                var data = "";// = SellerService.Logout();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // 13. createNewSeller [Seller]

        [HttpPost]
        [Route("api/seller")]
        public HttpResponseMessage CreateSeller(SellerDTO sellerDTO)
        {
            try
            {
              //  SellerService.CreateSeller(sellerDTO);
                return Request.CreateResponse(HttpStatusCode.OK, "New Seller Created");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        // 14. getAllSeller [Seller]

        [HttpGet] 
        [Route("api/seller/")]  
        public HttpResponseMessage GetAllSeller()
        {
            try
            {
                var data = "";// = SellerService.GetAllSeller();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        // 15. getOneSeller [Seller]

        [HttpGet]
        [Route("api/seller/{sellerId}")]  
        public HttpResponseMessage GetOneSeller(int sellerId)
        {
            try
            {
                var data = "";//= SellerService.GetOneSeller(sellerId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // 15.1. getOneSellerByEmail [Seller]

        [HttpGet]
        [Route("api/seller/{sellerEmail}")] // 🔴🔴🔴🔴
        public HttpResponseMessage GetOneSellerByEmail(int sellerEmail)
        {
            try
            {
                var data = "";// = SellerService.GetOneSellerByEmail(sellerEmail);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        // 16. updateSellerInformation [Seller]

        [HttpPatch] 
        [Route("api/seller/{sellerId}")] 
        public HttpResponseMessage UpdateSellerInfo(int sellerId) // data o send korte hobe 
        {
            try
            {
                var data = "";// = SellerService.UpdateSellerInfo(sellerId); // data o send korte hobe 
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // 17. deleteSellerAccount [Seller]

        [HttpDelete]
        [Route("api/seller/{sellerId}")]
        public HttpResponseMessage DeleteSellerAccout(int sellerId)
        {
            try
            {
                var data = "";// = SellerService.DeleteSellerAccout(sellerId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}
