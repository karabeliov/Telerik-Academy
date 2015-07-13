using System;

class Printing
{
    static void Main()
    {
        int students = int.Parse(Console.ReadLine());
        int sheetsPaper = int.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());

        double needPaper = students * sheetsPaper;
        double reams = needPaper / 500;
        double needPrice = reams * price;

        Console.WriteLine("{0:f2}", needPrice);
    }
}