using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of clients > ");
            int N = Convert.ToInt32(Console.ReadLine());

            int routes = 1;

            do
            {
                routes *= N;
                N--;
            }
            while (N > 0);

            Console.WriteLine($"possible routes - {routes}");

            Console.ReadKey();
        }
    }
}
