﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int? Quantity { get; set; }

        public int? UnitPrice { get; set; }


        // public int? OrderId { get; set; }

        
        // public int? ProductId { get; set; }

    }
}