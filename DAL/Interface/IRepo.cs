using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IRepo<CLASS, Int32 , RESULT>
    {
        List<CLASS> Get();
        CLASS Get(int id);
        RESULT Add(CLASS obj);
        RESULT Update(CLASS obj);
        bool Delete(int id);
    }
}
