namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Test
    {
        static void Main()
        {
            MobilePhone krisPhone = new MobilePhone("Apple", "iPhone 6s", 300M, "Kristian", new Battery(BatteryType.Type.Li_Poly, 200, 30), new Display(5.5, 16000000));
            MobilePhone defaultPhone = MobilePhone.iPhone4sInfo;

            // Console.WriteLine(krisPhone);
            // Console.WriteLine(defaultPhone);

            Call callKris = new Call();
            callKris.Date = DateTime.Now.Date;
            callKris.Time = DateTime.Now;
            callKris.DialPhoneNumber = "+359882645890";
            callKris.Duration = DateTime.Now.Second;

        } 
    }
}