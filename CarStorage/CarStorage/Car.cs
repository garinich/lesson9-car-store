using System;

namespace CarStorage
{
    public class Car
    {
        private int _price = 0;

        public string Color { get; set; }

        public int Price {
            get => _price; 
            set {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Wrong value = {0} !!", value);
                }
            }
        }

        public string Name { get; set; }

        public double GetSale()
        {
            var saleSum = new Random().Next(5, 20);

            return Price - (saleSum / 100.0 * Price);
        }

        protected bool IsColorValid(string color)
        {
            return Enum.TryParse(color, out CarColors result);
        }
    }
}
