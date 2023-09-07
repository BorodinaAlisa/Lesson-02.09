using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4.Найти значение y=cos(x).");
            Console.WriteLine("Введите значение переменной х в радианах.");
            double x = double.Parse(Console.ReadLine());
            double y = Math.Cos(x);
            Console.WriteLine($"Результат: {y}");
            Console.ReadKey();

        }
    }
}
