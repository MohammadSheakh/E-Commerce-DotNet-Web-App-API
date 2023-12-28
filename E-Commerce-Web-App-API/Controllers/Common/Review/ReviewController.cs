using BusinessLogicLayer.DTOs.Review;
using BusinessLogicLayer.Services.Product;
using BusinessLogicLayer.Services.Seller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLogicLayer.Services.Common.Review;

namespace E_Commerce_Web_App_API.Controllers.Common.Review
{
    public class ReviewController : ApiController
    {
        //  3. addReview [Product] // Seller er jonno o review add kora lagbe .. product er jonno o review add korte hobe 

        [HttpPost]
        [Route("api/review/addReview")] //🔰OK- - -🔴🔗
        public HttpResponseMessage AddReview(ReviewDTO reviewDTO)
        {
            // product er kono aftersales experience hobe na .. 
            // shop er afterSalesExperience hobe .. 
            try
            {
                var data =  ReviewService.AddReview(reviewDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        //  4. addReplyToAReview [Product]

        [HttpPost]
        [Route("api/review/addReplyToAReview")]
        public HttpResponseMessage AddReplyToReview(ReviewReplyDTO reviewReplyDTO)
        {
            try
            {
                var data =  ReviewService.AddReplyToAReview(reviewReplyDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        // 4.1 getAllReview by shopProfile Id And reviewCategory
        [HttpGet]
        [Route("api/review/seller/all")]
        public HttpResponseMessage GetAllReviewsByShopProfileIdAndReviewCategory([FromUri] int ShopProfileId, [FromUri] string ReviewCategory)
        {
            try
            {
                var data = ReviewService.GetAllReviewsByShopProfileIdAndReviewCategory(ShopProfileId, ReviewCategory);
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


        // 4.1.1 getAllReview by product Id And reviewCategory
        [HttpGet]
        [Route("api/review/product/all")]
        public HttpResponseMessage GetAllReviewsByProductIdAndReviewCategory([FromUri] int ProductId, [FromUri] string ReviewCategory)
        {
            try
            {
                var data = ReviewService.GetAllReviewsByProductIdAndReviewCategory(ProductId, ReviewCategory);
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
        [Route("api/review/")] // {reviewId}
        public HttpResponseMessage GetAReviewByReviewId([FromUri] int ReviewId)
        {
            try
            {
                var data = ReviewService.GetAReviewByReviewId(ReviewId);
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
        [Route("api/seller/GetAReviewWithReviewReplies/")] //{id}
        public HttpResponseMessage GetAReviewWithReviewReplies([FromUri] int ReviewId)
        {
            try
            {
                var data = ReviewService.GetAReviewWithReviewReplies(ReviewId);
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


        ////  9. getAllNegetiveReview [Product]

        //[HttpGet]
        //[Route("api/seller/getAllNegetiveReview")]
        //public HttpResponseMessage GetAllNegetiveReview()
        //{
        //    try
        //    {
        //        var data = "";// ReviewService.GetAllNegetiveReview();
        //        return Request.CreateResponse(HttpStatusCode.OK, data);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
        //    }
        //}


        // doLikeDislikeToAReview

        // getLikeDislikeStatusForAReview
        

        
    }
}
