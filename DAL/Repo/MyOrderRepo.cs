using DAL.EF.Models;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class MyOrderRepo : Repo, IRepo<MyOrder, int, MyOrder>
    {
        public MyOrder Add(MyOrder obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<MyOrder> Get()
        {
            throw new NotImplementedException();
        }

        public MyOrder Get(int id)
        {
            throw new NotImplementedException();
        }

        public MyOrder Update(MyOrder obj)
        {
            throw new NotImplementedException();
        }
    }
}
