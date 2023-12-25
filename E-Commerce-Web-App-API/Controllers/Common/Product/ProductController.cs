using BusinessLogicLayer.DTOs.Product;
using BusinessLogicLayer.Services.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E_Commerce_Web_App_API.Controllers.Common.Product
{
    public class ProductController : ApiController
    {
        //  1. AddProduct [Product] // status[n-n-n]

        [HttpPost]
        [Route("api/product/createProduct")]  //🔰OK- - -🔴🔗
        public HttpResponseMessage CreateProduct(ProductDTO productDTO)
        {
            try
            {
                var data = ProductService.CreateProduct(productDTO);
                // 🔴 I want to return the product
                return Request.CreateResponse(HttpStatusCode.OK, "New Product Added");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        //  2. getAllProductsDetails [Product]


        [HttpGet] // customized // request override  //🔰OK- - -🔴🔗
        [Route("api/product/getAllProductsDetails")] // custom routing ta add kore dite hobe 
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

        //  2.1. getAllProductsDetailsBySellerId [Product]
        [HttpGet] // customized // request override
        [Route("api/seller/getAllProductsDetailsBySellerId/{sellerId}")]
        // custom routing ta add kore dite hobe 
        //[Pr]
        public HttpResponseMessage GetAllProductsDetailsBySellerId(int id)
        {
            try
            {
                var data = ProductService.GetAllProductsDetailsBySellerId(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        //[HttpGet]
        //[Route("api/seller/getReport")]
        //public HttpResponseMessage GetReport()
        //{
        //    try
        //    {
        //        var AvailableQualityOfAllProduct = ProductService.GetAllAvailableQualityOfAllProduct();
        //        var SpecificationOfAProduct = ProductService.GetAllAvailableQualityOfAllProduct();
               
                
        //        // 🔴🔴
        //        var checkForLowQuantity = ProductService.GetAllAvailableQualityOfAllProduct();
        //        // koyta product and ki ki product shegula dekhate hobe ..

                
        //        var getAllBrandName = ProductService.GetAllAvailableQualityOfAllProduct();
        //        var getAllCategoryName = ProductService.GetAllAvailableQualityOfAllProduct();
        //        //var AvailableQualityOfAllProduct = ProductService.GetAllAvailableQualityOfAllProduct();
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
        //    }
        //}

        

        //  6. addSpecificationOfAProduct [Product]

        //[HttpPost]
        //[Route("api/seller/addSpecificationOfAProduct")]
        //public HttpResponseMessage AddSpecificationOfAProduct(DTO DTO)
        //{
        //    try
        //    {
        //     //   ProductService.AddSpecificationOfAProduct(DTO);
        //        return Request.CreateResponse(HttpStatusCode.OK, "Specification Created");
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
        //    }
        //}

        // 10. checkForLowQuantity [Product]
        [HttpGet]
        [Route("api/seller/checkForLowQuantity/{sellerId}")]
        public HttpResponseMessage CheckForLowQuantity(int sellerId)
        {
            try
            {
                var data = ProductService.CheckForLowQuantity(sellerId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // 15. sortProductByBrand [Brand]
        [HttpGet]
        [Route("api/seller/{brandName}")]
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

        // 16. sortProductByCategory [Category]

        [HttpGet]
        [Route("api/seller/{categoryName}")]
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

        // 17. sortProductByMinAndMaxRange [Product]
        [HttpGet]
        [Route("api/seller/{sellerId}")]
        public HttpResponseMessage SortProductByMinAndMaxPrice(int minPrice, int maxPrice)
        {
            try
            {
                // brandName er upor base kore product gula niye ashbo
                var data =  ProductService.SortProductByMinAndMaxRange(minPrice, maxPrice);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        // 19.1 getAllCategory [Category]

        [HttpGet]
        [Route("api/seller/getAllCategory")]
        public HttpResponseMessage GetAllCategory()
        {
            try
            {

                var data = "";// = ProductService.GetAllCategory();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // 19.2 getAllBrand [Brand]

        [HttpGet]
        [Route("api/seller/getAllBrand")]
        public HttpResponseMessage GetAllBrand()
        {
            try
            {

                var data = "";//= ProductService.GetAllBrand();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        
    }
}
