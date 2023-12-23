using DataAccessLayer.EF.Models.Common.Reviews;
using DataAccessLayer.EF.Models.Seller.Profile;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models.UserModel
{
    public class User
    {
        // public korte hobe internal ke 
        [Key]
        [Required]
        public int Id { get; set; } // auto increment // unique
        //[StringLength(35)]
        //[Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        //[Required]
        //public string Type { get; set; } // buyer // seller 

        [ForeignKey("Role")]
        public int? RoleId {  get; set; }
        public virtual Role Role { get; set; }


        public DateTime? CreatedAt { get; set; }
        public string Image { get; set; }
        public int? PhoneNumber { get; set; }
        public DateTime? DOB { get; set; }

        public string Address { get; set; }

         [ForeignKey("SellerProfile")]
        public int? SellerProfileId { get; set; }
        public virtual SellerProfile SellerProfile{ get; set; }
        
        [ForeignKey("BuyerProfile")]
        public int? BuyerProfileId { get; set; }
        public virtual BuyerProfile BuyerProfile { get; set; }




        // ekhon amake Selle Profile And Buyer Profile er 
        // shathe User er relation korte hobe .. eta kivabe korbo ?


        // One User Can have many LikeDislike 
        public virtual ICollection<LikeDislike> LikeDislikes { get; set; }
        public User()
        {
            LikeDislikes = new List<LikeDislike>();
        }
    }
}
