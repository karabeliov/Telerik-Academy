namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Call
    {
        private string date;
        private string time;
        private string dialPhoneNumber;
        private TimeSpan duration;

        public Call()
        { 
        }

        public Call(string date, string time, string dialPhoneNumber, TimeSpan duration)
            : this()
        {
            this.Date = date;
            this.Time = time;
            this.DialPhoneNumber = dialPhoneNumber;
            this.Duration = duration;
        }

        public string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        public string DialPhoneNumber
        {
            get { return this.dialPhoneNumber; }
            set { this.dialPhoneNumber = value; }
        }

        public TimeSpan Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        
    }
}
