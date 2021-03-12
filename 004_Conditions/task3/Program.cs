using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer value > ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Решил задание при помощи &&, но потом подумал, а проходили ли мы его и можно ли, его было использовать, если необходимо переделать, переделаю.
            if (userNumber >= 0 && userNumber < 15)
            {
                Console.WriteLine($"{userNumber} enter [0 - 14] range.");
            }
            else if (userNumber >= 15 && userNumber < 36)
            {
                Console.WriteLine($"{userNumber} enter [15 - 35] range");
            }
            else if (userNumber >= 36 && userNumber < 50)
            {
                Console.WriteLine($"{userNumber} enter [36 - 50] range");
            }
            else if (userNumber > 50 && userNumber <= 100)
            {
                Console.WriteLine($"{userNumber} enter [50 - 100] range");
            }
            else if (userNumber == 50)
            {
                Console.WriteLine($"{userNumber} enter [36 - 50] & [50 - 100] ranges");
            }
            else
            {
                Console.WriteLine("Out of range");
            }

            Console.ReadKey();
        }
    }
}
