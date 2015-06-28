namespace Game
{
    using System;
    using System.Linq;
    using System.Threading;
    using Game.Common;
    using Game.Entities.Alien;
    using Game.Entities.Human;

    class GameMain : GameEngine
    {
        public static int maxWidth = 170;
        public static int maxHight = 40;

        public static Player player = new Player(new Point(0, maxHight - 5));
        public static UI.Field field = new UI.Field(); // Mabie this shuld be moved in GameEngine
        public static FlyEnemy flyEnemy = new FlyEnemy(new Point(40, maxHight / 2)); // TODO Move in GameEngine

        public static void Main()
        {
            Console.Title = "The Last Hero";
            Console.BufferHeight = Console.WindowHeight = maxHight;
            Console.BufferWidth = Console.WindowWidth = maxWidth;
            
            GreatingsFromTheTeam();
            Loading();
            Greatings();

            // TODO Move Engine for player and enemies, Timers for Move, Draw collection... and stuff like that...
            while (player.Lives > 0)
            {
                DrawUnits();
                GameEngine();
                field.Draw();
                Thread.Sleep(100);
                Console.Clear();
            }
        }

        public static void DrawUnits()
        {
            flyEnemy.Draw();

            if (hasSpawnedEnemy)
            {
                enemy.Draw();
            }

            player.Draw();
        }

        public static void GameEngine()
        {
            Move();
            MoveEnemies();
        }
        
        public static void GreatingsFromTheTeam() //Niya Keranova
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            
            string[] greatingsTitle =
            {
            "TTTTTT EEEE  AA  M   M      RRRR   AA  M   M PPPP   AA  RRRR  TTTTTT",
            "  TT   E    A  A MM MM      R   R A  A MM MM P   P A  A R   R   TT",    
            "  TT   EEE  AAAA M M M      RRRR  AAAA M M M PPPP  AAAA RRRR    TT",  
            "  TT   E    A  A M   M      R R   A  A M   M P     A  A R R     TT",    
            "  TT   EEEE A  A M   M ____ R  RR A  A M   M P     A  A R  RR   TT"
            };
            int y = Console.WindowHeight / 2;
            int x = 3;

            for (int i = 0; i < greatingsTitle.Length; i++)
            {
                Console.SetCursorPosition(x, y++);
                Console.Write(greatingsTitle[i]);
                Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(1500);

        }

        public static void Loading() //Niya Keranova
        {
            int i = 0;
            while (i != 7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Loading : (|)");
                Thread.Sleep(50);
                Console.Clear();
                Console.WriteLine("Loading : (/)");
                Thread.Sleep(50);
                Console.Clear();
                Console.WriteLine("Loading : (~)");
                Thread.Sleep(50);
                Console.Clear();
                Console.WriteLine("Loading : (\\)");
                Thread.Sleep(50);
                Console.Clear();
                i++;
            }
        }

        public static void Greatings() //Niya Keranova
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string greatings = "REPRESENT: THE LAST HERO";
            int y = Console.WindowHeight / 2;
            int x = (Console.WindowWidth / 2 + 10) - greatings.Length;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < greatings.Length; i++)
            {
                Console.Write(greatings[i]);
                Thread.Sleep(100);
            }
            Thread.Sleep(1500);
        }
    }
}
