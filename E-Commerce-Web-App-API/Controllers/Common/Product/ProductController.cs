using BusinessLogicLayer.DTOs.Common.Product.Specifications;
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

    //[Route("api/Product")]
    //[Route("api/[controller]")]

    public class ProductController : ApiController
    {
        
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
        // api/products/all

        [HttpGet] // customized // request override  //🔰OK- - -🔴🔗
        [Route("api/product/all")] // custom routing ta add kore dite hobe 
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
        [Route("api/product/all/by/")]// {sellerId} .. params e na send kore query te send korbo 
        // api/product/all/by/?sellerId=43434
        public HttpResponseMessage GetAllProductsDetailsBySellerId([FromUri] int sellerId)
        {
            try
            {
                var data = ProductService.GetAllProductsDetailsBySellerId(sellerId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        

        

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
        [Route("api/product/checkForLowQuantity/")] // {sellerId}
        // [FromUri] int sellerId, [FromUri] string category
        public HttpResponseMessage CheckForLowQuantity([FromUri] int sellerId)
        {
            try
            {
                //var data = ProductService.CheckForLowQuantity(sellerId);
                return Request.CreateResponse(HttpStatusCode.OK, "Hello");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // 15. sortProductByBrand [Brand]
        [HttpGet]
        [Route("api/product/")] // {brandName}
        public HttpResponseMessage SortProductByBrand([FromUri] string sortBy)
        {
            try
            {
                // brandName er upor base kore product gula niye ashbo

                if(sortBy == "Brand")
                {

                }if(sortBy == "Category")
                {

                }

                var data = ProductService.SortProductByBrand(sortBy);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // 16. sortProductByCategory [Category]

        //[HttpGet]
        //[Route("api/seller/{categoryName}")]
        //public HttpResponseMessage SortProductByCategory(string categoryName)
        //{
        //    try
        //    {
        //        // brandName er upor base kore product gula niye ashbo
        //        var data = ProductService.SortProductByCategory(categoryName);
        //        return Request.CreateResponse(HttpStatusCode.OK, data);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
        //    }
        //}

        // 17. sortProductByMinAndMaxRange [Product]
        [HttpGet]
        [Route("api/product/")]
        public HttpResponseMessage SortProductByMinAndMaxPrice([FromUri] int minPriceRange, [FromUri] int maxPriceRange)
        {
            try
            {
                // min value na thakle .. min value 0 assign hobe .. 
                // max value na thakle 
                var data =  ProductService.SortProductByMinAndMaxRange(minPriceRange, maxPriceRange);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        // 19.1 getAllCategory [Category]

        [HttpGet]
        [Route("api/product/getAllCategory")]
        public HttpResponseMessage GetAllCategory()
        {
            try
            {
                var data = ProductService.GetAllCategory();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // 19.2 getAllBrand [Brand]

        [HttpGet]
        [Route("api/product/getAllBrand")]
        public HttpResponseMessage GetAllBrand()
        {
            try
            {

                var data = ProductService.GetAllBrand();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // 19.3 Search Product by productName ,
        // //// also option pass kora jabe .. name select korle name search korbe
        ////// id pass korle id diye search hobe 
        ////// category pass korle category diye search hobe 
        /////  brand pass korle brand diye search hobe .. 
        ///

        [HttpGet]
        [Route("api/product/searchProduct/")] // 🔴 query kivabe send korbo ? 
        public HttpResponseMessage SearchProductByCategory([FromUri] string searchValue, [FromUri] string categoryType)
        {
            try
            {

                var data = ProductService.SearchProductByCategory(searchValue, categoryType);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        [HttpPost]
        [Route("api/product/specificationCategory/")] // 🔴 query kivabe send korbo ? 
        public HttpResponseMessage AddSpecificationCategory(SpecificaitonCategoryDTO specificationCategoryDto)
        {
            try
            {

                var data = ProductService.AddSpecificationCategory(specificationCategoryDto);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        [HttpPost]
        [Route("api/product/specification/")] // 🔴 query kivabe send korbo ? 
        public HttpResponseMessage AddSpecification(SpecificationDTO specificationDto)
        {
            try
            {
                var data = ProductService.AddSpecification(specificationDto);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
