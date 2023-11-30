using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models
{
    public class Seller
    {
        // public korte hobe internal ke 
        public int Id { get; set; } // auto increment // unique
        public string name { get; set; }
    }
}
