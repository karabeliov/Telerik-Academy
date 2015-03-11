using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

struct Dwarf
{
    public int x;
    public int y;
    public string s;
    public ConsoleColor color;
}

struct Objects
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}

class FallingRocks
{
    static void PrintDwarfOnPosition(int x, int y, string s, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(s);
    }
    static void PrintRockOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void PrintStringOnPosition(int x, int y, string s, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(s);
    }
    static void Main()
    {
        Console.Title = "Falling Rocks";
        //char[] rocksArray = { '!', '@', '#', '$', '%', '&', '^', '+', '-' };
        string dwarfSymbol = "(0)";
        double speed = 100.0;
        int playfieldWidth = 16;
        int livesCount = 5;
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 50;

        Dwarf dwarf = new Dwarf();
        {
            dwarf.x = 8;
            dwarf.y = Console.WindowHeight - 1;
            dwarf.s = dwarfSymbol;
            dwarf.color = ConsoleColor.Yellow;
        }
        Random randomGenerator = new Random();
        //int randomStone = randomGenerator.Next(rocksArray.Length);
        List<Objects> objects = new List<Objects>();

        while (true)
        {
            speed = speed + 50;
            if (speed > 400)
            {
                speed = 400;
            }
            bool isHit = false;
            {
                // adding bonus objects
                int chance = randomGenerator.Next(0, 100);
                if (chance < 10)
                {
                    Objects bonus = new Objects();
                    bonus.color = ConsoleColor.Blue;
                    bonus.c = '@';
                    bonus.x = randomGenerator.Next(0, playfieldWidth);
                    bonus.y = 0;
                    objects.Add(bonus);
                }
                else if (chance < 20)
                {
                    Objects bonus = new Objects();
                    bonus.color = ConsoleColor.DarkMagenta;
                    bonus.c = '%';
                    bonus.x = randomGenerator.Next(0, playfieldWidth);
                    bonus.y = 0;
                    objects.Add(bonus);
                }
                else
                {
                    Objects newRock = new Objects();
                    newRock.color = ConsoleColor.Green;
                    newRock.x = randomGenerator.Next(0, playfieldWidth);
                    newRock.y = 0;
                    int num = randomGenerator.Next(0, 10);
                    //newRock.c = '#';
                    //char[] rocksArray = { '!', '@', '#', '$', '%', '&', '^', '+', '-' }; //no use of this
                    newRock.c = (char)('#' + num);
                    //char[] chars = "$#*?^&".ToCharArray();
                    //Random randomChar = new Random();
                    //int num = randomChar.Next(chars.Length);
                    //Console.WriteLine(chars[num]);
                    objects.Add(newRock);
                }

            }

            // move the dwarf (key pressed)
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x = dwarf.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 1 < playfieldWidth)
                    {
                        dwarf.x = dwarf.x + 1;
                    }
                }
            }

            //creating new list of rocks
            List<Objects> newListOfRocks = new List<Objects>();

            // move rocks
            for (int i = 0; i < objects.Count; i++)
            {
                Objects oldRock = objects[i];
                Objects newObject = new Objects();
                newObject.x = oldRock.x;
                newObject.y = oldRock.y + 1;
                newObject.c = oldRock.c;
                //newObject.c = rocksArray[randomStone];
                newObject.color = oldRock.color;

                // check if rocks are hitting the dwarf
                //if (newObject.c == '%' && newObject.y == dwarf.y && newObject.x == dwarf.x)
                if (newObject.c == '%' && newObject.y == dwarf.y && newObject.x >= dwarf.x && newObject.x <= dwarf.x + 2)
                {
                    speed -= 100;
                    if (speed < 150)
                    {
                        speed = 150;
                    }
                }
                if (newObject.c == '@' && newObject.y == dwarf.y && newObject.x >= dwarf.x && newObject.x <= dwarf.x + 2)
                {
                    livesCount++;
                }
                if (newObject.color == ConsoleColor.Green)
                {
                    if (newObject.y == dwarf.y && newObject.x >= dwarf.x && newObject.x <= dwarf.x + 2)
                    {
                        if (newObject.c == '!' || newObject.c == '&' || newObject.c == '#' || newObject.c == '$' ||
                            newObject.c == '^' || newObject.c == '+' || newObject.c == '-' || newObject.c == '(' ||
                            newObject.c == ')' || newObject.c == '\'' || newObject.c == ',' || newObject.c == '*' ||
                            newObject.c == '%' || newObject.c == '@')
                        {
                            livesCount--;
                            isHit = true;
                            speed = 100;
                            if (livesCount <= 0)
                            {
                                PrintStringOnPosition(playfieldWidth + 3, 10, "!!!GAME OVER!!!", ConsoleColor.Red);
                                PrintStringOnPosition(playfieldWidth + 3, 12, "Press [ENTER] to exit...", ConsoleColor.Gray);
                                Console.ReadLine();
                                Environment.Exit(0);
                            }
                        }
                    }
                }
                if (newObject.y < Console.WindowHeight)
                {
                    newListOfRocks.Add(newObject);
                }
            }
            objects = newListOfRocks;

            // clear the console
            Console.Clear();

            // redraw playfield
            if (isHit)
            {
                Console.Beep();
                objects.Clear();
                PrintRockOnPosition(dwarf.x, dwarf.y, 'X', ConsoleColor.Red);
            }
            else
            {
                PrintDwarfOnPosition(dwarf.x, dwarf.y, dwarf.s, dwarf.color);
            }
            foreach (Objects rock in objects)
            {
                PrintRockOnPosition(rock.x, rock.y, rock.c, rock.color);
            }

            // draw info
            PrintStringOnPosition(playfieldWidth + 3, 4, "Lives: " + livesCount, ConsoleColor.White);
            PrintStringOnPosition(playfieldWidth + 3, 5, "Speed: " + speed, ConsoleColor.White);
            PrintStringOnPosition(playfieldWidth + 3, 6, "% decreases the speed", ConsoleColor.DarkMagenta);
            PrintStringOnPosition(playfieldWidth + 3, 7, "@ gives you a new life", ConsoleColor.Blue);
            PrintStringOnPosition(playfieldWidth + 3, 8, "Beware of green objects!", ConsoleColor.Green);

            // slow down program
            int maxSpeed = (int)(600 - speed);
            Thread.Sleep(maxSpeed);

            //exiting the program? how?
        }
    }
}