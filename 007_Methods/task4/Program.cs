using System;

namespace task4
{
    class Program
    {
        // В идеале этот метод разделить на 3 метода, т.к. это плохой вид связности, но сделано по условию, в усиловии указано что сделать один метод.

        /// <summary>
        /// Проверяет положительное/отрицательно, простое/нет, деление на 2,5,3,6,9
        /// </summary>
        /// <param name="number">проверяемое число</param>
        static void CheckNumber(int number)
        {
            int count = 0; // Счетчик проверки простого числа


            // Проверка на положительное отрицательное
            if(number > 0)
            {
                Console.WriteLine("Positive number.");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative number.");
                number = -number; // при негативном значении, меняем знак числа, что бы просчитать простоту числа, т.к. цикл заточен под положительное значение, плюс далее по методу негативное значение нам более не нужно.
            }
            else
            {
                Console.WriteLine("Zero number.");
            }

            
            // проверка на простоту числа
            for (int i = number; i > 0; i--)
            {
                if (number % i == 0)
                {
                    count += 1;
                }
            }

            if (count == 2)
            {
                Console.WriteLine("Simple number.");
            }
            else
            {
                Console.WriteLine("Not simple number.");
            }


            // Делиться без остатка
            if (number % 2 == 0)
            {
                Console.WriteLine("Divide on 2 without reminder.");
            }
            if (number % 5 == 0)
            {
                Console.WriteLine("Divide on 5 without reminder.");
            }
            if (number % 3 == 0)
            {
                Console.WriteLine("Divide on 3 without reminder.");
            }
            if (number % 6 == 0)
            {
                Console.WriteLine("Divide on 6 without reminder.");
            }
            if (number % 9 == 0)
            {
                Console.WriteLine("Divide on 9 without reminder.");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Write integer number > ");
            int checkNumber = Convert.ToInt32(Console.ReadLine());
            
            CheckNumber(checkNumber);

            Console.ReadKey();
        }
    }
}
