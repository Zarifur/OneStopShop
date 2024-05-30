using DAL.EF.Models;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class CustomerRepo:Repo,IRepo<Customer,int,Customer>
    {
        public Customer Add(Customer obj)
        {
            db.Customers.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var Customer = Get(id);
            db.Customers.Remove(Customer);
            if (db.SaveChanges() > 0) return true;
            return false;
        }

        public List<Customer> Get()
        {
            return db.Customers.ToList();
        }


        public Customer Get(int id)
        {
            return db.Customers.Find(id);
        }

        public Customer Update(Customer obj)
        {
            var Customer = Get(obj.UId);
            db.Entry(Customer).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
