using System;

namespace additionaltask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5,6,7,8,9,10};

            // Исходный массив
            Console.Write("Исходный массив > ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();


            // Инвертируем массив
            int[] tempArray = new int[array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                tempArray[i] = array[array.GetLength(0) - 1 - i];
            }

            // Новый массив 
            Console.Write("Инвертированный массив > ");
            for (int i = 0; i < tempArray.GetLength(0); i++)
            {
                Console.Write($"{tempArray[i]} ");
            }

            Console.ReadKey();
        }
    }
}
