using DAL.EF.Models;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class ProductRepo : Repo, IRepo<Product, int, Product>,ITag
    {
        public Product Add(Product obj)
        {
            try
            {
                db.Products.Add(obj);
            }
            catch (Exception e)
            {

                throw e;
            }
            
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var data = Get(id);
            db.Products.Remove(data);
            db.SaveChanges();
            return true;
        }

        public List<Product> Get()
        {
            return db.Products.ToList();
        }

        public Product Get(int id)
        {
            var data = db.Products.Where(x => x.ProductId == id).FirstOrDefault();
            return data;
        }

        public Product Update(Product obj)
        {
            var data=Get(obj.ProductId);
            db.Entry(data).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
        public List<Product> GetTags(string tag)
        {
            var data=db.Products.Where(x=>x.Tag.Contains(tag)).ToList();
            return data;
        }
    }
}
