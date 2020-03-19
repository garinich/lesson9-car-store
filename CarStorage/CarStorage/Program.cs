using System;

namespace CarStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[3];

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = new Car();

                Console.WriteLine("Please enter car's name:");
                cars[i].Name = Console.ReadLine();

                Console.WriteLine("Please enter car's price:");
                cars[i].Price = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter car's color:");
                cars[i].Color = Console.ReadLine();
            }

            Console.WriteLine($"Source price: {cars[0].Price} ; Price after sale: {cars[0].GetSale()}");
        }
    }
}
