using DAL.EF.Models;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class PlacedOrderRepo : Repo, IRepo<PlacedOrder, int, PlacedOrder>
    {
        public PlacedOrder Add(PlacedOrder obj)
        {
            db.PlacedOrders.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<PlacedOrder> Get()
        {
            throw new NotImplementedException();
        }

        public PlacedOrder Get(int id)
        {
            var data=db.PlacedOrders.Where(x=> x.Id == id).FirstOrDefault();
            return data;
        }

        public PlacedOrder Update(PlacedOrder obj)
        {
            var data=Get(obj.Id);
            db.Entry(data).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return obj;
        }

    }
}
