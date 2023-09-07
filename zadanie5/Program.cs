using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 5.Найти корни квадратного уравнения.");
            Console.WriteLine("Введите коэффициенты для квадратного уравнения.");

            Console.WriteLine("a");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("b");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("c");
            double c = Convert.ToDouble(Console.ReadLine());

            double diskriminant = b * b - (4 * a * c);
            if (diskriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(diskriminant)) / 2 * a;
                double x2 = (-b - Math.Sqrt(diskriminant)) / 2 * a;
                Console.WriteLine($"Корни квадратного уравнения: х1 = {x1} , x2 = {x2}");
            }
            if (diskriminant == 0)
            {
                double x1 = (-b + Math.Sqrt(diskriminant)) / 2 * a;
                Console.WriteLine($"Корень квадратного уравнения: x = {x1}");
            }
            if (diskriminant < 0)
            {
                Console.WriteLine("Уравнениe не имеет корней");
            }
            Console.ReadKey();
        }
    }
}
