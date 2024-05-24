using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class OneStopContext : DbContext
    {
        public DbSet<User> Users { set; get; }
        public DbSet<Admin> Admins { set; get; }
        public DbSet<Customer> Customers { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<Cart> Carts { set; get; }
        public DbSet<Categoty> Categoties { set; get; }
        public DbSet<ProductType> ProductTypes { set; get; }
        public DbSet<ProductDetailsPhone> ProductDetailsPhones { set; get; }

    }
}
