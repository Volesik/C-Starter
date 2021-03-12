using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first integer number > ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second bigger integer number > ");
            int B = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int sumExclude = 0;

            // Сума включая крайние значения
            for(int i = A; i <= B; i++)
            {
                sum += i;
            }

            // Сума внутреннего диапазона значений
            for(int i = A + 1; i < B; i++)
            {
                sumExclude += i;
            }

            Console.WriteLine($"Сума всех чисел включая {A} и {B} = {sum}");
            Console.WriteLine($"Сума внутреннего диапазона {sumExclude}");

            Console.Write("Нечетные числа между введенными числами -> ");

            for (int i = A + 1; i < B; i++)
            {
                if(i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }

            Console.ReadKey();
        }
    }
}
