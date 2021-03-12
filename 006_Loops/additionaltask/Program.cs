using System;

namespace additionaltask
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 5;
            int width = 10;
            string sign = "* ";

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write($"{sign}");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
