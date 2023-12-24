using BusinessLogicLayer.DTOs.Review;
using BusinessLogicLayer.Services.Seller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E_Commerce_Web_App_API.Controllers.Common.Review
{
    public class ReviewController : ApiController
    {


        //  3. addReview [Product] // Seller er jonno o review add kora lagbe .. product er jonno o review add korte hobe 

        [HttpPost]
        [Route("api/seller/addReview")]
        public HttpResponseMessage AddReview(ReviewDTO reviewDTO)
        {
            try
            {
                //ProductService.AddReview(reviewDTO);
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
                //ProductService.AddReplyToReview(reviewReplyDTO);
                return Request.CreateResponse(HttpStatusCode.OK, "Review Reply Created");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        // 4.1 getAllReview
        [HttpGet]
        [Route("api/seller/getAllReview")]
        public HttpResponseMessage GetAllReviews()
        {
            try
            {
                var data = SellerService.GetAllReview();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
                // string na send kore annonymous object hishebe send korte chaile
                // json object hishebe jabe 
                //🟢😢🔴  return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message : ex.Message  });
            }
        }


        // 4.2 

        [HttpGet]
        [Route("api/seller/getAReview/{id}")]
        public HttpResponseMessage GetAReview(int id)
        {
            try
            {
                var data = SellerService.GetAReview(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
                // string na send kore annonymous object hishebe send korte chaile
                // json object hishebe jabe 
                //🟢😢🔴  return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message : ex.Message  });
            }
        }

        // 4.3

        [HttpGet]
        [Route("api/seller/GetAReviewWithReviewReplies/{id}")]
        public HttpResponseMessage GetAReviewWithReviewReplies(int id)
        {
            try
            {
                var data = SellerService.GetAReviewWithReviewReplies(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
                // string na send kore annonymous object hishebe send korte chaile
                // json object hishebe jabe 
                //🟢😢🔴  return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message : ex.Message  });
            }
        }



        // 4--. 
        // 4-- Show All Review For Product By Category
        // 4-- Show All Review For Seller By Category


        //  9. getAllNegetiveReview [Product]

        [HttpGet]
        [Route("api/seller/getAllNegetiveReview")]
        public HttpResponseMessage GetAllNegetiveReview()
        {
            try
            {
                var data = "";//= ProductService.GetAllNegetiveReview();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        
    }
}
