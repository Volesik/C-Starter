using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "\nмоя строка 1"; // Происходит перенос строки перед выводом переменной
            string secondString = "\tмоя строка 2"; // Табуляция, перед выводом строки
            string thirdString = "\aмоя строка 3"; //с данным символом никаких видоизминений нет. Попробовал и другие буквы напр. b также изминений нету.

            Console.WriteLine(firstString);
            Console.WriteLine(secondString);
            Console.WriteLine(thirdString);

            Console.ReadKey();
        }
    }
}
