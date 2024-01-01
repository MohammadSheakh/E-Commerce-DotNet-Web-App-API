using DataAccessLayer.EF.Models.Common.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models
{
    public class BuyerProfile
    {
        //prop
        public int Id { get; set; }

        public string PreferedPaymentMethod { get; set; }

        public string PreferredLanguage { get; set; }

        // One buyer can have Many Order

        public virtual ICollection<Order> Orders { get; set; }

        public BuyerProfile()
        {
            Orders = new List<Order>(); // initiate kore dite hobe .. 
            // jehetu list .. na hole may be null assign hoye thakbe 
        }
    }
}
