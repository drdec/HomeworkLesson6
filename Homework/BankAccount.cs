using System;

namespace BankAccount
{
    public class BankAccounts 
    {
        private string AccountId { get; set; }
        private int Balance { get; set; }
        private BankAccountType AccountType { get; set; }

        /// <summary>
        /// Конструктор по умолчанию, все значения будут приведены к нулю
        /// </summary>
        public BankAccounts()
        {
            CreateAccount();
        }

        /// <summary>
        /// Конструктор, назначение начального баланса
        /// </summary>
        /// <param name="balance"></param>
        public BankAccounts(int balance)
        {
            CreateAccount(balance);
        }

        /// <summary>
        /// Конструктор, назначение типа банковского счёта
        /// </summary>
        /// <param name="accountType"></param>
        public BankAccounts(BankAccountType accountType)
        {
            CreateAccount(0, accountType);
        }

        /// <summary>
        /// Конструктор, назначение начального баланса и типа банковского счёта
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="accountType"></param>
        public BankAccounts(int balance, BankAccountType accountType)
        {
            CreateAccount(balance, accountType);
        }

        private void CreateAccount(int balance = 0, BankAccountType accountType = BankAccountType.Current)
        {
            if (balance < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нельзя создать счёт с отрицательным балансом, пожалуйста, " +
                                  "проверьте корректность вводимых данных!!! " +
                                  "Баланс на счёте будет равен нулю!!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            else
            {
                Balance = balance;
            }

            AccountId = CreatorIdForBankAccount.GenerateId();
            AccountType = accountType;
        }

        /// <summary>
        /// Пополнение баланс
        /// </summary>
        /// <param name="money"></param>
        public void PutMoneyIn(int money)
        {
            Balance += money;
        }

        /// <summary>
        /// снятие средств с банковской карточки
        /// </summary>
        /// <param name="money"></param>
        public void Withdrawal(int money)
        {
            if (money < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Извивните, введите корректное значение!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            else if (Balance - money < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Извивните, у Вас недостаточно средств, пожалуйста, введите корректное значение!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            else
            {
                Balance -= money;
            }
        }

        public static bool operator ==(BankAccounts accountOne, BankAccounts accountTwo)
        {
            return accountOne.Balance == accountTwo.Balance && accountOne.AccountType == accountTwo.AccountType;
        }

        public static bool operator !=(BankAccounts accountOne, BankAccounts accountTwo)
        {
            return accountOne.Balance != accountTwo.Balance || accountOne.AccountType != accountTwo.AccountType;
        }

        public override bool Equals(object obj)
        {
            BankAccounts accounts = obj as BankAccounts;
            return AccountType == accounts.AccountType && Balance == accounts.Balance;
        }

        public override string ToString()
        {
            return $"Balance = {Balance}\n" +
                   $"Card account - {AccountId}\n" +
                   $"Type card account - {AccountType}";
        }
    }
}