using System;
using System.Threading;
using System.Collections.Generic;
/// <summary>
/// 
/// Console Game "Just Cars"
/// 
/// </summary>
public struct Object
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}
class JustCars
{
    static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void PrintStringOnPosition(int x, int y, string s, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(s);
    } 
    static void Main()
    {
        Console.Title = "Just Cars";
        // Super Mario Sound 
        //Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); 
        //Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); 
        //Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); 
        //Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); 
        //Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); 
        //Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); 
        //Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); 
        //Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); 
        //Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); 
        //Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); 
        //Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); 
        //Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125);
        //Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125);
        //Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); 
        //Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125);
        //Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); 
        //Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); 
        //Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); 
        //Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); 
        //Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); 
        //Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); 
        //Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); 
        //Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); 
        //Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
        // Console size
        int playfield = 8;
        int livesCount = 3;
        double speed = 100.0;
        double acceleration = 0.5;
        Console.BufferHeight = Console.WindowHeight = 30;
        Console.BufferWidth = Console.WindowWidth = 35;
        // User Car
        Object userCar = new Object();
        userCar.x = 4;
        userCar.y = Console.WindowHeight - 1;
        userCar.c = '0';
        userCar.color = ConsoleColor.White;       
        // Other cars
        Random randomGenerator = new Random();
        List<Object> objects = new List<Object>();
        while (true)
        {
            speed+= acceleration;
            if (speed > 400)
            {
                speed = 400;
            }
            bool hitted = false;
            // Add new car
            {
                int chance = randomGenerator.Next(0,100);
                if (chance < 10)
                {
                    // Add Bonus
                    Object bonusTime = new Object();
                    bonusTime.color = ConsoleColor.Cyan;
                    bonusTime.x = randomGenerator.Next(2, playfield);
                    bonusTime.y = 0;
                    bonusTime.c = '-';
                    objects.Add(bonusTime);
                }
                else if (10 < chance && chance < 15)
                {
                    // Add Bonus
                    Object bonusLive = new Object();
                    bonusLive.color = ConsoleColor.Yellow;
                    bonusLive.x = randomGenerator.Next(2, playfield);
                    bonusLive.y = 0;
                    bonusLive.c = '+';
                    objects.Add(bonusLive);
                }
                else
                {
                Object newCar = new Object();
                newCar.color = ConsoleColor.Green;
                newCar.x = randomGenerator.Next(2, playfield);
                newCar.y = 0;
                newCar.c = '@';
                objects.Add(newCar);
                }
            }
            // Move our car (key presset)
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (userCar.x - 1 >= 2)
                    {
                        userCar.x = userCar.x - 1;
                    }                  
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (userCar.x + 1 < playfield )
                    {
                        userCar.x = userCar.x + 1;
                    }
                }
            }
            // Move cars
            List<Object> newList = new List<Object>();       
            for (int i = 0; i < objects.Count; i++)
            {
                Object oldCar = objects[i];
                Object newObject = new Object();
                newObject.x = oldCar.x;
                newObject.y = oldCar.y + 1;
                newObject.c = oldCar.c;
                newObject.color = oldCar.color;
                // Check if other cars hitting us
                if (newObject.c == '+' && newObject.y == userCar.y && newObject.x == userCar.x)
                {
                    livesCount++;
                }
                if (newObject.c == '-' && newObject.y == userCar.y && newObject.x == userCar.x)
                {
                    speed -= 20;
                }
                if (newObject.c == '@' && newObject.y == userCar.y && newObject.x == userCar.x)
                {
                        livesCount--;                   
                    hitted = true;
                    // Speed
                    speed += 50;
                    if (speed > 400)
                    {
                        speed = 400;
                    }
                    Console.Beep();
                    // Game over
                    if (livesCount <= 0)
                    {
                        PrintStringOnPosition(11, 11, "GAME OVER!!!", ConsoleColor.Red);
                        PrintStringOnPosition(11, 12, "Press [enter] to exit", ConsoleColor.Red);
                        Console.ReadLine();
                        return;
                        Environment.Exit(0);
                    }
                }                
                if (newObject.y < Console.WindowHeight)
                {
                    newList.Add(newObject);
                }                
            }
            objects = newList;
            // Clean the console
            Console.Clear();
            // Redraw playfield
            if (hitted)
            {
                objects.Clear();
                PrintOnPosition(userCar.x, userCar.y, 'X', ConsoleColor.Red);
            }
            else
            {          
                PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);
            }            
            foreach (Object car in objects)
            {
                PrintOnPosition(car.x, car.y, car.c, car.color); 
            }
            // Draw info
            for (int i = 0; i < Console.WindowHeight - 1; i++)
			{
                PrintStringOnPosition(0, i, "|", ConsoleColor.White);
                PrintStringOnPosition(9, i, "|", ConsoleColor.White);		 
			}
            PrintStringOnPosition(11, 4, "Lives: " + livesCount, ConsoleColor.White);
            PrintStringOnPosition(11, 5, "Speed: " + (int)speed, ConsoleColor.White);
            PrintStringOnPosition(11, 6, "Acceleration: " + acceleration, ConsoleColor.White);
            PrintStringOnPosition(11, 8, "Symbol @ kill you", ConsoleColor.Green);
            PrintStringOnPosition(11, 9, "Symbol + given live", ConsoleColor.Yellow);
            PrintStringOnPosition(11, 10, "Symbol - slow speed", ConsoleColor.Cyan);
            // Slow down program         
            Thread.Sleep((int)(100));
        }
    }
}