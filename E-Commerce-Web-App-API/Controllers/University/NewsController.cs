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
    public class NewsController : ApiController
    {
        [HttpGet] // customized // request override
        [Route("api/news/{id}")] // custom routing ta add kore dite hobe 
        public HttpResponseMessage GetOneNews(int id)
        {
            try
            {
                var data = NewsService.GetOneNews(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost] // customized // request override
        [Route("api/news/create")] // custom routing ta add kore dite hobe 
        public HttpResponseMessage CreateNews(NewsDTO newsDTO)
        {
            try
            {
                NewsService.CreateNews(newsDTO);

                return Request.CreateResponse(HttpStatusCode.OK, "News Added");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
