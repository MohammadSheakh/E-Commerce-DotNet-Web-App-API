using DataAccessLayer.EF.Models.Seller.Profile;
using DataAccessLayer.EF.Models.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.DTOs.User
{
    public class UserDTOWithSellerProfile
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }


        public int? RoleId { get; set; }


        public DateTime? CreatedAt { get; set; }

        /////////////////////////////////////
        
        public virtual SellerProfile SellerProfile { get; set; }
    }
}
