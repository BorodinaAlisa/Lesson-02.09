using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2.Пользователь должен ввести две числовые переменные.Программа должна поменять их местами и вывести результат,но необходиимо предосмотреть факт,что одни числа могут быть с точкой,другие с запятой.");
            Console.WriteLine("Введите первое число:");
            string n1 = Console.ReadLine();// ввод первого числа с консоли
            n1 = n1.Replace('.', ',');
            double number1 = Convert.ToDouble(n1);

            Console.WriteLine("Введите второе число:");
            string n2 = Console.ReadLine();// ввод второго числа с консоли
            n2 = n2.Replace('.', ',');
            double number2 = Convert.ToDouble(n2);


            if (!double.TryParse(n1, out number1))// проверяем корректность ввода первого числа 
            {
                Console.WriteLine("Введено некорректное значение для первого числа.");

            }

            if (!double.TryParse(n2, out number2))// проверяем корректность ввода второго числа
            {
                Console.WriteLine("Введено некорректное значение для второго числа.");

            }

            double temp = number1;//меняем значения местами
            number1 = number2;
            number2 = temp;

            Console.WriteLine("Результат:");
            Console.WriteLine($"Первое число:  {number1}");
            Console.WriteLine($"Второе число:  {number2}");
            Console.ReadKey();
        }

    }
}
