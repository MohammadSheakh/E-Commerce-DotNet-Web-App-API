using BusinessLogicLayer.DTOs.Seller;
using BusinessLogicLayer.DTOs.University;
using BusinessLogicLayer.Services.Seller;
using BusinessLogicLayer.Services.University;
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




        //  1. AddProduct [Product] // status[n-n-n]

        [HttpPost] 
        [Route("api/seller/createProduct")]
        public HttpResponseMessage CreateProduct(ProductDTO productDTO)
        {
            try
            {
                ProductService.CreateProduct(productDTO);
                return Request.CreateResponse(HttpStatusCode.OK, "New Product Added");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        //  2. getAllProductsDetails [Product]
       

        [HttpGet] // customized // request override
        [Route("api/seller/getAllProductsDetails")] // custom routing ta add kore dite hobe 
        public HttpResponseMessage GetAllProductsDetails()
        {
            try
            {
                var data = ProductService.GetAllProductsDetails();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        //  3. addReview [Product]

        [HttpPost] 
        [Route("api/seller/addReview")] 
        public HttpResponseMessage AddReview(ReviewDTO reviewDTO)
        {
            try
            {
                ProductService.AddReview(reviewDTO);
                return Request.CreateResponse(HttpStatusCode.OK, "Review Created");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        //  4. addReplyToAReview [Product]

        [HttpPost]
        [Route("api/seller/addReplyToAReview")]
        public HttpResponseMessage AddReplyToReview(ReviewReplyDTO reviewReplyDTO)
        {
            try
            {
                ProductService.AddReplyToReview(reviewReplyDTO);
                return Request.CreateResponse(HttpStatusCode.OK, "Review Reply Created");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        //  5. addAvailableQualityOfAProduct [Product]

        [HttpPost]
        [Route("api/seller/addAvailableQualityOfAProduct")]
        public HttpResponseMessage AddAvailableQualityOfAProduct(DTO DTO)
        {
            try
            {
                ProductService.AddAvailableQualityOfAProduct(DTO);
                return Request.CreateResponse(HttpStatusCode.OK, "Available Quality Created");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        //  6. addSpecificationOfAProduct [Product]

        [HttpPost]
        [Route("api/seller/addSpecificationOfAProduct")]
        public HttpResponseMessage AddSpecificationOfAProduct(DTO DTO)
        {
            try
            {
                ProductService.AddSpecificationOfAProduct(DTO);
                return Request.CreateResponse(HttpStatusCode.OK, "Specification Created");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        //  7. paymentCompleteOfPreOrder [Product]



        //  8. orderStatusPending [Product]



        //  9. getAllNegetiveReview [Product]

        [HttpGet] 
        [Route("api/seller/getAllNegetiveReview")]
        public HttpResponseMessage GetAllNegetiveReview()
        {
            try
            {
                var data = ProductService.GetAllNegetiveReview();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        // 10. checkForLowQuantity [Product]

        [HttpGet]
        [Route("api/seller/checkForLowQuantity")]
        public HttpResponseMessage CheckForLowQuantity()
        {
            try
            {
                var data = ProductService.CheckForLowQuantity();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }





        // 11. Seller Login basic/jwt [Seller]

        [HttpPost]
        [Route("api/seller/sellerLoginJWT")]
        public HttpResponseMessage SellerLoginJWT(LoginDTO loginDTO)
        {
            try
            {
                SellerService.SellerLoginJWT(loginDTO);
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
                var data = SellerService.Logout();
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
                SellerService.CreateSeller(sellerDTO);
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
                var data = SellerService.GetAllSeller();
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
                var data = SellerService.GetOneSeller(sellerId);
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
        public HttpResponseMessage UpdateSellerInfo(int sellerId)
        {
            try
            {
                var data = SellerService.UpdateSellerInfo(sellerId);
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
                var data = SellerService.DeleteSellerAccout(sellerId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // 18. sortProductByBrand [Brand]
        [HttpGet] 
        [Route("api/seller/{sellerId}")]  
        public HttpResponseMessage SortProductByBrand(string brandName)
        {
            try
            {
                // brandName er upor base kore product gula niye ashbo
                var data = ProductService.SortProductByBrand(brandName);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }




        // 19. sortProductByCategory [Category]

        [HttpGet] 
        [Route("api/seller/{sellerId}")] 
        public HttpResponseMessage SortProductByCategory(string categoryName)
        {
            try
            {
                // brandName er upor base kore product gula niye ashbo
                var data = ProductService.SortProductByCategory(categoryName);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // 20. sortProductByMinAndMaxRange [Product]
        [HttpGet]
        [Route("api/seller/{sellerId}")]
        public HttpResponseMessage SortProductByMinAndMaxPrice(int minPrice, int maxPrice)
        {
            try
            {
                // brandName er upor base kore product gula niye ashbo
                var data = ProductService.SortProductByMinAndMaxPrice(minPrice, maxPrice);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // 21. createNewMessage [Message]

        // 22. createNewConversation [Conversation]
        // 23. showAllConversation [Conversation]
        // 24. showAllMessageOfAConversation [Conversation]

        // 25. Send Email

    }
}
