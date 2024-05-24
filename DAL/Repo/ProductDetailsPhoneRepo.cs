using DAL.EF.Models;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class ProductDetailsPhoneRepo : Repo, IRepo<ProductDetailsPhone, int, ProductDetailsPhone>
    {
        public ProductDetailsPhone Add(ProductDetailsPhone obj)
        {
            db.ProductDetailsPhones.Add(obj);
            db.SaveChanges();
            return null;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailsPhone> Get()
        {
            return db.ProductDetailsPhones.ToList();
        }
        public ProductDetailsPhone Get(int id)
        {
            var data = db.ProductDetailsPhones.Where(x => x.Id == id).FirstOrDefault();
            return data;
        }


        public ProductDetailsPhone Update(ProductDetailsPhone obj)
        {
            throw new NotImplementedException();
        }
    }
}
