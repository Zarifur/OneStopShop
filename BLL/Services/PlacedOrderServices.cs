using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PlacedOrderServices
    {
        public static List<PlacedOrderDTO> Get()
        {
            var data = DataAccessFactory.PlacedOrderDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<PlacedOrder, PlacedOrderDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<PlacedOrderDTO>>(data);
        }
        public static PlacedOrderDTO Get(int uid)
        {
            var data = DataAccessFactory.PlacedOrderDataAccess().Get(uid);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<PlacedOrder, PlacedOrderDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<PlacedOrderDTO>(data);
        }
        public static PlacedOrderDTO Add(PlacedOrderDTO pro)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PlacedOrderDTO, PlacedOrder>();
                c.CreateMap<PlacedOrder, PlacedOrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<PlacedOrder>(pro);
            var rt = DataAccessFactory.PlacedOrderDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<PlacedOrderDTO>(rt);
            }
            return null;

        }
        public static bool Delete(int uid)
        {
            var data2 = DataAccessFactory.PlacedOrderDataAccess().Delete(uid);
            //var data = DataAccessFactory.UserDataAccess().Delete(uid);
            return data2;
        }

        public static PlacedOrderDTO Update(PlacedOrderDTO data)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<PlacedOrderDTO, PlacedOrder>();
                c.CreateMap<PlacedOrder, PlacedOrderDTO>();
            });
            var mapper = new Mapper(config);
            var dbobj = mapper.Map<PlacedOrder>(data);
            var ret = DataAccessFactory.PlacedOrderDataAccess().Update(dbobj);
            return mapper.Map<PlacedOrderDTO>(ret);
        }
    }
}
