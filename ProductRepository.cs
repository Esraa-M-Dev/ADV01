using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmnentAdvancedC_01
{
    internal class ProductRepository:IRepository<Product>
    {
        private List<Product> _products = [];
        public void Create(Product item)
        {
            _products.Add(item);
        }

        public void Delete(int id)
        {
            Product producToDelete = GetById(id);
            _products.Remove(producToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            foreach (Product item in _products)
            {
                if (item.Id == id)
                    return item;
            }
            return new Product(-1, "N/A", 0);
        }
    }
}
