using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task
{
    class Program
    {
        struct Student
        {
            public string surname;
            public string name;
            public string id;
            public string birthday;
            public char alcoCategory;
            public double alcoVolume;
            public Student(string s, string n, string i, string b, char ac, double av)
            {
                surname = s;
                name = n;
                id = i;
                birthday = b;
                alcoCategory = ac;
                alcoVolume = av;
            }
            public void Print()
            {
                Console.WriteLine($"Фамилия: {surname}\nИмя: {name}\nID: {id}\nДата рождения: {birthday}\nКатегоря алкоголизма: {alcoCategory}\nОбъем выпитого алкоголя: {alcoVolume}");
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Задание 1");
            Console.WriteLine("Тип данных — Максимальное значение — Минимальное значение\n");
            Console.WriteLine("bool - " + "True - " + "False");
            Console.WriteLine("int - Max: " + int.MaxValue + " - Min: " + int.MinValue);
            Console.WriteLine("uint - Max: " + uint.MaxValue + " - Min: " + uint.MinValue);
            Console.WriteLine("byte - Max: " + byte.MaxValue + " - Min: " + byte.MinValue);
            Console.WriteLine("sbyte - Max: " + sbyte.MaxValue + " - Min: " + sbyte.MinValue);
            Console.WriteLine("short - Max: " + short.MaxValue + " - Min: " + short.MinValue);
            Console.WriteLine("ushort - Max: " + ushort.MaxValue + " - Min: " + ushort.MinValue);
            Console.WriteLine("long - Max: " + long.MaxValue + " - Min: " + long.MinValue);
            Console.WriteLine("ulong - Max: " + ulong.MaxValue + " - Min: " + ulong.MinValue);
            Console.WriteLine("float - Max: " + float.MaxValue + " - Min: " + float.MinValue);
            Console.WriteLine("double - Max: " + double.MaxValue + " - Min: " + double.MinValue);
            Console.WriteLine("decimal - Max: " + decimal.MaxValue + " - Min: " + decimal.MinValue);
            Console.WriteLine("char - Max: " + char.MaxValue + " - Min: " + char.MinValue);
            Console.WriteLine("string - Max: " + "Undefined" + " - Min: " + "Undefined");
            Console.WriteLine("object - Max: " + "Undefined" + " - Min: " + "Undefined");

            Console.WriteLine("\nЗадание 2");
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите ваш город: ");
            string city = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            string age = Console.ReadLine();
            Console.Write("Введите ваш PIN: ");
            string PIN = Console.ReadLine();
            int ageOut, PINOut;
            if (!int.TryParse(age, out ageOut) | !int.TryParse(PIN, out PINOut))
            {
                Console.WriteLine("\nНеверный тип данных");
            }
            else
            {
                if (ageOut < 0 || ageOut > 125)
                {
                    Console.WriteLine("\nНеверно введен возраст");
                }
                else if (PINOut > 9999)
                {
                    Console.WriteLine("\nНеверно введен PIN");
                }
                else
                {
                    Console.WriteLine($"\nИнформация о пользователе\nИмя: {name}\nГород: {city}\nВозраст: {ageOut}\nPIN: {PINOut}");
                }
            }

            Console.WriteLine("\nЗадание 3");
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            string output = "";
            foreach (char i in input)
            {
                if (char.IsLetter(i))
                {
                    if (char.IsUpper(i))
                    {
                        output += char.ToLower(i);
                    }
                    else
                    {
                        output += char.ToUpper(i);
                    }
                }
                else
                {
                    Console.WriteLine("Строка содержит не только буквы или не содержит их вообще");
                    break;
                }
            }
            Console.WriteLine($"Полученная строка: {output}");

            Console.WriteLine("\nЗадание 4");
            Console.Write("Введите строку: ");
            string stringInput = Console.ReadLine();
            Console.Write("Введите подстроку: ");
            string substringInput = Console.ReadLine();
            int count = 0;

            if (stringInput.Length != 0 && substringInput.Length != 0)
            {
                count = (stringInput.Length - stringInput.Replace(substringInput, "").Length) / substringInput.Length;
            }
            else
            {
                Console.WriteLine("\nВведены пустые строки");
            }
            Console.WriteLine($"\nКоличество вхождений подстроки в строку: {count}");

            Console.WriteLine("\nЗадание 5");
            Console.Write("Введите стандартную цену: ");
            string normPrice = Console.ReadLine();
            Console.Write("Введите скидку в DutyFree: ");
            string salePrice = Console.ReadLine();
            Console.Write("Введите стоимость отпуска: ");
            string holidayPrice = Console.ReadLine();
            int normOut, saleOut, holidayOut;
            if (!int.TryParse(normPrice, out normOut) | !int.TryParse(salePrice, out saleOut) | !int.TryParse(holidayPrice, out holidayOut))
            {
                Console.WriteLine("Неверный тип данных");
            }
            else
            {
                if (saleOut > 0 && saleOut <= 100)
                {
                    Console.WriteLine($"Бутылок виски беспошлинной торговли нужно купить: " + (holidayOut / (normOut / 100 * saleOut) + 1));
                }
            }

            Console.WriteLine("\nЗадание 6 (поприветствуйте консоль)");
            string hello = Console.ReadLine();
            if (hello.ToLower() == "привет" || hello.ToLower() == "здравствуйте")
            {
                Console.WriteLine("\n- Как тебя зовут?");
                string inName = Console.ReadLine();
                Console.WriteLine($"- Привет, {inName}!");
                string inp = Console.ReadLine();
                if (inp.ToLower() == "знаешь ли ты что-то о тайной комнате" || inp.ToLower() == "знаешь ли ты что-то о тайной комнате?")
                {
                    Console.WriteLine("- Да");
                    string input2 = Console.ReadLine();
                    if (input2.ToLower() == "можешь рассказать о ней" || input2.ToLower() == "можешь рассказать о ней?")
                    {
                        Console.WriteLine("- Нет");
                        Thread.Sleep(5000);
                        Console.WriteLine("- ...но могу показать");
                        Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                        Console.WriteLine("\nКонсоль сменила цвет");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
            }

            Console.WriteLine("\nЗадание 7");
            Console.Write("Введите 12 цифр штрихкода EAN-13: ");
            string code = Console.ReadLine();
            string codeRandom = "";
            long fullCode;
            for (int i = 0; i < 12; i++)
            {
                int digit = rnd.Next(10);
                codeRandom += digit;
            }

            Console.WriteLine($"\nВаш код: {code}");
            Console.WriteLine($"Рандомный код: {codeRandom}");

            int sumEven = 0;
            int sumOdd = 0;
            string Contol(string codeInput)
            {
                for (int i = 0; i < 12; i++)
                {
                    int digit = int.Parse(codeInput[i].ToString());

                    if (i % 2 == 0)
                    {
                        sumOdd += digit;
                    }
                    else
                    {
                        sumEven += digit;
                    }
                }
                int total = sumEven * 3 + sumOdd;
                int controlDigit = 0;
                if (total % 10 != 0)
                {
                    controlDigit = (((total / 10) + 1) * 10) - total;
                }
                return controlDigit.ToString();
            }
            if (code.Length != 12 || !long.TryParse(code, out fullCode))
            {
                Console.WriteLine("Неверный ввод");
            }
            else
            {
                Console.WriteLine("\nКонтрольная цифра вашего числа: " + Contol(code));
            }
            Console.WriteLine("Контрольная цифра рандомного числа: " + Contol(codeRandom));

            Console.WriteLine("\nЗадание 8");
            double sumAlco = 0;
            Student[] students = new Student[5];
            students[0] = new Student("Прохоров", "Евгений", "1", "12.02.2005", 'a', 52);
            students[1] = new Student("Сергеева", "Анастасия", "2", "30.01.2005", 'd', 0);
            students[2] = new Student("Владимиров", "Богдан", "3", "01.09.2005", 'c', 7.9);
            students[3] = new Student("Винокурова", "Кира", "4", "07.11.2005", 'c', 10);
            students[4] = new Student("Давыдов", "Кирилл", "5", "23.06.2005", 'b', 19);

            foreach (var i in students)
            {
                sumAlco += i.alcoVolume;
            }
            Console.WriteLine($"Общий объем выпитого алкоголя: {sumAlco}\n");

            foreach (var i in students)
            {
                Console.WriteLine($"{i.name} {i.surname} выпивает {i.alcoVolume} л. в год, что состовляет {Math.Round(i.alcoVolume / sumAlco * 100, 2)}%");
            }

            Console.Write("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
