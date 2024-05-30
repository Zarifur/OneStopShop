using System;

namespace BLL.DTOs
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int TypeId { get; set; }
        public double Price { get; set; }
        public string Tag { get; set; }
        public string Brand { get; set; }
        public string Image { get; set; }
        public string Mun { get; set; }
    }
}
