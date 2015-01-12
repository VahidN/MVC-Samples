using System.Collections.Generic;

namespace MvcApplication3.Models
{
    public class Products : List<Product>
    {
        public Products()
        {
            this.Add(new Product("D123", "Super Fast Bike", 1000M));
            this.Add(new Product("A356", "Durable Helmet", 123.45M));
            this.Add(new Product("M924", "Soft Bike Seat", 34.99M));
        }
    }
}