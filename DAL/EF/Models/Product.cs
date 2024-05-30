using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        [ForeignKey("Categoty")]
        public int CategoryId { get; set; }
        [ForeignKey("ProductType")]
        public int TypeId { get; set; }
        public double Price { get; set; }
        public string Tag { get; set; }
        public string Brand { get; set; }
        public string Image { get; set; }
        public string Mun { get; set; }
        public virtual User User { get; set; }
        public virtual Categoty Categoty { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
