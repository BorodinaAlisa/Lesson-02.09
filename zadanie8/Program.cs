using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 8.Составить программу,в которой дано трехзначное число. У данного числа нужно зачеркнуть последнюю цифру справа и переместить ее в начало.");
            Console.WriteLine("Введите трехзначное число:");
            int number3 = Convert.ToInt32(Console.ReadLine());
            int digit = number3 % 10;// получили последнюю цифру числа
            int number4 = number3 / 10; // зачеркиваем последнюю цифру числа
            number4 = digit * 100 + number4;// переносим цифру в начало
            Console.WriteLine($"Результат: {number4}");
            Console.ReadKey();
        }
    }
}
