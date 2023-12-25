using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface.Common.Product
{
    public interface IProduct<CLASS>// , DataTypeForParameter, Parameter
    {
        List<CLASS> GetAllProductsDetailsBySellerId(int sellerId);
        List<CLASS> GetALlLowQuantityProductForSellerId(int sellerId);

        List<CLASS> sortProductByBrand(string brandName);

        List<CLASS> sortProductByCategory(string categoryName);

        List<CLASS> sortProductByMinAndMaxRange(int? minValue, int? maxValue);
    }
}
