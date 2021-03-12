using System;

namespace additionaltask2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true, B = false;

            bool firstExpression = A | B;
            bool secondExpression = !(!A & !B);

            if (firstExpression == secondExpression)
            {
                Console.WriteLine("Выражения эквивалентны.");
            }
            else
            {
                Console.WriteLine("Выражения не эквивалентны.");
            }


            Console.ReadKey();
        }
    }
}
