using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class ProductDetailsPhone
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public string ModelName { get; set; }
        public string OperatingSystem { get; set; }
        //public string Ram { get; set; }
        //public string Storage { get; set; }
        //public string Color { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public string Variations { get; set; }
        public int Quntity { get; set; }
        public byte[] Img1 { get; set; }
        public byte[] Img2 { get; set; }
        public byte[] Img3 { get; set; }
        public virtual Product Product { get; set; }

    }
}
