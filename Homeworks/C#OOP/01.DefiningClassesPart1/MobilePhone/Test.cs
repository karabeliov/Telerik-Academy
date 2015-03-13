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
            // MobilePhone defaultPhone = MobilePhone.iPhone4sInfo;

            // Console.WriteLine(krisPhone); // print info for kristian's phone
            // Console.WriteLine(defaultPhone); // print static member

            string vili = "+359882645890"; // contact
            DateTime endCall = DateTime.Now.AddMinutes(5); // you can change this to test: add minutes, add hours
            string infoCall = krisPhone.Call(vili, endCall);  // first call

            // Console.WriteLine(infoCall); // print call information

            endCall = DateTime.Now.AddMinutes(3); 
            infoCall = krisPhone.Call(vili, endCall); // second call

            endCall = DateTime.Now.AddMinutes(1);
            infoCall = krisPhone.Call(vili, endCall); // third call

            List<string> callHistory = krisPhone.CallHistory;

            krisPhone.DeleteCall(1); // delete first call
            krisPhone.CleanHistory(); // clean call history from kristian's phone

            // krisPhone.PrintCalls();
            double priceForMinute = 0.37;

            krisPhone.CheckBill(priceForMinute); // print your bill
        } 
    }
}