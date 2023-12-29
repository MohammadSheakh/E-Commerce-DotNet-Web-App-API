using AutoMapper;
using BusinessLogicLayer.DTOs.Review;
using DataAccessLayer;
using E_Commerce_Web_Application.Helper.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.EF.Models.Common.Reviews;
using BusinessLogicLayer.DTOs.User;
using DataAccessLayer.EF.Models.UserModel;
using BusinessLogicLayer.DTOs.Common.Review.LikeDislike;

//using ;

namespace BusinessLogicLayer.Services.Common.Review
{
    public class ReviewService
    {
        // //🔰OK- - -🔴🔗
        //  3. addReview [Product] - Tanvir sir er shathe develop kortesi 
        public static ReviewDTO AddReview(ReviewDTO reviewDto)
        {
            // convert DTO -> Model
            var DTO_ModelMapped = AutoMapperConverter.ConvertForSingleInstance<ReviewDTO, DataAccessLayer.EF.Models.Common.Reviews.Review> (reviewDto);

            var result = DataAccessFactory.ReviewData().Create(DTO_ModelMapped);

            var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<DataAccessLayer.EF.Models.Common.Reviews.Review, ReviewDTO>(result);

            return Model_DTOMapped;
        }


        //  4. addReplyToAReview [Product] - Tanvir sir er shathe develop kortesi 
        //🔰OK- - -🔴🔗
        public static ReviewReplyDTO AddReplyToAReview(ReviewReplyDTO reviewReplyDto)
        {
            // convert DTO -> Model
            var DTO_ModelMapped = AutoMapperConverter.ConvertForSingleInstance<ReviewReplyDTO, DataAccessLayer.EF.Models.Common.Reviews.ReviewReply>(reviewReplyDto);

            var result = DataAccessFactory.ReviewReplyData().Create(DTO_ModelMapped);

            var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<DataAccessLayer.EF.Models.Common.Reviews.ReviewReply, ReviewReplyDTO>(result);

            return Model_DTOMapped;
        }

        //🔰OK- - -🔴🔗
        // 4.1 GetAllReviewsByShopProfileIdAndReviewCategory [Seller]
        public static List<ReviewDTO> GetAllReviewsByShopProfileIdAndReviewCategory(int ShopProfileId, string ReviewCategory)
        {
            // data access layer theke data anbo first e .. 
            
            var data = DataAccessFactory.IReviewData().GetAllReviewsByShopProfileIdAndReviewCategory(ShopProfileId, ReviewCategory);


            // eta te DTO te convert na korle application layer use korte parbe na 

            //var cfg = new MapperConfiguration(c =>
            //{
            //    c.CreateMap<Review, ReviewDTO>();
            //});
            //var mapper = new Mapper(cfg);

            //var mapped = mapper.Map<List<ReviewDTO>>(data);

            //var mappedData = AutoMapperConverter.ConvertForList<Review, ReviewDTO>(data);

            var mappedData = AutoMapperConverter.ConvertForList<DataAccessLayer.EF.Models.Common.Reviews.Review, ReviewDTO>(data);


            return mappedData;
        }

        // getAllReview by productId And ReviewCategory //🔰OK- - -🔴🔗
        public static List<ReviewDTO> GetAllReviewsByProductIdAndReviewCategory(int ProductId, string ReviewCategory)
        {
            // data access layer theke data anbo first e .. 

            var data = DataAccessFactory.IReviewData().GetAllReviewsByProductIdAndReviewCategory(ProductId, ReviewCategory);


            // eta te DTO te convert na korle application layer use korte parbe na 

            //var cfg = new MapperConfiguration(c =>
            //{
            //    c.CreateMap<Review, ReviewDTO>();
            //});
            //var mapper = new Mapper(cfg);

            //var mapped = mapper.Map<List<ReviewDTO>>(data);

            //var mappedData = AutoMapperConverter.ConvertForList<Review, ReviewDTO>(data);

            var mappedData = AutoMapperConverter.ConvertForList<DataAccessLayer.EF.Models.Common.Reviews.Review, ReviewDTO>(data);


            return mappedData;
        }

        // 4.2 getAReview [Product] //🔰OK- - -🔴🔗
        public static ReviewDTO GetAReviewByReviewId(int ReviewId)
        {
            // data access layer theke data anbo first e .. 
            var data = DataAccessFactory.ReviewData().Get(ReviewId);
            // eta te DTO te convert na korle application layer use korte parbe na 

            var mappedData = AutoMapperConverter.ConvertForSingleInstance<DataAccessLayer.EF.Models.Common.Reviews.Review, ReviewDTO>(data);

            return mappedData;
        }

        // 4.3 getAReviewWithReviewReplies [Product] //🔰 - - -🔴🔗
        public static Review_ReviewReplyDTO GetAReviewWithReviewReplies(int ReviewId)
        {
            var data = DataAccessFactory.ReviewData().Get(ReviewId);
            var mappedData1 = AutoMapperConverter.ConvertForSingleInstance<DataAccessLayer.EF.Models.Common.Reviews.Review, Review_ReviewReplyDTO>(data);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DataAccessLayer.EF.Models.Common.Reviews.Review, Review_ReviewReplyDTO>();
                c.CreateMap<DataAccessLayer.EF.Models.Common.Reviews.ReviewReply, ReviewReplyDTO>();
            });
            var mapper = new Mapper(cfg);

            var mapped = mapper.Map<Review_ReviewReplyDTO>(data);

            // var mappedData2 = 
            //return mappedData1;
            return mappedData1;
        }

        //  doLikeDislikeToAReview [Product] //🔰 - - -🔴🔗
        public static ReviewDTO DoLikeDislikeToAReview(int ReviewId, int UserId, string LikeDislikeStatus)
        {
            // data access layer theke data anbo first e .. 
            var data = DataAccessFactory.IReviewData().DoLikeDislikeToAReview(ReviewId, UserId, LikeDislikeStatus);
            // eta te DTO te convert na korle application layer use korte parbe na 

            var mappedData = AutoMapperConverter.ConvertForSingleInstance<DataAccessLayer.EF.Models.Common.Reviews.Review, ReviewDTO>(data);

            return mappedData;
        }

        //  getLikeDislikeStatusForReviewIdAndSellerId [Product] //🔰 - - -🔴🔗
        public static LikeDislikeDTOForType GetLikeDislikeStatusForReviewIdAndSellerId(int ReviewId, int UserId)
        {
            // data access layer theke data anbo first e .. 
            var data = DataAccessFactory.IReviewData().GetLikeDislikeStatusForReviewIdAndSellerId(ReviewId, UserId);
            // eta te DTO te convert na korle application layer use korte parbe na  

            var mappedData = AutoMapperConverter.ConvertForSingleInstance<LikeDislike, LikeDislikeDTOForType> (data);

            return mappedData;
        }
    }
}
