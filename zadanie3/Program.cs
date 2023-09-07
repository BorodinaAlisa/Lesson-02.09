using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3.Найти длину окружности и площадь круга.");
            Console.WriteLine("Введите радиус окружности.");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;
            Console.WriteLine("Длина окружности:" + (circumference));
            Console.WriteLine("Плошадь круга:" + (area));
            Console.ReadKey();
        }
    }
}
