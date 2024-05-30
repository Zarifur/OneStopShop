using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class MyOrder
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UId { get; set; }
        public string ProductName { get; set; }
        public string Address { get; set; }
        public int Quntity { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public string Status { get; set; }
    }
}
