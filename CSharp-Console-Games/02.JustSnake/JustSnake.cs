using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// 
/// Just Snake Console Game
/// 
/// </summary>
struct Position
{
    public int row;
    public int col;
    public Position (int row, int col)
    {
        this.row = row;
        this.col = col;
    }
}
class JustSnake
{
    static void Main()
    {
        Console.Title = "Just Snake";
        Console.BufferHeight = Console.WindowHeight = 40;
        Console.BufferWidth = Console.WindowWidth = 90;
        // Directions
        byte right = 0;
        byte left = 1;
        byte down = 2;
        byte up = 3;
        int foodTime = 0;
        int foodDissapearTime = 15000;
        int negativePoints = 0;
        Position[] directions = new Position[]
        {
            new Position(0, 1), // right
            new Position(0, -1), // left
            new Position(1, 0), // down
            new Position(-1, 0) // up
        };
        int direction = right;
        Random randomGenerator = new Random();
        // Snake
        Queue<Position> snakeElements = new Queue<Position>();
        for (int i = 0; i < 5; i++)
        {
            snakeElements.Enqueue(new Position(0, i));
        }

        // Print 
        foreach (Position position in snakeElements)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(position.col, position.row);
            Console.Write("*");
        }
        // Wall
        List<Position> walls = new List<Position>() 
        { 
            new Position(12,12),
            new Position(14,20),
            new Position(7,7),
            new Position(20,30),
            new Position(15,35)       
        };

        foreach (Position wall in walls)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(wall.col, wall.row);
            Console.Write("|");
        }
        // Food
        Position food;
        do
        {
            food = new Position(randomGenerator.Next(0, Console.WindowHeight), randomGenerator.Next(0, Console.WindowWidth));
        } while (snakeElements.Contains(food) || walls.Contains(food));
        foodTime = Environment.TickCount;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(food.col, food.row);
        Console.Write("@");
        while (true)
        {
            int speed = 100;
            if (Console.KeyAvailable)
            {
                // Move snake
                ConsoleKeyInfo userInput = Console.ReadKey();
                if (userInput.Key == ConsoleKey.RightArrow)
                {
                    if (direction != left)
                    {
                        direction = right;
                    }
                }
                if (userInput.Key == ConsoleKey.LeftArrow)
                {
                    if (direction != right)
                    {
                        direction = left;
                    }
                }
                if (userInput.Key == ConsoleKey.DownArrow)
                {
                    if (direction != up)
                    {
                        direction = down;
                    }
                }
                if (userInput.Key == ConsoleKey.UpArrow)
                {
                    if (direction != down)
                    {
                        direction = up;
                    }
                }
            }
            Position snakeHead = snakeElements.Last();           
            Position snakeDirection = directions[direction];
            Position snakeNewHead = new Position(snakeHead.row + snakeDirection.row, snakeHead.col + snakeDirection.col);

            if (snakeNewHead.row < 0)
            {
                snakeNewHead.row = Console.WindowHeight - 1;
            }
            if (snakeNewHead.row > Console.WindowHeight - 1)
            {
                snakeNewHead.row = 0;
            }
            if (snakeNewHead.col < 0)
            {
                snakeNewHead.col = Console.WindowWidth - 1;
            }
            if (snakeNewHead.col > Console.WindowWidth - 1)
            {
                snakeNewHead.col = 0;
            }
            if (snakeElements.Contains(snakeNewHead) || walls.Contains(snakeNewHead))
            {
                Console.SetCursorPosition(38, 20);              
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("GAME OVER");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(34, 22);
                int userPoints = (snakeElements.Count - 5) * 100 - negativePoints;
                if (userPoints < 0)
                {
                    userPoints = 0;
                }
                Console.WriteLine("Your points are: " + userPoints);
                Console.ResetColor();
                Console.ReadLine();
                return;
                Environment.Exit(0);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(snakeHead.col, snakeHead.row);
            Console.Write("*");
            snakeElements.Enqueue(snakeNewHead);
            Console.SetCursorPosition(snakeNewHead.col, snakeNewHead.row);
            if (direction == right)
            {
                Console.Write(">");
            }
            else if (direction == left)
            {
                Console.Write("<");
            }
            else if (direction == down)
            {
                Console.Write("v");
            }
            else if (direction == up)
            {
                Console.Write("^");
            }

            if (snakeNewHead.col == food.col && snakeNewHead.row == food.row)
            {
                // feeding snake
                do
                {
                    food = new Position(randomGenerator.Next(0, Console.WindowHeight), randomGenerator.Next(0, Console.WindowWidth));
                } while (snakeElements.Contains(food) || walls.Contains(food));
                foodTime = Environment.TickCount;
                speed += 5;
                Position wall;
                do
                {
                    wall = new Position(randomGenerator.Next(0, Console.WindowHeight), randomGenerator.Next(0, Console.WindowWidth));
                } while (snakeElements.Contains(wall) || walls.Contains(wall) || (food.row != wall.row && food.col != wall.col));
                walls.Add(wall);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(wall.col, wall.row);
                Console.Write("-");
            }
            else
            {
                Position last = snakeElements.Dequeue();
                Console.SetCursorPosition(last.col, last.row);
                Console.Write(" ");
            }
            if (Environment.TickCount - foodTime >= foodDissapearTime)
            {
                negativePoints += 50;
                Console.SetCursorPosition(food.col, food.row);
                Console.Write(" ");
                do
                {
                    food = new Position(randomGenerator.Next(0, Console.WindowHeight), randomGenerator.Next(0, Console.WindowWidth));
                } while (snakeElements.Contains(food) || walls.Contains(food));
                foodTime = Environment.TickCount;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(food.col, food.row);
            Console.Write("@");
            Thread.Sleep(200 - speed);
        }
    }
}