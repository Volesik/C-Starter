using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = Math.PI;
            double r = 20;
            
            double square = pi * Math.Pow(r, 2);
            // double square = Math.PI * Math.Pow(r, 2); // так лучше было бы, но в условиях указано другое.

            Console.WriteLine($"Площадь круга с радиусом \"{r}\" = {square:##.##}");

            Console.ReadKey();
        }
    }
}
