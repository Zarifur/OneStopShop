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
        public static IRepo<Customer, int, Customer> CustomerDataAccess() 
        { 
          return new CustomerRepo();
        }
        public static IRepo<Token, int , Token> TokenDataAccess()
        {
            return new TokenRepo();
        }
        public static IAuth AuthDataAccess()
        {
            return new UserRepo();
        }
        public static IRepo<ProductDetailsPhone, int, ProductDetailsPhone> ProductDetailsPhoneDataAccess()
        {
            return new ProductDetailsPhoneRepo();
        }
        public static IRepo<PlacedOrder, int, PlacedOrder> PlacedOrderDataAccess()
        {
            return new PlacedOrderRepo();
        }
        public static IRepo<MyOrder, int, MyOrder> MyOrderDataAccess()
        {
            return new MyOrderRepo();
        }
        public static IRepo<Categoty, int, Categoty> CategoryDataAccess()
        {
            return new CategoryRepo();
        }
        public static IRepo<ProductType, int, ProductType> TypeDataAccess()
        {
            return new TypeRepo();
        }
        public static ITag TagDataAccess()
        {
            return new ProductRepo();
        }
    }
}
