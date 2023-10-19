using System;
using System.Text;

namespace Part1
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Задание №1:\nСоздать класс счёт в банке\n");

            BankAccount account1 = new BankAccount
            {
                AccountNumber = 9154433601157852,
                AccountBalance = 74172.17m,
                AccountType = BankAccount.BankAccountType.Сберегательный
            };

            account1.PrintAccountInfo();
        }
        static void Task2()
        {
            Console.WriteLine("Задание №2:\nСоздать класс счёт в банке, добавить генератор уникального номера счёта\n");

            BankAccount account2 = new BankAccount
            {
                AccountBalance = 23152.28m,
                AccountType = BankAccount.BankAccountType.Текущий
            };

            account2.PrintAccountInfo();
        }
        static void Task3()
        {
            Console.WriteLine("Задание №3:\nСоздать класс счёт в банке, добавить два метода: снять и положить на счет\n");

            BankAccount account3 = new BankAccount
            {
                AccountBalance = 54120.91m,
                AccountType = BankAccount.BankAccountType.Сберегательный
            };
            account3.PrintAccountInfo();

            account3.Deposit(500);
            account3.Withdraw(120.91m);

        }
        static void Task4()
        {
            Console.WriteLine("Задание №4:\nРеализовать класс для описания здания\n");

            Building building = new Building(35, 10, 150, 2);

            building.PrintInfo();
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Title = "Skynet";

            Task1();
            Task2();
            Task3();
            Task4();

            Console.ReadKey();
        }
    }
}
