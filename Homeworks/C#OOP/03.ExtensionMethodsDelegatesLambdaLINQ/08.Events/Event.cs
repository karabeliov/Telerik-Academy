namespace Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Event : EventArgs
    {
        private string message;

        public Event(string message)
        {
            this.Message = message;
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        
    }
}
