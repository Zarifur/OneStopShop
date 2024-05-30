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
    public class CategoryServices
    {
        public static List<CategoryDTO> Get()
        {
            var data = DataAccessFactory.CategoryDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<Categoty, CategoryDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<CategoryDTO>>(data);
        }
    }
}
