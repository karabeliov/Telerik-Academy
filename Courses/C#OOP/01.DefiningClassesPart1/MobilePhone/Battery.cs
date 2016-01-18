namespace MobilePhone
{
    public class Battery : MobilePhone
    {
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType.Type batteryType;

        public Battery()
        {
        }

        public Battery(BatteryType.Type batteryType)
            : this()
        {
            this.BatteryType = batteryType;
        }

        public Battery(BatteryType.Type batteryType, int hoursIdle, int hoursTalk)
            : this(batteryType)
        {
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public BatteryType.Type BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }
    }
}
