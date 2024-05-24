using DAL.EF.Models;
using DAL.Interface;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User, int, User> UserDataAccess()
        {
            return new UserRepo();
        }
        public static IRepo<Product, int, Product> ProductDataAccess()
        {
            return new ProductRepo();
        }
        public static IRepo<Admin, int, Admin> AdminDataAccess()
        {
            return new AdminRepo();
        }
        public static IRepo<ProductDetailsPhone, int, ProductDetailsPhone> ProductDetailsPhoneDataAccess()
        {
            return new ProductDetailsPhoneRepo();
        }
    }
}
