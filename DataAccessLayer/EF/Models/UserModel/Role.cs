using DataAccessLayer.EF.Models.Seller.Profile.Reviews;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models.UserModel
{
    public class Role
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string RoleName { get; set; }

        public virtual ICollection<User> Users{ get; set; }

        public Role()
        {
            Users = new List<User>(); // initiate kore dite hobe .. 
            // jehetu list .. na hole may be null assign hoye thakbe 
        }


    }
}
