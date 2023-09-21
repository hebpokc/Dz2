using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab2
{
    class Program
    { 
        enum BankAccountType
        {
            current,
            savings
        }
        enum University
        {
            KGU,
            KAI,
            KHTI
        }
        struct BankAccout
        {
            public string number;
            public BankAccountType bat;
            public long balance;
            public void Print()
            {
                Console.WriteLine($"\nИнформация о банковском счете\nНомер банк.счета: {number}\nТип банк.счета: {bat}\nБаланс: {balance}");
            }
        }
        struct Worker
        {
            public string name;
            public University university;
            public void Print()
            {
                Console.WriteLine($"\nИнформация о работнике\nИмя: {name}\nВУЗ: {university}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1");
            BankAccountType ba = BankAccountType.current;
            Console.WriteLine($"Банковский счет: {ba}");

            Console.WriteLine("\nУпражнение 3.2");
            BankAccout Account = new BankAccout();
            Account.number = "4078 9784 1000 9820";
            Account.bat = BankAccountType.savings;
            Account.balance = 1000000;
            Account.Print();

            Console.WriteLine("\nДом.задание 3.1");
            Worker worker = new Worker();
            worker.name = "Альберт";
            worker.university = University.KGU;
            worker.Print();

            Console.Write("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
