namespace MinesConsoleGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Mines
    {
        public class Scores
        {
            string name;
            int score;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Score
            {
                get { return score; }
                set { score = value; }
            }

            public Scores() { }

            public Scores(string name, int score)
            {
                this.Name = name;
                this.Score = score;
            }
        }

        static void Main()
        {
            string command;
            char[,] field = CreateGameField();
            char[,] bombs = BetBombs();
            int count = 0;
            bool stillAlive = false;
            List<Scores> champions = new List<Scores>(6);
            int row = 0;
            int col = 0;
            bool showMainMenu = true;
            const int maks = 35;
            bool youWin = false;

            do
            {
                if (showMainMenu)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    DrawField(field);
                    showMainMenu = false;
                }

                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        GiveRank(champions);
                        break;
                    case "restart":
                        field = CreateGameField();
                        bombs = BetBombs();
                        DrawField(field);
                        stillAlive = false;
                        showMainMenu = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                RefreshBattleField(field, bombs, row, col);
                                count++;
                            }

                            if (maks == count)
                            {
                                youWin = true;
                            }
                            else
                            {
                                DrawField(field);
                            }
                        }
                        else
                        {
                            stillAlive = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (stillAlive)
                {
                    DrawField(bombs);

                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
                        "Daj si niknejm: ", count);

                    string nickname = Console.ReadLine();
                    Scores player = new Scores(nickname, count);

                    if (champions.Count < 5)
                    {
                        champions.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Score < player.Score)
                            {
                                champions.Insert(i, player);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Scores first, Scores second) => second.Name.CompareTo(first.Name));
                    champions.Sort((Scores first, Scores second) => second.Score.CompareTo(first.Score));
                    GiveRank(champions);

                    field = CreateGameField();
                    bombs = BetBombs();
                    count = 0;
                    stillAlive = false;
                    showMainMenu = true;
                }

                if (youWin)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    DrawField(bombs);
                    Console.WriteLine("Daj si imeto, batka: ");

                    string name = Console.ReadLine();
                    Scores score = new Scores(name, count);
                    champions.Add(score);
                    GiveRank(champions);
                    field = CreateGameField();
                    bombs = BetBombs();
                    count = 0;
                    youWin = false;
                    showMainMenu = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void GiveRank(List<Scores> score)
        {
            Console.WriteLine("\nTo4KI:");

            if (score.Count > 0)
            {
                for (int i = 0; i < score.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, score[i].Name, score[i].Score);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void RefreshBattleField(char[,] field,
            char[,] bombs, int row, int col)
        {
            char bombsCount = GenerateSymbols(bombs, row, col);
            bombs[row, col] = bombsCount;
            field[row, col] = bombsCount;
        }

        private static void DrawField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int row = 0; row < boardRows; row++)
            {
                for (int col = 0; col < boardColumns; col++)
                {
                    board[row, col] = '?';
                }
            }

            return board;
        }

        private static char[,] BetBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] gameField = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    gameField[row, col] = '-';
                }
            }

            List<int> field = new List<int>();

            while (field.Count < 15)
            {
                Random random = new Random();
                int bombPlace = random.Next(50);

                if (!field.Contains(bombPlace))
                {
                    field.Add(bombPlace);
                }
            }

            foreach (int bomb in field)
            {
                int col = (bomb / cols);
                int row = (bomb % cols);

                if (row == 0 && bomb != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                gameField[col, row - 1] = '*';
            }

            return gameField;
        }

        private static void FillBattleField(char[,] field)
        {
            int cols = field.GetLength(0);
            int rows = field.GetLength(1);

            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    if (field[col, row] != '*')
                    {
                        char symbol = GenerateSymbols(field, col, row);
                        field[col, row] = symbol;
                    }
                }
            }
        }

        private static char GenerateSymbols(char[,] field, int row, int col)
        {
            int count = 0;
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (field[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (field[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < cols)
            {
                if (field[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (field[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (field[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (field[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (field[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}