using System.Collections.Generic;

namespace MvcApplication5.Models
{
    public class Products : List<Product>
    {
        public Products()
        {
            this.Add(new Product("مقدار يك + مقدار ديگر", "Super Fast Bike", 1000M));
            this.Add(new Product("مقدار دو-age 18-23", "Durable Helmet", 123.45M));
            this.Add(new Product("@مقدار.مقدار$مقدار", "Soft Bike Seat", 34.99M));
        }
    }
}