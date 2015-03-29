namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Customers
    {

        private string name;
        private string id;
        private string address;

        public Customers(string name, string id, string address)
        {
            this.Name = name;
            this.ID = id;
            this.Address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

    }
}
