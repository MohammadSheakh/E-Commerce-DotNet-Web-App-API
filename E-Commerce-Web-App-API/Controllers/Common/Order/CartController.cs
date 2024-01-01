using BusinessLogicLayer.DTOs.Common.Order;
using BusinessLogicLayer.Services.Common.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace E_Commerce_Web_App_API.Controllers.Common.Order
{
    public class CartController : ApiController
    {
        [HttpPost]
        [Route("api/cart/addToCart")]
        public HttpResponseMessage Create(CratCreateDto createDto)
        {
            try
            {
                var data = CartService.AddToCart(createDto);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Add to cart failed", ex);
            }
        }

        [HttpGet]
        [Route("api/cart/getAllCart")]
        public HttpResponseMessage GetAllCart()
        {
            try
            {
                var data = CartService.GetAllCart();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Get all cart failed", ex);
            }
        }

        [HttpGet]
        [Route("api/cart/getAllCartByBuyerId/{BuyerProfileId}")]
        public HttpResponseMessage GetAllCartByBuyerId(int BuyerProfileId)
        {
            try
            {
                var data = CartService.GetAllCartByBuyerId(BuyerProfileId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Get all cart by buyer id failed", ex);
            }
        }
    }
}