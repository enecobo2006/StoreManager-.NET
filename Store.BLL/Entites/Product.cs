using Store.BLL.Entites;
using System;
namespace Store.BLL.Entities
{
    public class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public double Stock { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public string Image { get; set; }
    }
}
