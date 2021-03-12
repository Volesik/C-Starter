using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer number > ");
            int checkNumber = Convert.ToInt32(Console.ReadLine());

            // 1-ый способ решения данного таска (самый простой и практичный)
            if (checkNumber % 2 == 0)
            {
                Console.WriteLine($"{checkNumber} - Even number.");
            }
            else
            {
                Console.WriteLine($"{checkNumber} - Odd number.");
            }


            // 2-способ решения данной задачи. Не знаю верно ли я мыслю, но учитывая что у нечетных последний бит всегда 1, то это в сторону логических сдвигов. 
            // То есть мы применяем явный кастинг не боясь что то потерять(если кастинг не делать, в инте 32 бита и нужно тогда на большее количество делать свд, и делаем сдвиг в лево на 7 что бы последний бит перенести на первое место и если число > 0 то тогда нечетное если 0 то четное.
            byte logicCheckNumber = (byte)(checkNumber << 7);

            if (logicCheckNumber > 0)
            {
                Console.WriteLine($"{checkNumber} - Odd number.");
            }
            else
            {
                Console.WriteLine($"{checkNumber} - Even number.");
            }

            Console.ReadKey();
        }
    }
}
