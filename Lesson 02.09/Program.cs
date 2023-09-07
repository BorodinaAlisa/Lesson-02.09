using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_02._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1(а).Вывести на экран три строки Мир Труд Май.");
            string words = "Мир Труд Май";
            Console.WriteLine(words);

            Console.WriteLine("Задание 1(б).");
            Console.WriteLine("Мир");
            Console.WriteLine("  Труд");
            Console.WriteLine("      Май");
            Console.ReadKey();


        }
    }
}
