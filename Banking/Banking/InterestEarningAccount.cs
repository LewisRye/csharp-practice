using System;

namespace Banking
{
    public class InterestEarningAccount : BankAccount
    {
        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {

        }

        public override void PerformMonthEndTransactions()
        {
            if (Balance > 500m)
            {
                decimal interest = Balance * 1m;
                MakeDeposit(interest, DateTime.Now, "APPLYING MONTHLY INTEREST");
            }
        }
    }
}
