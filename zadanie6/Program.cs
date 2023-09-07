using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 6(а).Составить программу обмена значениями трех величин.");
            Console.WriteLine("Введите значиние a:");
            int a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение b:");
            int b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение с:");
            int c1 = Convert.ToInt32(Console.ReadLine());

            int temp1 = b1;
            b1 = c1;
            c1 = a1;
            a1 = temp1;

            Console.WriteLine("Результат:");
            Console.WriteLine($"Значение а = {a1}");
            Console.WriteLine($"Значение b = {b1}");
            Console.WriteLine($"Значение c = {c1}");

            Console.WriteLine("Задание6(б).");
            Console.WriteLine("Введите значение а:");
            int a2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение b:");
            int b2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение с:");
            int c2 = Convert.ToInt32(Console.ReadLine());

            int temp2 = b2;
            b2 = a2;
            a2 = c2;
            c2 = temp2;

            Console.WriteLine("Результат:");
            Console.WriteLine($"Значение а: {a2}");
            Console.WriteLine($"Значение b: {b2}");
            Console.WriteLine($"Значение с: {c2}");
            Console.ReadKey();
        }
    }
}
