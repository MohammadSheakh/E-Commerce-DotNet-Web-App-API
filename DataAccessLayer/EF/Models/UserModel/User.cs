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
        public int id { get; set; } // auto increment // unique
        //[StringLength(35)]
        //[Required]
        public string name { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string type { get; set; } // buyer // seller 

        public int? rating { get; set; } // intiger normally null accept kore na .. 
        // amra nullable kore dilam 
    }
}
