using System;

/*
 * Задание абсоютно как по мне некорректно написано, так как с него ничего абсолютно не понятно, что сделать, так как на входе требуется ввести только сумму одного платежа, 
 * какая общая сумма кредита, на сколько кредитовали клиента не известно, правильное решение или нет не понятно. 
 */

namespace task2
{
    class Program
    {
        /// <summary>
        /// Метод который расчитывает сумму кредиту, с значением кредита по умолчанию 700
        /// </summary>
        /// <param name="monthPay">Ежемесячный платеж</param>
        /// <param name="sum">Сумма кредите</param>
        static void CreditCalculate(int monthPay, decimal sum = 700)
        {
            decimal result = sum - monthPay;

            if (result == 0)
            {
                Console.WriteLine("Задолженности нету");
            }
            else if (result > 0)
            {
                Console.WriteLine($"Сумма задолженности {result}");
            }
            else
            {
                Console.WriteLine($"Сумма переплаты {-result}");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите сумму ежемесячного платежа > ");
            int monthPay = Convert.ToInt32(Console.ReadLine());

            CreditCalculate(monthPay);

            Console.ReadKey();
        }
    }
}
