using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmnentAdvancedC_01
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Product(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"id:{Id}--name:{Name}--price:{Price}";
        }
    }
}
