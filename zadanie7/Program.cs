using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 7.Составить программу вывода на экран «столбиком» четырех случайных чисел.");
            Random rnd = new Random();//создание объекта для генерации
            int value = rnd.Next();// получаем случайное число
            int value1 = rnd.Next();
            int value2 = rnd.Next();
            int value3 = rnd.Next();

            Console.WriteLine("Результат:");
            Console.WriteLine(value);
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.ReadKey();

        }
    }
}
