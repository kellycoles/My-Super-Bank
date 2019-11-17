using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kelly", 1_000);
            Console.WriteLine($"Account {account.Number} was created for: {account.Owner} with ${account.Balance}.");
            account.MakeWithdrawal(120, DateTime.Now, "gym membership");
            account.MakeDeposit(300, DateTime.Now, "got paid");
            account.MakeWithdrawal(50, DateTime.Now, "cable bill");
            account.MakeWithdrawal(20, DateTime.Now, "water bill");

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
