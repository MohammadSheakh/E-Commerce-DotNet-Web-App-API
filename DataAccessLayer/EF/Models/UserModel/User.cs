using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        public string Type { get; set; } // buyer // seller 

        //public int? Role {  get; set; }


        public DateTime? CreatedAt { get; set; }
        
    }
}
