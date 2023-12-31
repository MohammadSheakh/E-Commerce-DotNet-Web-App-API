﻿using BusinessLogicLayer.DTOs.User;
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
using BusinessLogicLayer.DTOs.Common.Product.Brand_And_Category;
using BusinessLogicLayer.DTOs.Common.Product.Specifications;
using DataAccessLayer.EF.Models.Product.Specifications;

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

        // 2.1 GetAllProductsDetailsBySellerId  //🔰 - - -🔴🔗
        public static List<ProductDTO> GetAllProductsDetailsBySellerId(int sellerId)
        {
            // seller id er against e shob gula product niye ashte hobe
            var allProductsOfSeller = DataAccessFactory.IProductData().GetAllProductsDetailsBySellerId(sellerId);

            // jei data ashse .. eta ke Model -> DTO te convert korte hobe
            var Model_DTOMapped = AutoMapperConverter.ConvertForList<Products, ProductDTO>(allProductsOfSeller);

            return Model_DTOMapped;   
        }

        // 8 checkForLowQuantity //🔰 - - -🔴🔗
        public static List<ProductDTO> CheckForLowQuantity(int sellerId)
        {
            // ekta seller er under e jei product gula ase .. shegular moddhe jegula low quantity 
            // shegula list return korbe 

            var allLowQuantityProductForSeller = DataAccessFactory.IProductData().GetALlLowQuantityProductForSellerId(sellerId);

            // Model To DTO Convert korte hobe .. 
            var Model_DTOMapped = AutoMapperConverter.ConvertForList<Products, ProductDTO>(allLowQuantityProductForSeller);

            return Model_DTOMapped;
        }


        /**
         
                    Order er upor 
            // dekhte hobe kon product er upor koto gula order place kora hoise 
            // dekhte hobe kon quality er upor koto gula order place kora hoise .. 
            // dekhte hobe orderStatusPending kader 
            // dekhte hobe Cash on Delevery kon Order gular .. 
            // jei product gular kono negetive review nai .. shegular total count and 
                  // shegular tag e add hobe no_negetive_review 
            // jei product gular 50% or er beshi review negetive shegular total count 
                  // shegular list return korte hobe 
            // 
        */

        //     addAvailableQualityOfAProduct [Product]                           //🔰OK- - -🔴🔗
        //     addSpecificationOfAProduct [Product]                              //🔰OK- - -🔴🔗
        //  5. paymentCompleteOfPreOrder [Product]                               //🔰OK- - -🔴🔗
        //  6. orderStatusPending [Product]                                      //🔰OK- - -🔴🔗
        //  7. getAllNegetiveReview [Product]                                    //🔰OK- - -🔴🔗


        // 15. sortProductByBrand [Brand]                                       //🔰 - - -🔴🔗
        public static List<ProductDTO> SortProductByBrand(string brandName)
        {
            // ekta seller er under e jei product gula ase .. shegular moddhe jegula low quantity 
            // shegula list return korbe 

            var allLowQuantityProductForSeller = DataAccessFactory.IProductData().sortProductByBrand(brandName);

            // Model To DTO Convert korte hobe .. 
            var Model_DTOMapped = AutoMapperConverter.ConvertForList<Products, ProductDTO>(allLowQuantityProductForSeller);


            return Model_DTOMapped;
        }

        // 16. sortProductByCategory [Category]                                 //🔰 - - -🔴🔗
        public static List<ProductDTO> SortProductByCategory(string categoryName)
        {
            // ekta seller er under e jei product gula ase .. shegular moddhe jegula low quantity 
            // shegula list return korbe 

            var allLowQuantityProductForSeller = DataAccessFactory.IProductData().sortProductByCategory(categoryName);

            // Model To DTO Convert korte hobe .. 
            var Model_DTOMapped = AutoMapperConverter.ConvertForList<Products, ProductDTO>(allLowQuantityProductForSeller);


            return Model_DTOMapped;
        }

        // 17. sortProductByMinAndMaxRange [Product]                            //🔰 - - -🔴🔗
        public static List<ProductDTO> SortProductByMinAndMaxRange(int? minValue, int? maxValue)
        {
            // ekta seller er under e jei product gula ase .. shegular moddhe jegula low quantity 
            // shegula list return korbe 

            var allLowQuantityProductForSeller = DataAccessFactory.IProductData().sortProductByMinAndMaxRange(minValue, maxValue);

            // Model To DTO Convert korte hobe .. 
            var Model_DTOMapped = AutoMapperConverter.ConvertForList<Products, ProductDTO>(allLowQuantityProductForSeller);


            return Model_DTOMapped;
        }


        // 19.1 getAllCategory
        public static List<CategoryDTO> GetAllCategory()
        {
            var result = DataAccessFactory.CategoryData().Get();

            var Model_DTOMapped = AutoMapperConverter.ConvertForList<Category, CategoryDTO>(result);


            return Model_DTOMapped;
        }
        // 19.2 getAllBrand
        public static List<BrandDTO> GetAllBrand()
        {
            var result = DataAccessFactory.BrandData().Get();

            var Model_DTOMapped = AutoMapperConverter.ConvertForList<Brand, BrandDTO>(result);
            
            return Model_DTOMapped;
        }

        // 19.3 Search Product by productName ,


        public static List<ProductDTO> SearchProductByCategory(string searchValue, string categoryType)
        {

            // category er upor base kore  data pull kore niye ashbo  
           
            if(categoryType == "category")
            {
                // category er upor base kore shob product show korte hobe
                var products = DataAccessFactory.IProductData().sortProductByCategory(searchValue);

                //Model To DTO Convert korte hobe .. 
                var Model_DTOMapped = AutoMapperConverter.ConvertForList<Products, ProductDTO>(products);


                return Model_DTOMapped;
            }
            if (categoryType == "brand")
            {
                // brand er upor base kore shob product show korte hobe
                var products = DataAccessFactory.IProductData().sortProductByBrand(searchValue);
                var Model_DTOMapped = AutoMapperConverter.ConvertForList<Products, ProductDTO>(products);


                return Model_DTOMapped;
            }
            if (categoryType == "product")
            {
                // productName er upor base kore shob product show korte hobe
                var products = DataAccessFactory.IProductData().searchProductBySearchValue(searchValue);
                var Model_DTOMapped = AutoMapperConverter.ConvertForList<Products, ProductDTO>(products);


                return Model_DTOMapped;
            }

            return null;
        }

        public static SpecificaitonCategoryDTO AddSpecificationCategory(SpecificaitonCategoryDTO specificationCategoryDTO)
        {
            var DTO_ModelMapped = AutoMapperConverter.ConvertForSingleInstance<SpecificaitonCategoryDTO, SpecificationCategory>(specificationCategoryDTO);

            var result = DataAccessFactory.IProductSpecificationData().AddSpecificationCategory(DTO_ModelMapped);

            var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<SpecificationCategory, SpecificaitonCategoryDTO>(result);
            
            return Model_DTOMapped;
        }

        public static SpecificationDTO AddSpecification(SpecificationDTO specificationDTO)
        {
            var DTO_ModelMapped = AutoMapperConverter.ConvertForSingleInstance<SpecificationDTO, Specification>(specificationDTO);

            var result = DataAccessFactory.IProductSpecificationData().AddSpecification(DTO_ModelMapped);

            var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<Specification, SpecificationDTO>(result);

            return Model_DTOMapped;
        }
    }
}
