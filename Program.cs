using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bently = new Car("bent", 2500, 122);

            Lorry scania = new Lorry("Scania", 1.5, 1200);
            scania.LoadCap = 12;

            Console.WriteLine("HP of Bently: " + bently.HPower);
            Console.WriteLine("LC of Scania: " + scania.LoadCap);
        }
    }
}