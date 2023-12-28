﻿using AutoMapper;
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

//using ;

namespace BusinessLogicLayer.Services.Common.Review
{
    public class ReviewService
    {
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

        public static ReviewReplyDTO AddReplyToAReview(ReviewReplyDTO reviewReplyDto)
        {
            // convert DTO -> Model
            var DTO_ModelMapped = AutoMapperConverter.ConvertForSingleInstance<ReviewReplyDTO, DataAccessLayer.EF.Models.Common.Reviews.ReviewReply>(reviewReplyDto);

            var result = DataAccessFactory.ReviewReplyData().Create(DTO_ModelMapped);

            var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<DataAccessLayer.EF.Models.Common.Reviews.ReviewReply, ReviewReplyDTO>(result);

            return Model_DTOMapped;
        }


        // 4.1 getAllReview [Seller]
        public static List<ReviewDTO> GetAllReview()
        {
            // data access layer theke data anbo first e .. 
            
            var data = DataAccessFactory.ReviewData().Get();


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

        // 4.2 getAReview [Product]
        public static ReviewDTO GetAReview(int id)
        {
            // data access layer theke data anbo first e .. 
            var data = DataAccessFactory.ReviewData().Get(id);
            // eta te DTO te convert na korle application layer use korte parbe na 

            var mappedData = AutoMapperConverter.ConvertForSingleInstance<DataAccessLayer.EF.Models.Common.Reviews.Review, ReviewDTO>(data);

            return mappedData;
        }

        // 4.3 getAReviewWithReviewReplies [Product]
        public static Review_ReviewReplyDTO GetAReviewWithReviewReplies(int id)
        {
            var data = DataAccessFactory.ReviewData().Get(id);
            var mappedData1 = AutoMapperConverter.ConvertForSingleInstance<DataAccessLayer.EF.Models.Common.Reviews.Review, Review_ReviewReplyDTO>(data);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DataAccessLayer.EF.Models.Common.Reviews.Review, Review_ReviewReplyDTO>();
                c.CreateMap<DataAccessLayer.EF.Models.Common.Reviews.ReviewReply, ReviewReplyDTO>();
            });
            var mapper = new Mapper(cfg);


            var mapped = mapper.Map<Review_ReviewReplyDTO>(data);


            // var mappedData2 = 

            return mappedData1;
        }
    }
}
