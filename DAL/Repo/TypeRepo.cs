using DAL.EF.Models;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class TypeRepo :Repo, IRepo<ProductType, int, ProductType>
    {
        public ProductType Add(ProductType obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductType> Get()
        {
            return db.ProductTypes.ToList();
        }

        public ProductType Get(int id)
        {
            throw new NotImplementedException();
        }

        public ProductType Update(ProductType obj)
        {
            throw new NotImplementedException();
        }
    }
}
