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
    public class CustomerServices
    {
        public static UserAddCusDTO AddCustomer(UserAddCusDTO Customer)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<UserDTO, User>();
                c.CreateMap<User, UserDTO>();
                c.CreateMap<CustomerDTO, Customer>();
            });
            var mapper = new Mapper(config);
            var user = new UserDTO()
            {
                Email = Customer.Email,
                Password = Customer.Password,
                UserType = Customer.UserType,
            };
            Guid guid = Guid.NewGuid();
            var dbuser = DataAccessFactory.UserDataAccess().Add(mapper.Map<User>(user));
            var aCustomer = new CustomerDTO()
            {
                UId =dbuser.UId,
                Email = Customer.Email,
                Name = Customer.Name,
                Gender = Customer.Gender,
                Address = Customer.Address,

            };
            


            if (dbuser != null)
            {

                var dbCustomer = DataAccessFactory.CustomerDataAccess().Add(mapper.Map<Customer>(aCustomer));
                return null;
            }
            return null;

        }

        public static List<CustomerDTO> Get()
        {
            var data = DataAccessFactory.CustomerDataAccess().Get();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<CustomerDTO>>(data);
        }
        public static CustomerDTO Get(int uid)
        {
            var data = DataAccessFactory.CustomerDataAccess().Get(uid);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<CustomerDTO>(data);
        }


        public static bool Delete(int uid)
        {
            var data2 = DataAccessFactory.CustomerDataAccess().Delete(uid);
            var data = DataAccessFactory.UserDataAccess().Delete(uid);
            return data2;
        }

        public static CustomerDTO Update(CustomerDTO data)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CustomerDTO, Customer>();
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(config);
            var dbobj = mapper.Map<Customer>(data);
            var ret = DataAccessFactory.CustomerDataAccess().Update(dbobj);
            return mapper.Map<CustomerDTO>(ret);
        }
    }
}
