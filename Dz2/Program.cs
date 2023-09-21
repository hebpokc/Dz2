using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1");
            Console.WriteLine("Введите своё имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {name}!");

            Console.WriteLine("\nУпражнение 2.2");
            int number1, number2;
            Console.WriteLine("Введите 2 числовые переменные: ");
            while (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Неверное значение числа 1, повторите");
            }
            while (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Неверное значение числа 2, повторите");
            }
            try
            {
                if (number2 == 0) throw new Exception();
                //var result = (double)number1 / number2;
                Console.WriteLine($"Результат деления {number1}/{number2} = " + number1 / number2);
            }
            catch (Exception)
            {
                Console.WriteLine("Делить на ноль нельзя");
            }

            Console.WriteLine("\nДом.Задание 2.1");
            char ch;
            Console.WriteLine("Введите букву: ");
            int input = Console.Read();
            ch = Convert.ToChar(input);
            while (char.IsLetter(ch) == false)
            {
                Console.WriteLine("Неверный ввод");
                input = Console.Read();
                ch = Convert.ToChar(input);
            }
            if (ch == 'я' || ch == 'z')
            {
                Console.WriteLine("Это последняя буква алфавита");
            }
            else
            {
                Console.WriteLine("Следующая буква: " + Convert.ToChar(input + 1));
            }
            Console.ReadLine();

            Console.WriteLine("\nДом.Задание 2.2");
            Console.WriteLine("Введите коэффиценты квадратного уравнения: (ax^2+bx+c)");
            Console.Write("a = ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int t = Convert.ToInt32(Console.ReadLine());
            double discriminant = Math.Pow(s, 2) - (4 * f * t);
            Console.WriteLine($"\nДискриминант = {discriminant}");
            Console.Write("\n");
            if (discriminant > 0)
            {
                double x1 = (-s + Math.Sqrt(discriminant)) / (2 * f);
                double x2 = (-s - Math.Sqrt(discriminant)) / (2 * f);
                Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
            }
            else if (discriminant == 0)
            {
                double x1 = -s / (2 * f);
                Console.WriteLine($"x1 = {x1}");
            }
            else
            {
                Console.WriteLine("Нет корней");
            }

            Console.Write("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
