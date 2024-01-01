using DataAccessLayer.EF.Models.Common.Orders;
using DataAccessLayer.Helper;
using DataAccessLayer.Interface.Common.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.CommonRepos.OrderRepos
{
    internal class CartRepo : Repo, ICart<Cart, int>
    {
        public Cart Create(Cart obj)
        {
            obj.CartId = GenerateId.MakeId();
            obj.CreatedDate = DateTime.UtcNow;
            var create = db.Carts.Add(obj);
            db.SaveChanges();
            return create;
        }

        public bool Delete(int id)
        {
            var delete = db.Carts.FirstOrDefault(u => u.Id == id);
            db.Carts.Remove(delete);
            return db.SaveChanges() != 0;
        }

        public List<Cart> GetAll()
        {
            var carts = db.Carts.ToList();
            return carts;
        }

        public List<Cart> GetByBuyerId(int buyerId)
        {
            var carts = db.Carts.Where(u => u.BuyerProfileId == buyerId).ToList();
            return carts;
        }

        public Cart Update(Cart obj)
        {
            var cart = db.Carts.FirstOrDefault(u => u.Id == obj.Id);
            cart.Quantity = obj.Quantity;
            cart.UpdatedDate = DateTime.Now.Date;
            db.SaveChanges();
            return cart;
        }
    }
}
