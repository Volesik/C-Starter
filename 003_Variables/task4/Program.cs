using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = 5, h = 9;

            double V = Math.PI * Math.Pow(R, 2) * h;
            double S = (2 * Math.PI * R * h) + (2 * Math.PI * Math.Pow(R, 2));
            // второй вариант формулы S. double S = 2 * Math.PI * R * (R + h);

            Console.WriteLine($"Cylinder Volume - {V} \nCylinder Square - {S}");
            Console.ReadKey();
        }
    }
}
