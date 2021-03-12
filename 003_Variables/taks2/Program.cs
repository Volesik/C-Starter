using System;

namespace taks2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 3, secondValue = 5, thirdValue = 5;
            double averageSum = (double)(firstValue + secondValue + thirdValue) / 3;

            Console.WriteLine($"Average of 3 numbers - {averageSum}");
            
            Console.ReadKey();
        }
    }
}


/*
 * Столкнулся с прорблемой что независимо от набора значений финальный результат был целым. Так как изначально в условии задания указано целые числа. Добавил кастинг в задачу. 
 * Для корректного результата лучше будет отображать тип данных double при указании значений.
 */