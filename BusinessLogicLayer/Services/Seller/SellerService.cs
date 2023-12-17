using AutoMapper;
using BusinessLogicLayer.DTOs.Review;
using BusinessLogicLayer.DTOs.Seller;
using DataAccessLayer;
using DataAccessLayer.EF;
using DataAccessLayer.EF.Models;
using DataAccessLayer.EF.Models.Seller.Profile.Reviews;
using DataAccessLayer.Repos.Seller;
using E_Commerce_Web_Application.Helper.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Seller
{
    // ei class ta public korte hobe ..
    //  normally internal thake 
    public class SellerService
    {
        // public na dile .. baire theke access kora jabe na 

        // er moddhe kichu method thakbe .. jegula application 
        // layer call korbe .. 

        public static string GetName(int id)
        {
            // id ta application layer theke ashbe 
            id += 100;
            // ekhon ei id diye database theke data ante hobe ..
            // data access layer e send korte hobe ..

            // data access layer eo kaoke thakte hobe .. je .. data 
            // ta niye ashbe 
            var data = "";// = sellerrepo.get(id);
            return data;
        }



        //public static List<DTOs.Seller.SellerDTO> GetAllSeller()
        //{
        //    var sellers = SellerRepo.GetAllSeller();

        //    var autoMapper = new AutoMapperConverter();

        //    //var ret = mapper.Map<List<PersonDTO>>(data);
        //    var ret =  autoMapper.ConvertForList<DataAccessLayer.EF.Models.Seller, SellerDTO>(sellers);

        //    return ret;
        //}



        //public static DTOs.Seller.SellerDTO GetOneSeller(int id)
        //{
        //    var seller = SellerRepo.GetOneSeller(id);

        //    var autoMapper = new AutoMapperConverter();

        //    var ret = autoMapper.ConvertForSingleInstance<DataAccessLayer.EF.Models.Seller, SellerDTO>(seller); ;
        //    return ret;
        //}



        //public static void Create(PersonDTO p)
        //{
        //    var config = new MapperConfiguration(cfg => {
        //        cfg.CreateMap<PersonDTO, Person>();
        //    });
        //    var mapper = new Mapper(config);
        //    var data = mapper.Map<Person>(p);
        //    PersonRepo.Create(data);
        //}

        /////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////

        //  1. AddProduct [Product]
        //  2. getAllProductsDetails [Product]


        //public static List<DTOs.Seller.SellerDTO> GetAllSeller()
        //{
        //    var sellers = SellerRepo.GetAllSeller();

        //    var autoMapper = new AutoMapperConverter();

        //    //var ret = mapper.Map<List<PersonDTO>>(data);
        //    var ret = autoMapper.ConvertForList<DataAccessLayer.EF.Models.Seller, SellerDTO>(sellers);

        //    return ret;
        //}



        //  3. addReview [Product] - Tanvir sir er shathe develop kortesi 



        //  4. addReplyToAReview [Product] - Tanvir sir er shathe develop kortesi 

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

            var mappedData = AutoMapperConverter.ConvertForList<Review, ReviewDTO>(data);


            return mappedData;
        }

        // 4.2 getAReview [Product]
        public static ReviewDTO GetAReview(int id)
        {
            // data access layer theke data anbo first e .. 
            var data = DataAccessFactory.ReviewData().Get(id);
            // eta te DTO te convert na korle application layer use korte parbe na 

            var mappedData = AutoMapperConverter.ConvertForSingleInstance<Review, ReviewDTO>(data);


            return mappedData;
        }

        // 4.3 getAReviewWithReviewReplies [Product]
        public static Review_ReviewReplyDTO GetAReviewWithReviewReplies(int id)
        {
            var data = DataAccessFactory.ReviewData().Get(id);
            var mappedData1 = AutoMapperConverter.ConvertForSingleInstance<Review, Review_ReviewReplyDTO>(data);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Review, Review_ReviewReplyDTO>();
                c.CreateMap<ReviewReply, ReviewReplyDTO>();
            });
            var mapper = new Mapper(cfg);


            var mapped = mapper.Map<Review_ReviewReplyDTO>(data);


           // var mappedData2 = 

            return mappedData1;
        }



        //     addAvailableQualityOfAProduct [Product]
        //     addSpecificationOfAProduct [Product]
        //  5. paymentCompleteOfPreOrder [Product]
        //  6. orderStatusPending [Product]
        //  7. getAllNegetiveReview [Product]

        //  8. checkForLowQuantity [Product]

        //  9. Seller Login basic/jwt [Seller]
        // 10. Seller Logout[Seller]
        // 11. createNewSeller [Seller]
        // 12. getAllSeller [Seller]

        // 13. updateSellerInformation [Seller]
        // 14. deleteSellerAccount [Seller]

        // 15. sortProductByBrand [Brand]
        // 16. sortProductByCategory [Category]
        // 17. sortProductByMinAndMaxRange [Product]

        // 18. createNewMessage [Message]
        // 19. createNewConversation [Conversation]
        // 20. showAllConversation [Conversation]
        // 21. showAllMessageOfAConversation [Conversation]

        // 22. Send Email
    }
}
