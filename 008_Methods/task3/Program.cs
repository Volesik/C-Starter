using System;

namespace task3
{
    class Program
    {
        /// <summary>
        /// Метод, который вычисляет факториал числа, необходимый для просчета маршрутов.
        /// </summary>
        /// <param name="number">Число клиентов</param>
        /// <returns>Количество доступных маршрутов, для одной машины.</returns>
        static int Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter client count > ");
            int routes = Factorial(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine($"Routes variant > {routes}");


            Console.ReadKey();
        }
    }
}

/*
 * Почему данный подход плохой(Рекурсия)?
 * Если количество клиентов большое а именно 19262, либо ошибочно пользователь введет слишком большое значение, то будет вызвано перезаполнение стека. (слабое место)
 * Не рекомендуется использовать такой подход по причине того, что читабельность программы ухудшаеться. 
 * В данном случае более читабельно будет использование циклов, так же при значении более 19262 при просчете циклами не будет вызван Stack Overflow.
 */ 