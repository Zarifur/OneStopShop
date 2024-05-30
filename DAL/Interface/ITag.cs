using System;
using DAL.EF.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface ITag
    {
        List<Product> GetTags(string tag);
    }
}
