using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AdminDTO
    {
        public int UId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        //public string PhoneNumber { get; set; }
        //public string Address { get; set; }
        //public int AccNumber { get; set; }
        //public string ProfilePicture { get; set; }

        public virtual User User { get; set; }
    }
}
