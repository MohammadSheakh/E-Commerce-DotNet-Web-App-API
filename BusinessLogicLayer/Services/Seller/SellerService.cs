using AutoMapper;
using BusinessLogicLayer.DTOs.Common.Product;
using BusinessLogicLayer.DTOs.Product;
using BusinessLogicLayer.DTOs.Review;
using BusinessLogicLayer.DTOs.Seller;
using DataAccessLayer;
using DataAccessLayer.EF;
using DataAccessLayer.EF.Models;
using DataAccessLayer.EF.Models.Common.Products;
using DataAccessLayer.EF.Models.Common.Reviews;
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


        // 1 done
        public static ProductDTO GetProductsByLargestAvailableQuantity(int SellerId)
        {
            var products = DataAccessFactory.IProductData().GetProductsByLargestAvailableQuantity(SellerId);
            // Model To DTO 
            var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<Products, ProductDTO>(products);

            //return products;
            return Model_DTOMapped;
        }


        // 2 done
        public static List<ProductDTO> GetProductsByRatingLessThanRatingLimit(int SellerId, int RatingLimit)
        {
            var products = DataAccessFactory.IProductData().GetProductsByRatingLessThanRatingLimit(SellerId, RatingLimit);
            var Model_DTOMapped = AutoMapperConverter.ConvertForList<Products, ProductDTO>(products);

            //return products;
            return Model_DTOMapped;
        }

        // 3 done
        public static List<ProductDTOForReport> GetProductsNoReviews(int SellerId)
        {
            var products = DataAccessFactory.IProductData().GetProductsNoReviews(SellerId);
            // Model To DTO 
            //var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<Products, ProductDTO>(result);
            var Model_DTOMapped = AutoMapperConverter.ConvertForList<Products, ProductDTOForReport>(products);

            return Model_DTOMapped;
        }

        // 4
        public static List<ProductDTOForReport> GetProductsWithLowStock(int SellerId)
        {
            var products = DataAccessFactory.IProductData().GetProductsWithLowStock(SellerId);
            // Model To DTO 
            var Model_DTOMapped = AutoMapperConverter.ConvertForList<Products, ProductDTOForReport>(products);

            return Model_DTOMapped;
        }


        // 5 // age order list jante hobe ... 
        public static List<Products> GetALLBestSellingProduct(int SellerId)
        {
            var products = DataAccessFactory.IProductData().GetALLBestSellingProduct(SellerId);
            // Model To DTO 
            //var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<Products, ProductDTO>(result);

            return products;
        }


        // 6
        public static List<ProductDTOForReport> GetALLOutOfStockProduct(int SellerId)
        {
            var products = DataAccessFactory.IProductData().GetALLOutOfStockProduct(SellerId);
            // Model To DTO 
            var Model_DTOMapped = AutoMapperConverter.ConvertForList<Products, ProductDTOForReport>(products);

            return Model_DTOMapped;
        }

        // 7
        public static List<ProductDTOForReport> GetALLProductsWithHighRatings(int SellerId)
        {
            var products = DataAccessFactory.IProductData().GetALLProductsWithHighRatings(SellerId);
            // Model To DTO 
            var Model_DTOMapped = AutoMapperConverter.ConvertForList<Products, ProductDTOForReport>(products);

            return Model_DTOMapped;
        }

        // 8
        public static List<ProductDTOForReport> GetALLProductAddInSpecificTimeRange(int SellerId, StartAndEndDatetimeDTO startAndEndDateTimeDto)
        {
            var products = DataAccessFactory.IProductData().GetALLProductAddInSpecificTimeRange(SellerId, startAndEndDateTimeDto.StartDate, startAndEndDateTimeDto.EndDate);
            // Model To DTO 
            var Model_DTOMapped = AutoMapperConverter.ConvertForList<Products, ProductDTOForReport>(products);
            return Model_DTOMapped;
        }

        

    }
}
