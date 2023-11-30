﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models
{
    public class Seller
    {
        // public korte hobe internal ke 
        [Key]
        public int Id { get; set; } // auto increment // unique
        [StringLength(35)]
        [Required]
        public string name { get; set; }

        public int? rating { get; set; } // intiger normally null accept kore na .. 
        // amra nullable kore dilam 
    }
}
