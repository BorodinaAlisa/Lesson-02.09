using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.Write("Введите первое число: ");
            string input1 = Console.ReadLine();
            if (double.TryParse(input1, NumberStyles.Any, CultureInfo.InvariantCulture, out num1))
            {
                Console.Write("Введите второе число: ");
                string input2 = Console.ReadLine();
                if (double.TryParse(input2, NumberStyles.Any, CultureInfo.InvariantCulture, out num2))
                {
                    double temp = num1;
                    num1 = num2;
                    num2 = temp;

                    Console.WriteLine($"После замены местами: Первое число = {num1}, Второе число = {num2}");
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите корректное числовое значение для второго числа.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Введите корректное числовое значение для первого числа.");
            }
        }
    }
}
