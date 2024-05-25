using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductDetailsPhoneServices
    {
        public static ProductDetailsPhoneDTO Get(int uid)
        {
            var data = DataAccessFactory.ProductDetailsPhoneDataAccess().Get(uid);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDetailsPhone, ProductDetailsPhoneDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<ProductDetailsPhoneDTO>(data);
        }
        public static List<ProductDetailsPhoneDTO> Get()
        {
            var data = DataAccessFactory.ProductDetailsPhoneDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<ProductDetailsPhone, ProductDetailsPhoneDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<ProductDetailsPhoneDTO>>(data);
        }
        public static ProductDetailsPhoneDTO AddProductDetails(ProductDetailsPhoneDTO pay)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ProductDetailsPhoneDTO, ProductDetailsPhone>();
                c.CreateMap<ProductDetailsPhone, ProductDetailsPhoneDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<ProductDetailsPhone>(pay);
            var rt = DataAccessFactory.ProductDetailsPhoneDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<ProductDetailsPhoneDTO>(rt);
            }
            return null;
        }
        public static bool Delete(int uid)
        {
            var data2 = DataAccessFactory.ProductDetailsPhoneDataAccess().Delete(uid);
            //var data = DataAccessFactory.UserDataAccess().Delete(uid);
            return data2;
        }

        public static ProductDetailsPhoneDTO Update(ProductDetailsPhoneDTO data)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDetailsPhoneDTO, ProductDetailsPhone>();
                c.CreateMap<ProductDetailsPhone, ProductDetailsPhoneDTO>();
            });
            var mapper = new Mapper(config);
            var dbobj = mapper.Map<ProductDetailsPhone>(data);
            var ret = DataAccessFactory.ProductDetailsPhoneDataAccess().Update(dbobj);
            return mapper.Map<ProductDetailsPhoneDTO>(ret);
        }
    }
}
