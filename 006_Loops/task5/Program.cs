using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи ширину фигуры > ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введи высоту треугольника > ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введи символ > ");
            string symbol = Console.ReadLine();

            int left = 0; // переменная используется для просчёта отступов в консоле слева или справа (A, D) 
            int up = 0; // переменная используется для просчёта отступов в консоле сверху или снизу (S, W)

            for (; ; )
            {
                // создаем локальные переменные, что бы была возможность использовать в циклах без перезаписи основных.
                int localLeft = left;
                int localUp = up;

                Console.Clear();

                //Перенос фигуры вверх - вниз
                while (localUp > 0)
                {
                    Console.WriteLine();
                    localUp--;
                }

                for (int i = 0; i < height; i++)
                {

                    for (int j = 0; j < width; j++)
                    {
                        // отступы слева - справа
                        while (localLeft > 0)
                        {
                            Console.Write(" ");
                            localLeft--;
                        }
                        Console.Write($"{symbol} ");
                    }
                    localLeft = left; // переприсваем снова значение переменной в локальную переменной, что бы на следующей итерации была возможность работать с ней.
                    Console.WriteLine();
                }

                ConsoleKey keyPressed = Console.ReadKey(true).Key;

                switch (keyPressed)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        // условие что бы не уйти в минусовое значение

                        if (up != 0)
                        {
                            up--;
                        }

                        continue;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        // условие что бы не уйти в минусовое значение

                        if (left != 0)
                        {
                            left--;
                        }

                        continue;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        up++;
                        continue;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        left++;
                        continue;
                }

                // Switch на завершение работы.
                switch (keyPressed)
                {
                    case ConsoleKey.Escape:
                        {
                            Console.WriteLine("Programm work end.");
                            break;
                        }
                }

                break;
            }

            Console.ReadKey();
        }
    }
}
