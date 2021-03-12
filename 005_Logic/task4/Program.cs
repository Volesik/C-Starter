using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter work experience > ");
            int experience = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter base salary > ");
            int salary = Convert.ToInt32(Console.ReadLine());

            //double bonus;
            decimal bonus; // начал сначала использовать double, но чисто по логике это возможно приравнять к банковским(финансовым) операциям, правильнее тогда использовать decimal для большей точности. 

            if (experience < 5)
            {
                bonus = (decimal)(salary + (salary * 0.1));
                Console.WriteLine($"Salary - {salary}; Experience - {experience}; Salary with bonus - {bonus};");
            }
            else if (experience >= 5 && experience < 10)
            {
                bonus = (decimal)(salary + (salary * 0.15));
                Console.WriteLine($"Salary - {salary}; Experience - {experience}; Salary with bonus - {bonus};");
            }
            else if (experience >= 10 && experience < 15)
            {
                bonus = (decimal)(salary + (salary * 0.25));
                Console.WriteLine($"Salary - {salary}; Experience - {experience}; Salary with bonus - {bonus};");
            }
            else if (experience >= 15 && experience < 20)
            {
                bonus = (decimal)(salary + (salary * 0.35));
                Console.WriteLine($"Salary - {salary}; Experience - {experience}; Salary with bonus - {bonus};");
            }
            else if (experience >= 20 && experience < 25)
            {
                bonus = (decimal)(salary + (salary * 0.45));
                Console.WriteLine($"Salary - {salary}; Experience - {experience}; Salary with bonus - {bonus};");
            }
            else
            {
                bonus = (decimal)(salary + (salary * 0.5));
                Console.WriteLine($"Salary - {salary}; Experience - {experience}; Salary with bonus - {bonus};");
            }

            Console.ReadKey();
        }
    }
}
