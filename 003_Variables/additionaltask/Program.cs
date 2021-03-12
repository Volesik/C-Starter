using System;

namespace additionaltask
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5, secondNumber = 2;
            // при помощи унарных операторов
            Console.WriteLine($"{++firstNumber} {++secondNumber}");
            Console.WriteLine($"{firstNumber++} {secondNumber++}");
            Console.WriteLine($"{--firstNumber} {--secondNumber}");
            Console.WriteLine($"{firstNumber--} {secondNumber--}");
            Console.WriteLine($"{-firstNumber} {-secondNumber}");
            Console.WriteLine($"{+firstNumber} {+secondNumber}");

            // при помощи бинарных операторов
            Console.WriteLine(firstNumber + secondNumber);
            Console.WriteLine(firstNumber - secondNumber);
            Console.WriteLine(firstNumber * secondNumber);
            Console.WriteLine(firstNumber / secondNumber);
            Console.WriteLine(firstNumber % secondNumber);

            // при помощи класса Math (использовал только те методы где используются 2 переменных).
            Console.WriteLine(Math.BigMul(firstNumber, secondNumber));
            Console.WriteLine(Math.IEEERemainder(firstNumber, secondNumber));
            Console.WriteLine(Math.Log(firstNumber, secondNumber));
            Console.WriteLine(Math.Max(firstNumber, secondNumber));
            Console.WriteLine(Math.Min(firstNumber, secondNumber));
            Console.WriteLine(Math.Pow(firstNumber, secondNumber));

            Console.ReadKey();
        }
    }
}
