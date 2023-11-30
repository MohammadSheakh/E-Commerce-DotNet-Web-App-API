using DataAccessLayer.EF;
using DataAccessLayer.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.Seller
{
    public class SellerRepo
    {
        // internal chilo .. public korte hobe 
        // till next week public thakbe .. er pore change kora hobe

        // prottek ta repo te kichu fixed method thakbe ..  

        public static List<string> Get()
        {
            // Get ALl
            // Shob gula ke pathabe .. 
            return null;
        }

        // ekta thakbe single Get 

        public static string Get(int id)
        {
            // id er against e ek ta ke send korbe 
            // SQL
            return id == 110 ? "Tanvir From Data Access Layer" : "Not Found Tanvir From Data Access Layer";
           // return "Tanvir From Data Access Layer";
        }

        // Create -> Database e create korbe 
        // Update ->
        // Delete

        ///////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////

        public static List<EF.Models.Seller> GetAllSeller()
        {
            //all person
            var db = new ECommerceContext();
            return db.Sellers.ToList();
        }
        public static EF.Models.Seller GetOneSeller(int id)
        {
            //id person get
            var db = new ECommerceContext();
            return db.Sellers.Find(id);
        }
        public static void Create(EF.Models.Seller person)
        {
            //insert
            var db = new ECommerceContext();
            db.Sellers.Add(person);
            db.SaveChanges();
        }
        public static void Update(EF.Models.Seller person)
        {
            //update
            var db = new ECommerceContext();
            var ex = db.Sellers.Find(person.Id);
            db.Entry(ex).CurrentValues.SetValues(person);
            db.SaveChanges();
        }
        public static bool Delete(int id)
        {
            //delete
            var db = new ECommerceContext();
            var ex = db.Sellers.Find(id);
            db.Sellers.Remove(ex);
            return db.SaveChanges() > 0;
        }
    }
}
