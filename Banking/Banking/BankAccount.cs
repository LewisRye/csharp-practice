using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 10000;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }
        private List<Transaction> allTransactions = new List<Transaction>();
        public virtual void PerformMonthEndTransactions() { }
        private readonly decimal _minimumBalance;

        public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) 
        {
        }

        public BankAccount(string name, decimal initialBalance, decimal minimumBalance)
        {
            Random rnd = new Random();
            accountNumberSeed = rnd.Next(1000000000, 1999999999); // generating a random ID

            Number = accountNumberSeed.ToString();

            Owner = name;
            _minimumBalance = minimumBalance;
            if (initialBalance > 0)
                MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < _minimumBalance)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\t\tAmount\t\tBalance\t\tNote");
            report.AppendLine("----------------------------------------------------------------------------------------------------------------------");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t\t£{item.Amount}\t\t£{balance}\t\t{item.Notes}");
            }

            return report.ToString();
        }
    }
}
