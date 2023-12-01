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
    public class NewsService
    {
        public static DTOs.University.NewsDTO GetOneNews(int id)
        {
            var news = NewsRepo.GetOneNews(id);

            var autoMapper = new AutoMapperConverter();

            var ret = autoMapper.ConvertForSingleInstance<DataAccessLayer.EF.Models.University.News, NewsDTO>(news); ;
            return ret;
        }

        public static void CreateNews(NewsDTO newsDTO)
        {

            var autoMapper = new AutoMapperConverter();

            var data = autoMapper.ConvertForSingleInstance<NewsDTO, DataAccessLayer.EF.Models.University.News>(newsDTO); ;
            //return ret;
            NewsRepo.CreateNews(data);
        }
    }
}
