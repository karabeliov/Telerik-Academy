namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Companies : Customers
    {
        private int bulstat;

        public Companies(string name, string id, string address, int bulstat)
            : base(name, id, address)
        {
            this.Bulstat = bulstat;
        }

        public int Bulstat
        {
            get { return bulstat; }
            set { bulstat = value; }
        }
    }
}
