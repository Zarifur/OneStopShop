using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TokenDTO
    {
        public int Id { get; set; }
        public string LoginToken { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public int UId { get; set; }
        public string UserType { get; set; }
        public virtual User User { get; set; }
    }
}
