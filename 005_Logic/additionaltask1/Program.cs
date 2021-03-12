using System;

namespace additionaltask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer number > ");
            int checkNumber = Convert.ToInt32(Console.ReadLine());

            if ( (checkNumber & (checkNumber - 1) ) == 0 )
            {
                Console.WriteLine($"{checkNumber} is n2 Number");
            }
            else
            {
                Console.WriteLine($"{checkNumber} is not n2 Number");
            }

            Console.ReadKey();
        }
    }
}
