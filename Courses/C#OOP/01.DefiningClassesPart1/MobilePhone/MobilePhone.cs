namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class MobilePhone
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;

        private Battery battery;
        private Display display;
        private Call newCall = new Call();
        private StringBuilder infoCall = new StringBuilder();
        private List<string> callHistory = new List<string>();
        private decimal bill = 0; 

        private static MobilePhone iPhone4s = new MobilePhone("Apple", "iPhone 4s", 300M, "Kristian", 
            new Battery(BatteryType.Type.Li_Ion, 200, 30), new Display(4.0, 16000000));

        public static MobilePhone iPhone4sInfo 
        {
            get { return iPhone4s; }
        }

        public MobilePhone()
        {
        }

        public MobilePhone(string manufacturer, string model) 
            : this()
        {
            this.manufacturer = manufacturer;
            this.model = model;
        }

        public MobilePhone(string manufacturer, string model, decimal price, string owner) 
            : this(manufacturer, model)
        {
            this.price = price;
            this.owner = owner;
        }

        public MobilePhone(string manufacturer, string model, decimal price, string owner, Battery battery) 
            : this(manufacturer, model, price, owner)
        {
            this.battery = battery;
        }

        public MobilePhone(string manufacturer, string model, decimal price, string owner, Battery battery, Display display)
            : this(manufacturer, model, price, owner, battery)
        {
            this.display = display;
        }

        public string Model
        {
            get { return this.model; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
        }
        

        public decimal Price
        {
            get { return this.price; }
        }
        

        public string Owner
        {
            get { return this.owner; }
        }

        public Battery Battery
        {
            get { return this.battery; }
        }

        public Display Display
        {
            get { return this.display; }
        }

        public override string ToString() // print info for MobilePhone
        {
            StringBuilder testResult = new StringBuilder();

            testResult.AppendLine(String.Format("MobilePhone Information"));
            testResult.AppendLine(String.Format(new string('-', 25)));
            testResult.AppendLine(String.Format("Manufacturer: {0}", manufacturer));
            testResult.AppendLine(String.Format("Model: {0}", model));
            testResult.AppendLine(String.Format("Price: {0:c}", price));
            testResult.AppendLine(String.Format("Owner: {0}", owner));
            testResult.AppendLine(String.Format(new string('-', 25)));
            testResult.AppendLine(String.Format("Battery {0}", Environment.NewLine));
            testResult.AppendLine(String.Format("Type: {0}", battery.BatteryType));
            testResult.AppendLine(String.Format("Hours Idle: {0} hours", battery.HoursIdle));
            testResult.AppendLine(String.Format("Hours Talk: {0} hours", battery.HoursTalk));
            testResult.AppendLine(String.Format(new string('-', 25)));
            testResult.AppendLine(String.Format("Display {0}", Environment.NewLine));
            testResult.AppendLine(String.Format("Size: {0:0.0} inches", display.Size));
            testResult.AppendLine(String.Format("Number Of Colors: {0}", display.NumberOfColors));

            return testResult.ToString();
        }


        public string Call(string dialPhoneNumber, DateTime endCall)
        {
            infoCall.Clear(); // clean last call info
            newCall.Date = DateTime.Now.ToShortDateString(); // date of call
            newCall.Time = DateTime.Now.ToShortTimeString(); // time of call
            newCall.DialPhoneNumber = dialPhoneNumber; // call number
            newCall.Duration = DateTime.Parse(endCall.ToShortTimeString()) - DateTime.Parse(newCall.Time); // duration

            infoCall.AppendLine(string.Format("Date of call: " + newCall.Date));
            infoCall.AppendLine(string.Format("Time of call: " + newCall.Time));
            infoCall.AppendLine(string.Format("Dial Phone Number: " + newCall.DialPhoneNumber));
            infoCall.AppendLine(string.Format("Duration of call: " + (int)newCall.Duration.TotalSeconds + " seconds")); // in seconds

            bill += (int)newCall.Duration.TotalMinutes; // pay for minute
            callHistory.Add(infoCall.ToString()); // add info in call History
            return infoCall.ToString(); // return to phone
        }

        public List<string> CallHistory  // return call History
        { 
            get
            {
                return this.callHistory;
            }
        }

        internal void DeleteCall(int removeCall) // delete call
        {
            if (removeCall > 0) // valid input
            {
                callHistory.RemoveAt(removeCall - 1); // remove zero index
            }
        }

        internal void CleanHistory() // clean call history
        {
            callHistory.Clear();
            callHistory.Add("Call list is empty!");
        }

        internal void PrintCalls() // print call History
        {
            foreach (var call in callHistory) 
            {
                Console.WriteLine(call);
            }
        }

        internal void CheckBill(double priceForMinute) // print Bill
        {
            Console.WriteLine("Your bill is {0:c}", bill * (decimal)(priceForMinute));
        }
    }
}
