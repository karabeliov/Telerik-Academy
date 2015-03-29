namespace _02.BankAccounts.Аccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LoanAccount : Bank, IDeposit
    {
        public LoanAccount(decimal balance, decimal interest, Customers customer)
            : base(balance, interest, customer)
        { 
            
        }

        public override void Deposit(decimal money)
        {
            if (money <= 0)
            {
                throw new IndexOutOfRangeException("Cannot deposit zero or negative money");
            }

            Balance += money;
        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Months cannot be < 0");
            }

            if ((this.Customer is Individuals && months <= 3) || (this.Customer is Companies && months <= 2))
            {
                return 0;
            }

            return this.Balance * (this.InterestRate / 100) * (months - (Customer is Individuals ? 3 : 2));
        }
    }
}
