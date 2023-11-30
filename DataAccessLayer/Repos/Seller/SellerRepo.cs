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
    }
}
