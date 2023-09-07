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

            Console.WriteLine("Задание 3.Найти длину окружности и площадь круга.");
            Console.WriteLine("Введите радиус окружности.");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;
            Console.WriteLine("Длина окружности:" + (circumference));
            Console.WriteLine("Плошадь круга:" + (area));


            Console.WriteLine("Задание 4.Найти значение y=cos(x).");
            Console.WriteLine("Введите значение переменной х в радианах.");
            double x = double.Parse(Console.ReadLine());
            double y = Math.Cos(x);
            Console.WriteLine($"Результат: {y}");


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
                                     

            Console.WriteLine("Задание 8.Составить программу,в которой дано трехзначное число. У данного числа нужно зачеркнуть последнюю цифру справа и переместить ее в начало.");
            Console.WriteLine("Введите трехзначное число:");
            int number3 = Convert.ToInt32(Console.ReadLine());
            int digit = number3 % 10;// получили последнюю цифру числа
            int number4 = number3 /  10; // зачеркиваем последнюю цифру числа
            number4 = digit * 100 + number4;// переносим цифру в начало
            Console.WriteLine($"Результат: {number4}");

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
