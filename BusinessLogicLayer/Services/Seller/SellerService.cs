using AutoMapper;
using BusinessLogicLayer.DTOs.Seller;
using DataAccessLayer.EF;
using DataAccessLayer.EF.Models;
using DataAccessLayer.Repos.Seller;
using E_Commerce_Web_Application.Helper.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Seller
{
    // ei class ta public korte hobe ..
    //  normally internal thake 
    public class SellerService
    {
        // public na dile .. baire theke access kora jabe na 

        // er moddhe kichu method thakbe .. jegula application 
        // layer call korbe .. 

        public static string GetName(int id)
        {
            // id ta application layer theke ashbe 
            id  += 100;
            // ekhon ei id diye database theke data ante hobe ..
            // Data Access Layer e send korte hobe ..

            // Data Access Layer eo kaoke thakte hobe .. je .. data 
            // ta niye ashbe 
            var data =  SellerRepo.Get(id);
            return data;
        }

        public static List<DTOs.Seller.SellerDTO> GetAllSeller()
        {
            var sellers = SellerRepo.GetAllSeller();

            var autoMapper = new AutoMapperConverter();

            //var ret = mapper.Map<List<PersonDTO>>(data);
            var ret = autoMapper.ConvertForList<DataAccessLayer.EF.Models.Seller, SellerDTO>(sellers);
            
            return ret;
        }
        public static DTOs.Seller.SellerDTO GetOneSeller(int id)
        {
            var seller = SellerRepo.GetOneSeller(id);

            var autoMapper = new AutoMapperConverter();

            var ret = autoMapper.ConvertForSingleInstance<DataAccessLayer.EF.Models.Seller, SellerDTO>(seller); ;
            return ret;
        }
        //public static void Create(PersonDTO p)
        //{
        //    var config = new MapperConfiguration(cfg => {
        //        cfg.CreateMap<PersonDTO, Person>();
        //    });
        //    var mapper = new Mapper(config);
        //    var data = mapper.Map<Person>(p);
        //    PersonRepo.Create(data);
        //}
    }
}
