using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models.UserModel
{
    public class Token
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string TKey{ get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public DateTime? DestroyedAt { get; set; }
        // nullable kore rakhlam .. jokhon logout korbe .. token delete kore dibe 

        // kar jonno token ta create korechi 
        [Required]
        public string userId { get; set; } // why strinng ? 🏠🔗🔴⚫

        // virtual property rakhte pari foreign key er jonno 
        // accha , apatoto thak 
    }
}
