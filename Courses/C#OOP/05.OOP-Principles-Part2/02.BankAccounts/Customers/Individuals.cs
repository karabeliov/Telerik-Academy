namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Individuals : Customers
    {

        public Individuals(string name, string id, string address, DateTime birthday)
            : base(name, id, address)
        {
            this.Birthday = birthday;
        }

        public DateTime Birthday { get; private set; }
    }
}
