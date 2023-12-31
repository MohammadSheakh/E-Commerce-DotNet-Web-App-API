using AutoMapper;
using BusinessLogicLayer.DTOs.Common.Order;
using BusinessLogicLayer.DTOs.User;
using DataAccessLayer;
using DataAccessLayer.EF.Models;
using DataAccessLayer.EF.Models.Common.Orders;
using DataAccessLayer.EF.Models.Common.Products;
using DataAccessLayer.EF.Models.UserModel;
using DataAccessLayer.Interface.Common.Order;
using E_Commerce_Web_Application.Helper.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Common.Order
{
    public class CartService
    {
        public static CartViewDto AddToCart (CratCreateDto createDto)
        {
            var cart = AutoMapperConverter.ConvertForSingleInstance<CratCreateDto, Cart>(createDto);
            var result = DataAccessFactory.CartData().Create(cart);
            var cartViewDto = AutoMapperConverter.ConvertForSingleInstance<Cart, CartViewDto>(result);
            return cartViewDto;
        }

        public static List<CartViewDto> GetAllCart()
        {
            var result = DataAccessFactory.CartData().GetAll();
            var cartViewDto = AutoMapperConverter.ConvertForList<Cart, CartViewDto>(result);
            return cartViewDto;
        }

        public static List<CartViewDto> GetAllCartByBuyerId(int buyerProfileId)
        {
            var result = DataAccessFactory.CartData().GetByBuyerId(buyerProfileId);
            var cartViewDto = AutoMapperConverter.ConvertForList<Cart, CartViewDto>(result);
            return cartViewDto;
        }
    }
}
