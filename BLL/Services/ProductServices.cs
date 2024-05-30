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
            Random rnd = new Random();
            int num = rnd.Next();
            var product = new ProductDTO()
            {
                //ProductId = num,
                Name=pro.Name, 
                UserId=1,
                //Title=pro.Title,   
                CategoryId=pro.CategoryId,
                TypeId =pro.TypeId,
                Price =pro.Price,
                Tag =pro.Tag,
                Brand=pro.Brand
            };
            var dbproduct = DataAccessFactory.ProductDataAccess().Add(mapper.Map<Product>(product));
            Guid guid = Guid.NewGuid();
            var productDetails = new ProductDetailsPhoneDTO()
            {
                ProductId=dbproduct.ProductId,
                ModelName=pro.ModelName, 
                //OperatingSystem=pro.OperatingSystem,
                //Ram =pro.Ram,
                //Storage=pro.Storage,
                //Connectivity=pro.Connectivity,
                //Color=pro.Color, 
                Tag=pro.Tag,
                Variations=pro.Variations,
                Description=pro.Description,
                Quntity=pro.Quntity,
                Img1=pro.Img1,
                Img2 = pro.Img2,
                Img3 = pro.Img3
            };            

            var dbadmin = DataAccessFactory.ProductDetailsPhoneDataAccess().Add(mapper.Map<ProductDetailsPhone>(productDetails));
            return null;
          
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
        public static ProductDTO UpdateProduct(AddProductDTO pro)
        {
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
                //ProductId = num,
                Name = pro.Name,
                UserId = 1,
                //Title=pro.Title,   
                CategoryId = pro.CategoryId,
                TypeId = pro.TypeId,
                Price = pro.Price,
                Tag = pro.Tag,
                Brand = pro.Brand,
                Image=pro.Image
            };
            var dbproduct = DataAccessFactory.ProductDataAccess().Update(mapper.Map<Product>(product));
            Guid guid = Guid.NewGuid();
            var productDetails = new ProductDetailsPhoneDTO()
            {
                ProductId = dbproduct.ProductId,
                ModelName = pro.ModelName, 
                Tag = pro.Tag,
                Variations = pro.Variations,
                Description = pro.Description,
                Quntity = pro.Quntity,
                Img1 = pro.Img1,
                Img2 = pro.Img2,
                Img3 = pro.Img3
            };

            var dbadmin = DataAccessFactory.ProductDetailsPhoneDataAccess().Update(mapper.Map<ProductDetailsPhone>(productDetails));
            return null;
        }
        public static List<ProductDTO> GetTag(string tag)
        {
            var data = DataAccessFactory.TagDataAccess().GetTags(tag);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<ProductDTO>>(data);
        }

    }
}
