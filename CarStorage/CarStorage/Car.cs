using System;

namespace CarStorage
{
    public class Car
    {
        public string Color { get; set; }

        public int Price { get; set; }

        public string Name { get; set; }

        public double GetSale()
        {
            var saleSum = new Random().Next(5, 20);

            return Price - (saleSum / 100.0 * Price);
        }
    }
}
