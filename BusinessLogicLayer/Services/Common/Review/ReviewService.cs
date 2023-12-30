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
        public static CreateReviewDTO AddReview(CreateReviewDTO reviewDto)
        {
            // convert DTO -> Model
            var DTO_ModelMapped = AutoMapperConverter.ConvertForSingleInstance<CreateReviewDTO, DataAccessLayer.EF.Models.Common.Reviews.Review> (reviewDto);

            var result = DataAccessFactory.ReviewData().Create(DTO_ModelMapped);

            var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<DataAccessLayer.EF.Models.Common.Reviews.Review, CreateReviewDTO>(result);

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
        public static List<CreateReviewDTO> GetAllReviewsByShopProfileIdAndReviewCategory(int ShopProfileId, string ReviewCategory)
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

            var mappedData = AutoMapperConverter.ConvertForList<DataAccessLayer.EF.Models.Common.Reviews.Review, CreateReviewDTO>(data);


            return mappedData;
        }

        // getAllReview by productId And ReviewCategory //🔰OK- - -🔴🔗
        public static List<CreateReviewDTO> GetAllReviewsByProductIdAndReviewCategory(int ProductId, string ReviewCategory)
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

            var mappedData = AutoMapperConverter.ConvertForList<DataAccessLayer.EF.Models.Common.Reviews.Review, CreateReviewDTO>(data);


            return mappedData;
        }

        // 4.2 getAReview [Product] //🔰OK- - -🔴🔗
        public static CreateReviewDTO GetAReviewByReviewId(int ReviewId)
        {
            // data access layer theke data anbo first e .. 
            var data = DataAccessFactory.ReviewData().Get(ReviewId);
            // eta te DTO te convert na korle application layer use korte parbe na 

            var mappedData = AutoMapperConverter.ConvertForSingleInstance<DataAccessLayer.EF.Models.Common.Reviews.Review, CreateReviewDTO>(data);

            return mappedData;
        }

        // 4.3 getAReviewWithReviewReplies [Product] //🔰 - - -🔴🔗
        public static Review_ReviewReplyDTO GetAReviewWithReviewReplies(int ReviewId)
        {
            var reviewEntity = DataAccessFactory.ReviewData().Get(ReviewId);
            var mappedData1 = AutoMapperConverter.ConvertForSingleInstance<DataAccessLayer.EF.Models.Common.Reviews.Review, Review_ReviewReplyDTO>(reviewEntity);

            //var cfg = new MapperConfiguration(c =>
            //{
            //    c.CreateMap<DataAccessLayer.EF.Models.Common.Reviews.Review, ReviewDTO>();
            //    c.CreateMap<DataAccessLayer.EF.Models.Common.Reviews.ReviewReply, ReviewReplyDTO>();
            //});
            //var mapper = new Mapper(cfg);

            //var mapped = mapper.Map<Review_ReviewReplyDTO>(reviewEntity);

            // var mappedData2 = 
            return mappedData1;
            //return mapped;


            
            //var reviewDTO = new ReviewDTO
            //{
            //    Id = reviewEntity.Id,
            //    Category = reviewEntity.Category,
            //    ReviewDetails = reviewEntity.ReviewDetails,
            //    CreatedAt = reviewEntity.CreatedAt,
            //    LikeCount = reviewEntity.LikeCount,
            //    DisLikeCount = reviewEntity.DisLikeCount,
            //    ProductId = reviewEntity.ProductId,
            //    ShopProfileId = reviewEntity.ShopProfileId,
            //    PostedBy = reviewEntity.PostedBy,
            //    User = new UserDTO // Assuming you have a UserDTO class
            //    {
            //        // Map user properties here
            //    },
            //    LikeDislikes = reviewEntity.LikeDislikes.Select(ld => new LikeDislikeDTO
            //    {
            //        // Map LikeDislike properties here
            //    }).ToList(),
            //    ReviewReplies = reviewEntity.ReviewReplies.Select(rr => new ReviewReplyDTO
            //    {
            //        Id = rr.Id,
            //        ReplyDetails = rr.ReplyDetails,
            //        CreatedAt = rr.CreatedAt,
            //        PostedBy = rr.PostedBy,
            //        ReviewId = rr.ReviewId,
            //        User = new UserDTO // Assuming you have a UserDTO class
            //        {
            //            // Map user properties here
            //        }
            //    }).ToList()
            //};

            //return new Review_ReviewReplyDTO
            //{
            //    Review = reviewDTO
            //    // Other properties of Review_ReviewReplyDTO if any
            //};
        }

        //  doLikeDislikeToAReview [Product] //🔰 - - -🔴🔗
        public static CreateReviewDTO DoLikeDislikeToAReview(int ReviewId, int UserId, string LikeDislikeStatus)
        {
            // data access layer theke data anbo first e .. 
            var data = DataAccessFactory.IReviewData().DoLikeDislikeToAReview(ReviewId, UserId, LikeDislikeStatus);
            // eta te DTO te convert na korle application layer use korte parbe na 

            var mappedData = AutoMapperConverter.ConvertForSingleInstance<DataAccessLayer.EF.Models.Common.Reviews.Review, CreateReviewDTO>(data);

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
