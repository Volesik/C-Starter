using System;

namespace task3
{
    class Program
    {
        /// <summary>
        /// Метод инвертирует массив
        /// </summary>
        /// <param name="array">массив который нужно инвентировать</param>
        /// <returns>инвентированный массив</returns>
        static int[] MyReverse(int [] array)
        {
            int[] tempArray = new int[array.GetLength(0)];

            for (int i = 0; i < tempArray.GetLength(0); i++)
            {
                tempArray[i] = array[array.GetLength(0) - 1 - i];
            }

            return tempArray;
        }

        /// <summary>
        /// Метод возращает часть массива начиная с index размерностью count
        /// </summary>
        /// <param name="array">входной массив</param>
        /// <param name="index">начальная позиция</param>
        /// <param name="count">длинна нового массива</param>
        /// <returns>новый массив</returns>
        static int[] SubArray(int[] array, int index, int count)
        {
            int[] tempArray = new int[count];
            int arrayLength = array.GetLength(0) - 1;

            for (int i = 0; i < count; i++, index++)
            {
                if (index > arrayLength)
                {
                    tempArray[i] = 1;
                }
                else
                {
                    tempArray[i] = array[index];
                }
            }

            return tempArray;
        }

        static void Main(string[] args)
        {
            // Создаем экземпляр нового генератора чисел.
            var rand = new Random();

            Console.Write("Enter array length > ");
            int count = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[count];

            // Заполнение массива случайными числами в диапазоне от 0 до 100.
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = rand.Next(0, 100);
            }

            Console.Write("Исходный массив для проверки > ");
            // Вывод массива что бы проверить результат.
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
            Console.Write("Инвертированный массив > ");
            int[] reverseArray = MyReverse(array);

            for (int i = 0; i < reverseArray.GetLength(0); i++)
            {
                Console.Write($"{reverseArray[i]} ");
            }

            Console.WriteLine();
            Console.Write("Массив после применения метода SubArray > ");
            int[] newArray = SubArray(array, 3, 10);

            
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                Console.Write($"{newArray[i]} ");
            }

            Console.ReadKey();
        }
    }
}
