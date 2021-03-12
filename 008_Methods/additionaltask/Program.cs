using System;

namespace additionaltask
{
    class Program
    {
        /// <summary>
        /// Метод производит деление 3ех аргументов на 5 без остатка. 
        /// </summary>
        /// <param name="firstArgument">первый аргумент</param>
        /// <param name="secondArgument">второй аргумент</param>
        /// <param name="thirdArgument">третий аргумент</param>
        static void Calculate(ref int firstArgument, ref int secondArgument, ref int thirdArgument)
        {
            firstArgument /= 5;
            secondArgument /= 5;
            thirdArgument /= 5;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите значение первого аргумента > ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение второго аргумента > ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение третьего аргумента > ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            Calculate(ref firstNumber, ref secondNumber, ref thirdNumber);

            Console.WriteLine($"{firstNumber}, {secondNumber}, {thirdNumber}");

            Console.ReadKey();
        }
    }
}
