using BusinessLogicLayer.DTOs.User;
using DataAccessLayer.EF.Models.UserModel;
using DataAccessLayer.EF.Models.Common.Products;
using DataAccessLayer;
using E_Commerce_Web_Application.Helper.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.DTOs.Product;
using BusinessLogicLayer.DTOs.Seller.Profile;
using DataAccessLayer.EF.Models.Seller.Profile;

namespace BusinessLogicLayer.Services.Product
{
    public class ProductService
    {
        //  1. AddProduct [Product]                                   //🔰OK- - -🔴🔗
        public static ProductDTO CreateProduct(ProductDTO productDto)
        {
            // auto mapper diye convert korte hobe 

            var DTO_ModelMapped = AutoMapperConverter.ConvertForSingleInstance<ProductDTO, Products>(productDto);

            var result = DataAccessFactory.ProductData().Create(DTO_ModelMapped);

            var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<Products, ProductDTO>(result);

            return Model_DTOMapped;
        }


        //  2. getAllProductsDetails [Product]                                   //🔰OK- - -🔴🔗
        public static List<ProductDTO> GetAllProductsDetails()
        {
            var result = DataAccessFactory.ProductData().Get();
            // Model to DTO
            var Model_DTOMapped = AutoMapperConverter.ConvertForList<Products, ProductDTO>(result);

            return Model_DTOMapped;
        }

        // 2.1

        public static List<ProductDTO> GetAllProductsDetailsBySellerId(int sellerId)
        {
            return null;   
        }



        //     addAvailableQualityOfAProduct [Product]                           //🔰OK- - -🔴🔗
        //     addSpecificationOfAProduct [Product]                              //🔰OK- - -🔴🔗
        //  5. paymentCompleteOfPreOrder [Product]                               //🔰OK- - -🔴🔗
        //  6. orderStatusPending [Product]                                      //🔰OK- - -🔴🔗
        //  7. getAllNegetiveReview [Product]                                    //🔰OK- - -🔴🔗

        //  8. checkForLowQuantity [Product]                                     //🔰OK- - -🔴🔗


        // 15. sortProductByBrand [Brand]                                       //🔰OK- - -🔴🔗
        // 16. sortProductByCategory [Category]                                 //🔰OK- - -🔴🔗
        // 17. sortProductByMinAndMaxRange [Product]                            //🔰OK- - -🔴🔗


    }
}
