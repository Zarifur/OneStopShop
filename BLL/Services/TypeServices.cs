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
    public class TypeServices
    {
        public static List<ProductTypeDTO> Get()
        {
            var data = DataAccessFactory.TypeDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<ProductType, ProductTypeDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<ProductTypeDTO>>(data);
        }
    }
}
