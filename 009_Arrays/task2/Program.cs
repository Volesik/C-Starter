using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр нового генератора чисел.
            var rand = new Random();

            Console.Write("Enter array length > ");
            int count = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[count];

            int sumArray = 0;

            // Заполнение массива случайными числами в диапазоне от 0 до 100.
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = rand.Next(0, 100);
                sumArray += array[i];
            }

            Console.Write("Исходный массив для проверки > ");
            // Вывод массива что бы проверить результат.
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            Console.WriteLine($"Сумма всех значений массива {sumArray}");

            Array.Sort(array); // Сортировка от меньшего к большему

            int minValue = array[0]; // Минимальное значение массива 
            Console.WriteLine($"Минимальное значение массива {minValue}");
            
            int maxValue = array[array.GetLength(0) - 1]; // Максимальное значение массива 
            Console.WriteLine($"Максимальное значение массива {maxValue}");

            /*
             * Альтернативный способ вывода максимального значения массива
             * Array.Reverse(array);
             * int maxValue = array[0];
             */

            double avgArray = (double)sumArray / array.GetLength(0);
            Console.WriteLine($"Среднее арифметическое {avgArray}");

            // Вывод не четных значений массива
            Console.Write("Не четные значения массива > ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.Write($"{array[i]} ");
                }
            }

            Console.ReadKey();
        }
    }
}
