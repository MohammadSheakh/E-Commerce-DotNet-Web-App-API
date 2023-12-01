using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models.University
{
    public class News
    {
        public int Id { get; set; }

        public string Title { get; set; }

        
        public DateTime? Date { get; set; }
    }
}
