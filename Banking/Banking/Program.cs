using System;

namespace Banking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Lewis", 1000);
            Console.WriteLine("----------");
            Console.WriteLine($"////////// Current Account '{account.Number}' was created for {account.Owner} with £{account.Balance} initial balance.");
            Console.WriteLine("----------");
            Console.WriteLine();
            Console.WriteLine(account.GetAccountHistory());

            var giftCard = new GiftCardAccount("Lewis", 100, 50);
            Console.WriteLine("----------");
            Console.WriteLine($"////////// Gift Card Account '{giftCard.Number}' was created for {giftCard.Owner} with £{giftCard.Balance} initial balance.");
            Console.WriteLine("----------");
            Console.WriteLine();
            giftCard.MakeWithdrawal(20, DateTime.Now, "Get expensive coffee");
            giftCard.MakeWithdrawal(50, DateTime.Now, "Buy groceries");
            giftCard.MakeDeposit(27.50m, DateTime.Now, "Add some additional spending money");
            giftCard.PerformMonthEndTransactions();
            Console.WriteLine(giftCard.GetAccountHistory());

            var lineOfCredit = new LineOfCreditAccount("Lewis", 0, 100);
            Console.WriteLine("----------");
            Console.WriteLine($"////////// Credit Account '{lineOfCredit.Number}' was created for {lineOfCredit.Owner} with £{lineOfCredit.Balance} initial balance.");
            Console.WriteLine("----------");
            Console.WriteLine();
            lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            lineOfCredit.PerformMonthEndTransactions();
            Console.WriteLine(lineOfCredit.GetAccountHistory());

            Console.ReadLine();
        }
    }
}