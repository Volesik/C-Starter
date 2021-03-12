using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;

            x += y >> x++ * z;
            Console.WriteLine(x); // 5

            z = ++x & y * 5;
            Console.WriteLine(z); // 2

            y /= x + 5 | z;
            Console.WriteLine(y); // 0

            z = x++ & y * 5;
            Console.WriteLine(z); // 0

            x = y << x++ ^ z;
            Console.WriteLine(x); // 0

            // по итогу все числа становятся 0. Ручные расчёты производил на листке. Скрин в архиве.
            

            Console.ReadKey();
        }
    }
}
