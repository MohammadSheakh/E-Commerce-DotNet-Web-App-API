using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface.Common.Product
{
    public interface IProduct<CLASS>
    {
        List<CLASS> GetAllProductsDetailsBySellerId(int sellerId);
    }
}
