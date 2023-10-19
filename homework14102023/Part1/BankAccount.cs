using System;

namespace Part1
{
    public class BankAccount
    {
        public enum BankAccountType
        {
            Текущий,
            Сберегательный
        }

        private long accountNumber;
        private decimal accountBalance;
        private BankAccountType accountType;
        private static int generatedAccountNumber = 0;

        public static int GenerateAccountNumber()
        {
            return generatedAccountNumber++;
        }

        public long AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public decimal AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }
        public BankAccountType AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                accountBalance += amount;
                Console.WriteLine($"Вы положили на счёт {accountType} под номером {generatedAccountNumber}, {amount} ₽. Теперь на нём {accountBalance} ₽\n");
            }
            else
            {
                Console.WriteLine("Неправильный формат ввода! Депозит не может быть отрицательным\n");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= accountBalance)
            {
                accountBalance -= amount;
                Console.WriteLine($"Вы сняли со счёта {accountType} под номером {generatedAccountNumber}, {amount} ₽. Теперь на нём {accountBalance} ₽\n");
            }
            else
            {
                Console.WriteLine("Невозможно совершить операцию! Недостаточно средств!\n");
            }
        }
        public BankAccount()
        {
            accountNumber = GenerateAccountNumber();
            accountBalance = 0;
            accountType = BankAccountType.Сберегательный;
        }
        public void PrintAccountInfo()
        {
            Console.WriteLine($"Тип счёта: {accountType}");
            Console.WriteLine($"Номер счёта: {accountNumber}");
            Console.WriteLine($"Баланс: {accountBalance} ₽\n");
        }
    }
}
