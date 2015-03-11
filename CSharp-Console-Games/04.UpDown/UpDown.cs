using System;
using System.Reflection;
/// <summary>
/// 
/// Up Down Console Game
/// 
/// </summary>
class UpDown
{
    static void Main()
    {
        Console.Title = "Up Down";
        string nameGame = "Up Down Console Game";

        string tryGuessNumber = " Try to guess the number (from 1 to 100)";
        Random generateNumber = new Random();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine("{0,49}\n", nameGame);
        Console.ResetColor();

        Console.WriteLine(tryGuessNumber);
        int endGameNumber = generateNumber.Next(1, 101);
        int minimum = 1;
        int maximum = 100;
        Console.WriteLine();
        int count = 0;
        while (true)
        {
            Console.Write(" Enter number between {0} and {1}: ", minimum, maximum);
            string inputUser = Console.ReadLine();
            int userNumber;
            bool ParseNumber = int.TryParse(inputUser, out userNumber);
            count++;
            if (!ParseNumber)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("     >>> INVALID NUMBER <<<");
                Console.ResetColor();
                Console.WriteLine();
                continue;
            }
            if (userNumber == endGameNumber)
            {
                if (minimum != maximum)
                {
                    string winer = "Congratulations you are WINER in this Game!";
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0, 55}", winer);
                    string counter = "Guessed by:";
                    Console.WriteLine("{0, 40} {1} time", counter, count);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    string winer = "Sorry, but you LOST this Game!";
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0, 55}", winer);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" If you want to start another game press | R |?");
                Console.ResetColor();
                var info = Console.ReadKey();

                if (info.Key == ConsoleKey.R)
                {
                    var fileName = Assembly.GetExecutingAssembly().Location;
                    System.Diagnostics.Process.Start(fileName);
                }
                break;
            }
            else if (userNumber > endGameNumber)
            {
                if (userNumber > maximum)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter a number LESS than {0}!!!", maximum);
                    Console.ResetColor();
                    Console.WriteLine();
                    continue;
                }
                maximum = userNumber - 1;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("     DOWN!!!");
                Console.ResetColor();
                Console.WriteLine();
            }
            else if (userNumber < endGameNumber)
            {
                if (userNumber < minimum)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter a number GREATER than {0}!!!", minimum);
                    Console.ResetColor();
                    Console.WriteLine();
                    continue;
                }
                minimum = userNumber + 1;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("     UP!!!");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}