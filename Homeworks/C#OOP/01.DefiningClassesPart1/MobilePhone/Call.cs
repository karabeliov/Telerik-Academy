namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Call
    {
        private DateTime date;
        private DateTime time;
        private string dialPhoneNumber;
        private int duration;

        public Call()
        { 
        }

        public Call(DateTime date, DateTime time, string dialPhoneNumber, int duration)
            : this()
        {
            this.Date = date;
            this.Time = time;
            this.DialPhoneNumber = dialPhoneNumber;
            this.Duration = duration;
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }  

        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        public string DialPhoneNumber
        {
            get { return this.dialPhoneNumber; }
            set { this.dialPhoneNumber = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        
    }
}
