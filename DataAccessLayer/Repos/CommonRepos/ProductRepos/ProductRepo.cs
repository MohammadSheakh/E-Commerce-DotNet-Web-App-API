﻿using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.EF.Models.Common.Products;
using DataAccessLayer.Interface.Common.Product;
using System.Security.Cryptography;
using DataAccessLayer.Interface.Common.Product.Specificaiton;
using DataAccessLayer.EF.Models.Product.Specifications;

namespace DataAccessLayer.Repos.CommonRepos.ProductRepos
{
    internal class ProductRepo : Repo, IRepo<Products, int, Products> ,IProduct<Products>, ISpecificationCategory<SpecificationCategory, Specification>
    {

        // 15
        public List<Products> sortProductByBrand(string brandName)
        {

            // brandName er against e brandId ta khuje ber korte hobe 
            /**
             * var brandInfo = db.Brands
                .Where(p => p.Name == brandName) // when we want to select multiple field
                .Select(p => new { Id = p.Id, Name = p.Name })
                .FirstOrDefault();
             */
            var brandId = db.Brands.Where(p => p.Name.Contains(brandName)).Select(p=> p.Id).FirstOrDefault();

            var products = db.Product.Where(p => p.BrandId == brandId).ToList();

            return products;
        }

        // 16
        public List<Products> sortProductByCategory(string categoryName) // contains means like search
        {
            var categoryId = db.Categories.Where(p => p.Name.Contains(categoryName)).Select(p => p.Id).FirstOrDefault();

            var products = db.Product.Where(p => p.CategoryId == categoryId).ToList();

            return products;
        }

        public List<Products> searchProductBySearchValue(string searchValue)
        {

            var products = db.Product.Where(p => p.Name.Contains(searchValue)).ToList();
            
            return products;
        }

        // 17
        public List<Products> sortProductByMinAndMaxRange(int? minValue, int? maxValue)
        {
            
            var products = db.Product.Where(p => p.Price >= minValue && p.Price <= maxValue).ToList();

            return products;

        }

        // 8 
        public List<Products> GetALlLowQuantityProductForSellerId(int sellerId)
        {
            //  seller er under e jei product gula ase..shegula age nilam ..
            // ekhon dekhbo checkForLowQuantity 
            var products = db.Product.Where(p => p.SellerId == sellerId && p.AvailableQuantity <= p.LowestQuantityToStock).ToList();
            
            return products;
           
        }
        // 2.1
        public List<Products> GetAllProductsDetailsBySellerId(int sellerId)
        {

            var products = db.Product.Where(p => p.SellerId == sellerId).ToList();
            return products;
            //throw new NotImplementedException();
        }



        public Products Create(Products obj)
        {
            obj.Rating = 0;
            obj.CreatedDate = DateTime.Now;
            //obj.CreatedDate = DateTime.Now.Date;
            db.Product.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var existing = Get(id);
            db.Product.Remove(existing);
            return db.SaveChanges() > 0;
        }

        public List<Products> Get()
        {
            return db.Product.ToList();
        }

        public Products Get(int id)
        {
            return db.Product.Find(id);
        }

       

        
        public Products Update(Products obj)
        {
            var existing = Get(obj.Id);
            db.Entry(existing).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }


        // done - 1 // done
        public Products GetProductsByLargestAvailableQuantity(int SellerId)
        {
            var productWithLargestQuantity = db.Product
                .Where(p => p.SellerId == SellerId)
                .OrderByDescending(p => p.AvailableQuantity)
                .FirstOrDefault();
            if (productWithLargestQuantity != null)
            {
                return productWithLargestQuantity;
            }
            else {
                return null;
            }
        }

        // done - 2
        public List<Products> GetProductsByRatingLessThanRatingLimit(int SellerId, int RatingLimit)
        {
            var productsWithGreatRating = db.Product.Where(p => p.Rating > RatingLimit && p.SellerId == SellerId);
            return productsWithGreatRating.ToList();

        }


        // done - 3
        public List<Products> GetProductsNoReviews(int SellerId)
        {
            var productsWithNoReview = db.Product.Where(p => p.SellerId == SellerId && !db.Reviewes.Any(r => r.ProductId == p.Id)).ToList();
            return productsWithNoReview;
            
        }

        // done - 4
        public List<Products> GetProductsWithLowStock(int SellerId)
        {
            var productWithLowStock = db.Product.Where(p => p.AvailableQuantity <= p.LowestQuantityToStock && p.SellerId == SellerId).ToList();
            return productWithLowStock;
           
        }

        // done - 5 
        public List<Products> GetALLBestSellingProduct(int SellerId)
        {
            // order beshi hoise jei product er .. shei product return korbe .. 
            // ekhon amar .. total product er 10% product return korbe .. 
            throw new NotImplementedException();
        }

        ///////////////////////////////
        public List<Products> GetALLBestSellingProductByCategory(int SellerId, string CategoryOrBrandType, string CategoryOrBrandName)
        {
            throw new NotImplementedException();
        }

        // done - 6
        public List<Products> GetALLOutOfStockProduct(int SellerId)
        {
            var productWithOutOfStock = db.Product.Where(p => p.AvailableQuantity == 0 && p.SellerId == SellerId).ToList();
            return productWithOutOfStock;
            
        }

        // done - 7
        public List<Products> GetALLProductsWithHighRatings(int SellerId)
        {
            var productWithHighRating = db.Product.Where(p => p.Rating >= 4 && p.SellerId == SellerId).ToList();
            return productWithHighRating;
            
        }

        // done - 8
        public List<Products> GetALLProductAddInSpecificTimeRange(int SellerId, DateTime StartDate, DateTime EndDate)
        {
            var productInTimeRange = db.Product.Where(p => p.SellerId == SellerId && p.CreatedDate >= StartDate && p.CreatedDate <= EndDate).ToList();
            return productInTimeRange;
        }

        /////////////////////////
        public List<Products> GetALLProductsWithMostReviewsByType(int SellerId, string BrandName, string CategoryName)
        {
            throw new NotImplementedException();
        }

        ////////////// Specification Category ///////////////////
        public SpecificationCategory AddSpecificationCategory(SpecificationCategory obj)
        {
            db.SpecificationCategories.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Specification AddSpecification(Specification obj)
        {
            db.Specifications.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        // ekta product er .. shob cheye beshi jei category er review ashse .. shei category er nam show korbo 
        // 
        
    }
}
