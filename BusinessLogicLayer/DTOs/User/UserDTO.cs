using DataAccessLayer.EF.Models.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.DTOs.User
{
    public class UserDTO
    {

        //public string name { get; set; }

        //public string password { get; set; }

        //public string type { get; set; } // buyer // seller 

        //public int? rating { get; set; } // intiger normally null accept kore na .. 
        //                                 // amra nullable kore dilam 


        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }


        public int? RoleId { get; set; }


        public DateTime? CreatedAt { get; set; }
    }
}
