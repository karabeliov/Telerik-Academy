namespace MobilePhone
{
    using System;
    using System.Text;
    public class MobilePhone
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;

        private Battery battery;
        private Display display;

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

        public override string ToString()
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
    }
}
