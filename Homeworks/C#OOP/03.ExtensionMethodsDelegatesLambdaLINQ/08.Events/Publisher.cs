namespace Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Publisher
    {
        public delegate void EventHandler(object sender, Event even);

        public event EventHandler RaiseCustomEvent;
        public void RaiseEvent()
        {
            Console.WriteLine("Event will be raised!");
            OnRaiseCustomEvent(new Event("This is the custom event"));
        }

        protected virtual void OnRaiseCustomEvent(Event even)
        {
            EventHandler handler = RaiseCustomEvent;

            if (handler != null)
            {
                even.Message += String.Format(" at {0}", DateTime.Now);

                handler(this, even);
            }
        }
    }
}
