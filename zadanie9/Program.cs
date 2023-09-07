using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 9.Известна стоимость 1 кг конфет, 1 кг печенья и 1 кг яблок.Нужно найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.");
            Console.WriteLine("Введите стоимость 1 кг конфет:");
            double candy = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите стоимость 1 кг печенья:");
            double cookie = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите стоимость 1 кг яблок:");
            double apple = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество кг конфет:");
            double candyweight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество кг печенья:");
            double cookieweight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество кг яблок:");
            double aplleweight = Convert.ToDouble(Console.ReadLine());

            double buy = (candy * candyweight) + (cookie * cookieweight) + (apple * aplleweight);
            Console.WriteLine($"Стоимость всей покупки: {buy}");
            Console.ReadKey();

        }
    }
}
