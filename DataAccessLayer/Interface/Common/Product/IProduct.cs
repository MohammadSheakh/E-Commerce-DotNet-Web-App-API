using DataAccessLayer.EF.Models.Common.Products;
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

        List<CLASS> sortProductByMinAndMaxRange(int? MinValue, int? MaxValue);

        CLASS GetProductsByLargestAvailableQuantity(int SellerId);//
        List<CLASS> GetProductsByRatingLessThanRatingLimit(int SellerId, int RatingLimit);//
        List<CLASS> GetProductsNoReviews(int SellerId);//
        List<CLASS> GetProductsWithLowStock(int SellerId); //
        List<CLASS> GetALLBestSellingProduct(int SellerId); // 
        List<CLASS> GetALLBestSellingProductByCategory(int SellerId, string CategoryOrBrandType, string CategoryOrBrandName);


        List<CLASS> GetALLOutOfStockProduct(int SellerId); //

        List<CLASS> GetALLProductsWithHighRatings(int SellerId); //
        List<CLASS> GetALLProductAddInSpecificTimeRange(int SellerId, DateTime StartDate, DateTime EndDate);

        List<CLASS> GetALLProductsWithMostReviewsByType(int SellerId, string BrandName, string CategoryName);

    }
}


