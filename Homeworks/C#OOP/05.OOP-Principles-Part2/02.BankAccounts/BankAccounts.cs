namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using _02.BankAccounts.Аccounts;

    class BankAccounts
    {
        static void Main()
        {
            Customers kris = new Individuals("Kris", "65654756765", "Sofia", new DateTime(1990, 10, 25));

            Customers krisOOD = new Companies("Kris OOD", "65654656765", "Plovdiv", 325343);

            Console.WriteLine(krisOOD is Individuals);
            Console.WriteLine(kris is Individuals);

            Bank mortgageAccTest = new MortgageAccount(200.2m, 0.6m, kris);
            Bank mortgageAccTest1 = new MortgageAccount(200.2m, 0.6m, krisOOD);

            Console.WriteLine(mortgageAccTest.CalculateInterest(15));
            Console.WriteLine(mortgageAccTest1.CalculateInterest(15));

            Bank loanAccTest = new LoanAccount(200.2m, 0.6m, kris);
            Bank loanAccTest1 = new LoanAccount(200.2m, 0.6m, krisOOD);

            Console.WriteLine(loanAccTest.CalculateInterest(11));
            Console.WriteLine(loanAccTest1.CalculateInterest(11));

            Bank depositAccTest = new DepositAccount(3200.2m, 0.6m, kris);
            Bank depositAccTest1 = new DepositAccount(1200.2m, 0.6m, krisOOD);

            Console.WriteLine(depositAccTest.CalculateInterest(11));
            Console.WriteLine(depositAccTest1.CalculateInterest(11));

            depositAccTest.Deposit(200);
            Console.WriteLine(depositAccTest.Balance);
            var depositAcc = depositAccTest as DepositAccount;
            depositAcc.Draw(300);
            Console.WriteLine(depositAcc.Balance);
        }
    }
}
