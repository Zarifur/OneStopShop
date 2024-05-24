using DAL.EF.Models;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class CategoryRepo : Repo, IRepo<Categoty, int, Categoty>
    {
        public Categoty Add(Categoty obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Categoty> Get()
        {
            return db.Categoties.ToList();
        }

        public Categoty Get(int id)
        {
            throw new NotImplementedException();
        }

        public Categoty Update(Categoty obj)
        {
            throw new NotImplementedException();
        }
    }
}
