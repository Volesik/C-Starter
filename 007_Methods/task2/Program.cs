using System;

namespace task2
{
    class Program
    {
        /// <summary>
        /// Выводит сумму 2 аргументов в консоль
        /// </summary>
        /// <param name="augend">1-е слагаемое</param>
        /// <param name="addend">2-е слагаемое</param>
        static void Add(int augend, int addend)
        {
            Console.WriteLine($"Sum: {augend + addend}");
        }

        /// <summary>
        /// Выводит разность 2 аргументов в консоль
        /// </summary>
        /// <param name="minuend">уменьшаемое</param>
        /// <param name="subtrahend">вычитаемое</param>
        static void Sub(int minuend, int subtrahend)
        {
            Console.WriteLine($"Sub: {minuend + subtrahend}");
        }


        /// <summary>
        /// Выводит произведение 2 аргументов в консоль
        /// </summary>
        /// <param name="multiplicand">множимое</param>
        /// <param name="multiplier">множитель</param>
        static void Mul(int multiplicand, int multiplier)
        {
            Console.WriteLine($"Sub: {multiplicand * multiplier}");
        }

        /// <summary>
        /// Выводит частное 2 аргументов в консоль и проверяет деление на 0.
        /// </summary>
        /// <param name="dividend">делимое</param>
        /// <param name="divisor">делитель</param>
        static void Div(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Can't divide 0.");
            }
            else 
            {
                Console.WriteLine($"Sub: {dividend / divisor}");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first argument > ");
            int firstArgument = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second argument > ");
            int secondArgument = Convert.ToInt32(Console.ReadLine());

            // Бесконечный цикл на повторное выполнение, при некорректном вводе арифметического знака.
            for (; ;)
            {
                Console.Write("Enter operation sign > ");
                string sign = Console.ReadLine();
                
                Console.Clear();

                switch (sign)
                {
                    case "+":
                        Add(firstArgument, secondArgument);
                        break;
                    case "-":
                        Sub(firstArgument, secondArgument);
                        break;
                    case "*":
                        Mul(firstArgument, secondArgument);
                        break;
                    case "/":
                        Div(firstArgument, secondArgument);
                        break;
                    default:
                        Console.WriteLine("Вы ввели некорректную арифметическую операцию. Попробуйте еще раз.");
                        continue;
                }

                break;
            }

            Console.ReadKey();
        }
    }
}
