using BusinessLogicLayer.DTOs.Seller;
using BusinessLogicLayer.DTOs.University;
using DataAccessLayer.Repos.Seller;
using DataAccessLayer.Repos.University;
using E_Commerce_Web_Application.Helper.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.University
{
    public class CategoryService
    {
        public static DTOs.University.CategoryDTO GetOneCategory(int id)
        {
            var category = CategoryRepo.GetOneCategory(id);

            var autoMapper = new AutoMapperConverter();

            var ret = autoMapper.ConvertForSingleInstance<DataAccessLayer.EF.Models.University.Category, CategoryDTO>(category); ;
            return ret;
        }

        public static void CreateCategory(CategoryDTO categoryDTO)
        {
            

            var autoMapper = new AutoMapperConverter();

            var data = autoMapper.ConvertForSingleInstance<CategoryDTO,DataAccessLayer.EF.Models.University.Category>(categoryDTO); ;
            //return ret;
            CategoryRepo.CreateCategory(data);
        }
    }
}
