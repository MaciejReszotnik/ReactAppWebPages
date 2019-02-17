using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactAppWebPages.Models
{
    public class SimpleRepository
    {
        private Dictionary<string, Product> products = new Dictionary<string, Product>();

        public static SimpleRepository SharedRepository { get; } = new SimpleRepository();

        public SimpleRepository()
        {
            var initialItems = new[]
            {
                new Product {Name = "Kayak", Price=275M},
                new Product {Name = "Lidejacket", Price = 48.85M},
                new Product {Name = "Soccer ball", Price=19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            foreach (var p in initialItems)
            {
                AddProducts(p);
            }

        }

        public IEnumerable<Product> Products => products.Values;

        public void AddProducts(Product p) => products.Add(p.Name, p);
    }
}
