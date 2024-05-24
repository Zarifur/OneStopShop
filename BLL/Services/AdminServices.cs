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
    public class AdminServices
    {
        public static UserAddEmpDTO AddAdmin(UserAddEmpDTO admin)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<UserDTO, User>();
                c.CreateMap<User, UserDTO>();
                c.CreateMap<AdminDTO, Admin>();
            });
            var mapper = new Mapper(config);
            var user = new UserDTO()
            {
                Email = admin.Email,
                Password = admin.Password,
                UserType = admin.UserType,
            };
            Guid guid = Guid.NewGuid();
            var aadmin = new AdminDTO()
            {
                Email = admin.Email,
                Name = admin.Name,
                Gender = admin.Gender,
                //Address = em.Address,
                //Position = em.Position,
                //PhoneNumber = em.PhoneNumber,
                //joined = em.joined,
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
            return null;

        }

        public static List<AdminDTO> Get()
        {
            var data = DataAccessFactory.AdminDataAccess().Get();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<AdminDTO>>(data);
        }
        public static AdminDTO Get(int uid)
        {
            var data = DataAccessFactory.AdminDataAccess().Get(uid);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<AdminDTO>(data);
        }


        public static bool Delete(int uid)
        {
            var data2 = DataAccessFactory.AdminDataAccess().Delete(uid);
            var data = DataAccessFactory.UserDataAccess().Delete(uid);
            return data2;
        }

        public static AdminDTO Update(AdminDTO data)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminDTO, Admin>();
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            var dbobj = mapper.Map<Admin>(data);
            var ret = DataAccessFactory.AdminDataAccess().Update(dbobj);
            return mapper.Map<AdminDTO>(ret);
        }
    }
}
