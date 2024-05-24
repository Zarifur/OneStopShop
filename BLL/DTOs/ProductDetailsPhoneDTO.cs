using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ProductDetailsPhoneDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ModelName { get; set; }
        public string OperatingSystem { get; set; }
        public string Ram { get; set; }
        public string Storage { get; set; }
        public string Connectivity { get; set; }
        public string Color { get; set; }
        public string tag { get; set; }
        public int Quntity { get; set; }
        public byte[] Img1 { get; set; }
        public byte[] Img2 { get; set; }
        public byte[] Img3 { get; set; }
    }
}
