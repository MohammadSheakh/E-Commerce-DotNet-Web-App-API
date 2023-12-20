using DataAccessLayer.EF.Models.Seller.Profile.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models
{
    public class Buyer
    {
        //prop
        public int Id { get; set; }

        public DateTime? DOB { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }


        // One buyer can have Many Order

        public virtual ICollection<Order> Orders { get; set; }

        public Buyer()
        {
            Orders = new List<Order>(); // initiate kore dite hobe .. 
            // jehetu list .. na hole may be null assign hoye thakbe 
        }
    }
}
