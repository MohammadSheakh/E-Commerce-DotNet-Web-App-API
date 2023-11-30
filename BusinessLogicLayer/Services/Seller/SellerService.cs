using DataAccessLayer.Repos.Seller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Seller
{
    // ei class ta public korte hobe ..
    //  normally internal thake 
    public class SellerService
    {
        // public na dile .. baire theke access kora jabe na 

        // er moddhe kichu method thakbe .. jegula application 
        // layer call korbe .. 

        public static string GetName(int id)
        {
            // id ta application layer theke ashbe 
            id  += 100;
            // ekhon ei id diye database theke data ante hobe ..
            // Data Access Layer e send korte hobe ..

            // Data Access Layer eo kaoke thakte hobe .. je .. data 
            // ta niye ashbe 
            var data =  SellerRepo.Get(id);
            return data;
        }
    }
}
