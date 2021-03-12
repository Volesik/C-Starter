using System;

namespace task3
{
    class Program
    {
        /// <summary>
        /// Simple Exchange currancy
        /// </summary>
        /// <param name="sum">Начальная сумма денег</param>
        /// <param name="rate">Курс валют</param>
        /// <returns>Сумма денег после приминения курса</returns>
        static double ConvertCurrency(double sum, double rate)
        {
            double newSum = sum * rate;
            return newSum;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите вашу сумму денег > ");
            double sum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите курс > ");
            double rate = Convert.ToDouble(Console.ReadLine());

            double newSum = ConvertCurrency(sum, rate);
            Console.WriteLine($"Сумма после обмена: {newSum}");

            Console.ReadKey();
        }
    }
}
