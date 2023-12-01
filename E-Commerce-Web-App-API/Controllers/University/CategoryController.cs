using BusinessLogicLayer.DTOs.University;
using BusinessLogicLayer.Services.Seller;
using BusinessLogicLayer.Services.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E_Commerce_Web_App_API.Controllers.University
{
    public class CategoryController : ApiController
    {
        [HttpGet] // customized // request override
        [Route("api/category/{id}")] // custom routing ta add kore dite hobe 
        public HttpResponseMessage GetOneCategory(int id)
        {
            try
            {
                var data = CategoryService.GetOneCategory(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost] // customized // request override
        [Route("api/category/create")] // custom routing ta add kore dite hobe 
        public HttpResponseMessage CreateCategory(CategoryDTO categoryDTO)
        {
            try
            {
                CategoryService.CreateCategory(categoryDTO);
                return Request.CreateResponse(HttpStatusCode.OK, "Category Added");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
