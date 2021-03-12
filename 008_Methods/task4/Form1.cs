using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task4
{
    public partial class Form1 : Form
    {
        string sign = "";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Мини метод-калькулятор
        /// </summary>
        /// <param name="firstArgument">Первое значение</param>
        /// <param name="secondArgument">Второе значение</param>
        /// <param name="sign">знак операции</param>
        /// <param name="final">результат</param>
        private void Calculate(int firstArgument, int secondArgument, string sign, out int final)
        {
            final = 0;
            switch (sign)
            {
                case "+":
                    final = firstArgument + secondArgument;
                    break;
                case "-":
                    final = firstArgument - secondArgument;
                    break;
                case "*":
                    final = firstArgument * secondArgument;
                    break;
                case "/":
                    final = firstArgument / secondArgument;
                    break;
                case "%":
                    final = firstArgument % secondArgument;
                    break;
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int final = 0;

            // Если не отмечена ни одна радиокнопка, то будет выведен результат 0. Простое есловие на нажатие и вызов метода.
            if (division.Checked || subtraction.Checked || addition.Checked || multiplication.Checked || remainder.Checked)
                Calculate(Convert.ToInt32(firstValue.Text), Convert.ToInt32(secondValue.Text), sign, out final);

            result.Text = "" + final;
        }

        /*
         * Не знаю правильным оразом, так сказать по феншую ли я делаю присваивание знаков, если есть более елегантное решение, просьба подсказать, например может условие и т.д.
         */

        private void division_CheckedChanged(object sender, EventArgs e)
        {
            sign = "/";
        }

        private void subtraction_CheckedChanged(object sender, EventArgs e)
        {
            sign = "-";
        }

        private void addition_CheckedChanged(object sender, EventArgs e)
        {
            sign = "+";
        }

        private void multiplication_CheckedChanged(object sender, EventArgs e)
        {
            sign = "*";
        }

        private void remainder_CheckedChanged(object sender, EventArgs e)
        {
            sign = "%";
        }
    }
}
