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
    public class ProductServices
    {
        public static List<ProductDTO> Get()
        {
            var data = DataAccessFactory.ProductDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<ProductDTO>>(data);
        }
        public static ProductDTO Get(int uid)
        {
            var data = DataAccessFactory.ProductDataAccess().Get(uid);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<ProductDTO>(data);
        }
        public static AddProductDTO AddProduct(AddProductDTO pro)
        {
            //var cfg = new MapperConfiguration(c => {
            //    c.CreateMap<ProductDTO, Product>();
            //    c.CreateMap<Product, ProductDTO>();
            //});
            //var mapper = new Mapper(cfg);
            //var data = mapper.Map<Product>(pay);
            //var rt = DataAccessFactory.ProductDataAccess().Add(data);
            //if (rt != null)
            //{
            //    return mapper.Map<ProductDTO>(rt);
            //}
            //return null;

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDTO, Product>();
                c.CreateMap<Product, ProductDTO>();
                c.CreateMap<ProductDetailsPhoneDTO, ProductDetailsPhone>();
                c.CreateMap<ProductDetailsPhone, ProductDetailsPhoneDTO>();
            });
            var mapper = new Mapper(config);

            var product = new ProductDTO()
            {
                ProductId=pro.ProductId, 
                Name=pro.Name, 
                Title=pro.Title,   
                CategoryId=pro.CategoryId,
                TypeId =pro.TypeId,
                Price =pro.Price,
                Tag =pro.tag,
                Brand=pro.Brand
            };
            Guid guid = Guid.NewGuid();
            var aadmin = new ProductDetailsPhoneDTO()
            {
                //Email = admin.Email,
                //Name = admin.Name,
                //Gender = admin.Gender,
                ////Address = em.Address,
                ////Position = em.Position,
                ////PhoneNumber = em.PhoneNumber,
                ////joined = em.joined,
                //Depertment = em.Depertment,
                //AccNumber = 10,
                //UId = guid.ToString(),
            };
            var dbuser = DataAccessFactory.UserDataAccess().Add(mapper.Map<User>(user));


            if (dbuser != null)
            {

                var dbadmin = DataAccessFactory.AdminDataAccess().Add(mapper.Map<Admin>(aadmin));
                return null;
            }

            return 0;
        }
        public static bool Delete(int uid)
        {
            var data2 = DataAccessFactory.ProductDataAccess().Delete(uid);
            //var data = DataAccessFactory.UserDataAccess().Delete(uid);
            return data2;
        }

        public static ProductDTO Update(ProductDTO data)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDTO, Product>();
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(config);
            var dbobj = mapper.Map<Product>(data);
            var ret = DataAccessFactory.ProductDataAccess().Update(dbobj);
            return mapper.Map<ProductDTO>(ret);
        }
    }
}
