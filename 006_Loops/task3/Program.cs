using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Прямоугольник
            Console.WriteLine("Прямоугольник");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("* ");
                }

                Console.Write("\n");
            }

            // Прямоугольный треугольник
            Console.WriteLine("Прямоугольный треугольник");

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("* ");
                }

                Console.Write("\n");
            }

            // Равносторонний треугольник
            Console.WriteLine("Равносторонний треугольник");
            int height = 6;
            for (int i = 0; i < height; i++)
            {
                
                for(int j = 0; j < height - 1 - i; j++)
                {
                    Console.Write(" ");
                }
               
                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            // Ромб
            Console.WriteLine("Ромб");
            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < height - 1 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            for (int i = height - 2; i > 0; i--)
            {

                for (int j = 0; j < height - 1 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
