namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using _02.BankAccounts.Аccounts;

    public abstract class Bank : IDeposit
    {
        private decimal balance;
        private decimal interestRate;
        public Bank(decimal balance, decimal interest, Customers customer)
        {
            this.Balance = balance;
            this.InterestRate = interest;
            this.Customer = customer;
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance cannot be < 0");
                }

                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest cannot be < 0");
                }
                this.interestRate = value; 
            }
        }

        public Customers Customer { get; private set; }

        public virtual decimal CalculateInterest(int months)
        {
            return this.Balance * (this.InterestRate / 100) * months;
        }

        public abstract void Deposit(decimal money);
    }
}
