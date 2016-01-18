﻿namespace Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Subscriber
    {
        private string name;

        public Subscriber(string name, Publisher pub)
        {
            this.Name = name;

            pub.RaiseCustomEvent += HandleEvent;
        }
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        void HandleEvent(object sender, Event even)
        {
            Console.WriteLine("\nThis is how the event is handled:\n");
            Console.WriteLine(this.name + " received this message: {0}", even.Message);
        }
    }
}
