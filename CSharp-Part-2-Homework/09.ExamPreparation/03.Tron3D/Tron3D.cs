using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// Not Work Correct
/// 
/// </summary>
class Tron3D
{
    static int oldX, oldY, oldZ;
    static string redMoves, blueMoves;
    static int X, Y;
    static bool[,] used;
    static int currentRedX;
    static int currentRedY;

    static int currentBlueX;
    static int currentBlueY;

    static int redDiraction;
    static int blueDiraction;

    static void Main()
    {
        // Input
        ReadInput();

        X = oldX;
        Y = oldY + oldZ + oldY + oldZ;

        used = new bool[X + 1, Y];

        currentRedX = oldX / 2;
        currentRedY = oldY / 2;

        currentBlueX = oldX / 2;
        currentBlueY = oldY + oldZ + oldY / 2;

        redDiraction = 0; // right
        blueDiraction = 2; // left

        var redIndex = 0;
        var blueIndex = 0;

        while (true)
        {
            #region Red Player Move
            int newRedX = currentRedX;
            int newRedY = currentRedY;

            while (redIndex < redMoves.Length && redMoves[redIndex] != 'M')
            {
                if (redMoves[redIndex] == 'L')
                {
                    redDiraction = RotateLeft(redDiraction);
                }
                else // if (redMoves[redIndex] == 'R')
                {
                    redDiraction = RotateRight(redDiraction);
                }

                redIndex++;
            }

            MovePlayer(ref newRedX, ref newRedY, redDiraction);
            redIndex++;
            #endregion

            #region Blue Player Move
            int newBlueX = currentBlueX;
            int newBlueY = currentBlueY;

            while (blueIndex < blueMoves.Length && blueMoves[blueIndex] != 'M')
            {
                if (blueMoves[blueIndex] == 'L')
                {
                    blueDiraction = RotateLeft(blueDiraction);
                }
                else // if (blueMove[blueIndex] == 'R')
                {
                    blueDiraction = RotateRight(blueDiraction);
                }

                blueIndex++;
            }

            MovePlayer(ref newBlueX, ref newBlueY, blueDiraction);
            blueIndex++;
            #endregion

            #region Fix Y coords (loop)
            if (newRedY >= Y)
            {
                newRedY = 0;
            }

            if (newRedY < 0)
            {
                newRedY = Y;
            }

            if (newBlueY >= Y)
            {
                newBlueY = 0;
            }

            if (newBlueY < 0)
            {
                newBlueY = Y;
            }
            #endregion

            #region End Game
            bool redLoses = Loses(newRedX, newRedY);
            bool blueLoses = Loses(newBlueX, newBlueY);

            if (redLoses && blueLoses)
            {
                Console.WriteLine("DRAW");
            }
            else if (redLoses)
            {
                Console.WriteLine("BLUE");
            }
            else if (blueLoses)
            {
                Console.WriteLine("RED");
            }

            currentRedX = newRedX;
            currentRedY = newRedY;
            currentBlueX = newBlueX;
            currentBlueY = newBlueY;

            if (redLoses || blueLoses)
            {
                int startRedX = oldX / 2;
                int startRedY = oldY / 2;
                int diffRedX = Math.Abs(currentRedX - startRedX);
                int diffRedY = Math.Abs(currentRedY - startRedY);
                int diffRed = diffRedX + diffRedY;

                if (redLoses && blueLoses)
                {
                    Console.WriteLine(diffRed - 1);
                }
                else
                {
                    Console.WriteLine(diffRed);
                }   
     
                break;
            }

            used[newRedX, newRedY] = true;
            used[newBlueX, newBlueY] = true;
            #endregion
        }
    }

    public static bool Loses(int playerX, int playerY)
    {
        if (playerX < 0 || playerX > X)
        {
            return true;
        }

        if (used[playerX, playerY])
        {
            return true;
        }

        return false;
    }
    public static void ReadInput()
    {
        string cordinat = Console.ReadLine();

        string[] temp = cordinat.Split(' ');
        oldX = int.Parse(temp[0]);
        oldY = int.Parse(temp[1]);
        oldZ = int.Parse(temp[2]);

        redMoves = Console.ReadLine();
        blueMoves = Console.ReadLine();
    }

    public static void MovePlayer(ref int currentX, ref int currentY, int diraction)
    {
        if (diraction == 0) // rigth
        {
            currentY++;
        }
        else if (diraction == 1) // down
        {
            currentX++;
        }
        else if (diraction == 2) // left
        {
            currentY--;
        }
        else if (diraction == 3) // up
        {
            currentX++;
        }
    }
    // Diraction:
    static int RotateLeft(int diraction) // rotate left = diraction--;
    {
        int newDiraction = diraction - 1;

        if (newDiraction == -1) // -1 = 3
        {
            newDiraction = 3;
        }

        return newDiraction;
    }

    static int RotateRight(int diraction) // rotate right = diraction++;
    {
        int newDiraction = diraction + 1;

        if (newDiraction == 4) // 4 = 0  (%)
        {
            newDiraction = 0;
        }

        return newDiraction;
    }
}