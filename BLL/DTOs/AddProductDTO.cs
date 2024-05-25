using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AddProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int ProductId { get; set; }
        public Int32 CategoryId { get; set; }
        public Int32 TypeId { get; set; }
        public double Price { get; set; }
        public int Quntity { get; set; }
        public string Brand { get; set; }
        public string ModelName { get; set; }
        public string OperatingSystem { get; set; }
        public string Ram { get; set; }
        public string Storage { get; set; }
        public string Color { get; set; }
        public string Tag { get; set; }
        public string Variations { get; set; }
        public string Description { get; set; }
        public byte[] Img1 { get; set; }
        public byte[] Img2 { get; set; }
        public byte[] Img3 { get; set; }
    }
}
