using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 23, operand2 = 5, result;
    
            Console.Write($"First operand equals -> {operand1}; Second operand equals -> {operand2} \nEnter arithmetic sign (+, -, *, /, %) > ");
            string arithmeticSign = Console.ReadLine();

            switch (arithmeticSign)
            {
                case "+":
                    result = operand1 + operand2;
                    Console.WriteLine($"Result of '+' equals {result};");
                    break;
                case "-":
                    result = operand1 - operand2;
                    Console.WriteLine($"Result of '-' equals {result};");
                    break;
                case "*":
                    result = operand1 * operand2;
                    Console.WriteLine($"Result of '*' equals {result};");
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        result = operand1 / operand2;
                        Console.WriteLine($"Result of '/' equals {result};");
                    }
                    else
                    {
                        Console.WriteLine("We can't divide 0.");
                    }
                    break;
                case "%":
                    if (operand2 != 0)
                    {
                        result = operand1 % operand2;
                        Console.WriteLine($"Result of '%' equals {result}");
                    }
                    else
                    {
                        Console.WriteLine("We can't divide 0");
                    }
                    break;
                default:
                    Console.WriteLine("You enter not valid sign. Please try again.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
