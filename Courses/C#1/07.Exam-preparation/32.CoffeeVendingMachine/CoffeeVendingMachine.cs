using System;

class CoffeeVendingMachine
{
    static void Main()
    {
        checked
        {
            int n1 = int.Parse(Console.ReadLine()); // 0.05
            int n2 = int.Parse(Console.ReadLine()); // 0.10
            int n3 = int.Parse(Console.ReadLine()); // 0.20
            int n4 = int.Parse(Console.ReadLine()); // 0.50
            int n5 = int.Parse(Console.ReadLine()); // 1.00

            double amoundMachine = double.Parse(Console.ReadLine()); // amount the developer has put in the machine
            double priceDrink = double.Parse(Console.ReadLine()); // price of the selected drink

            double allCoint = (n1 * 0.05) + (n2 * 0.10) + (n3 * 0.20) + (n4 * 0.50) + (n5 * 1.00);
            double change = amoundMachine - priceDrink;
            double result = allCoint - change;

            if (amoundMachine >= priceDrink)
            {
                // change
                if (result >= 0)
                {
                    Console.WriteLine("Yes {0:f2}", result);
                }
                else
                {
                    Console.WriteLine("No {0:f2}", -result);
                }
            }
            else 
            {
                Console.WriteLine("More {0:f2}", -change);
            }
        }
    }
}