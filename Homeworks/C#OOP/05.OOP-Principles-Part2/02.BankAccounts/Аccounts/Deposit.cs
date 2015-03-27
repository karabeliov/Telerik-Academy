namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Deposit : IDisposable
    {
        private decimal balance;
        public void Dispose(decimal money)
        {
            if (money <= 0)
            {
                throw new IndexOutOfRangeException("Cannot deposit zero or negative money");
            }

            balance += money;
        }

        public void Draw(decimal money)
        {
            if (money <= 0)
            {
                throw new IndexOutOfRangeException("Cannot deposit zero or negative money");
            }

            balance -= money;
        }
    }
}
