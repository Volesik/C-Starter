using System;

namespace task4
{
    class Program
    {
        /// <summary>
        /// Метод увеличевает массив на 1 и выводит его
        /// </summary>
        /// <param name="array"></param>
        static void IncreaseArray(int[] array) // что бы метод возращал значение массива а не выводил нужно добавить return, либо out как пример.
        {
            int[] tempArray = new int[array.GetLength(0) + 1];
            array.CopyTo(tempArray, 0);

            Console.Write("Массив увеличенный на 1 > ");
            for (int i = 0; i < tempArray.GetLength(0); i++)
            {
                Console.Write($"{tempArray[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Метод добавляет значение в начало массива и выводит его
        /// </summary>
        /// <param name="array">Исходный массива</param>
        /// <param name="value">Значение которое необходимо добавить</param>
        static void AddValueToArray(int[] array, int value) // что бы метод возращал значение массива а не выводил нужно добавить return, либо out как пример.
        {
            int[] tempArray = new int[array.GetLength(0) + 1];
            tempArray[0] = value;

            array.CopyTo(tempArray, 1);

            Console.Write("Массив c новым значением в начале > ");
            for (int i = 0; i < tempArray.GetLength(0); i++)
            {
                Console.Write($"{tempArray[i]} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var random = new Random();

            int[] array = new int[random.Next(3, 10)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(0, 100);
            }

            Console.Write("Исходный массив для проверки > ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            IncreaseArray(array);

            AddValueToArray(array, random.Next(0, 10));

            Console.ReadKey();
        }
    }
}
