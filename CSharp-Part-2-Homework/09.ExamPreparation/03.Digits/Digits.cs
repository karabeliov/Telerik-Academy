using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// Not Work Correct
/// </summary>
class Digits
{
    static int[,] digits;
    static void Main()
    {
        // Input
        int n = int.Parse(Console.ReadLine());
        digits = new int[n, n];
        digits = Input(digits);

        // Solution
        int sum = SearchPattern();

        // Output
        Console.WriteLine(sum);
    }

    static int SearchPattern()
    {
        var patterns = ListOfPatterns();
        int sum = 0;
        for (int row = 0; row <= digits.GetLength(0) - 5; row++)
        {
            for (int col = 0; col <= digits.GetLength(1) - 3; col++)
            {
                if (digits[row + 2, col] == 1)
                {
                    if (CheckPattern(patterns[1], 1, row, col))
                    {
                        sum += 1;
                        continue;
                    }
                }

                if (digits[row + 1, col] == 2)
                {
                    if (CheckPattern(patterns[2], 2, row, col))
                    {
                        sum += 2;
                        continue;
                    }
                }

                int currentDigit = digits[row, col];

                if (CheckPattern(patterns[currentDigit], currentDigit, row, col))
                {
                    sum += currentDigit;
                }
            }
        }

        return sum;
    }

    private static int[,] Input(int[,] digits)
    {
        for (int row = 0; row < digits.GetLength(0); row++)  // full matrix 
        {
            string[] currentLine = Console.ReadLine().Split(' '); // input line

            for (int col = 0; col < currentLine.Length; col++)
            {
                digits[row, col] = int.Parse(currentLine[col]);
            }
        }

        return digits;
    }

    static List<bool[,]> ListOfPatterns()
    {
        var list = new List<bool[,]>();

        #region Zero
        list.Add(new bool[,] 
            { 
                // fake zero
            });
        #endregion
        #region One
        list.Add(new bool[,] 
            {
               { false, false, true },
               { false, true, true },
               { true, false, true },
               { false, false, true },
               { false, false, true },
            });
        #endregion
        #region Two
        list.Add(new bool[,] 
            {
               { false, true, false },
               { true, false, true },
               { false, false, true },
               { false, true, false },
               { true, true, true },
            });
        #endregion
        #region Three
        list.Add(new bool[,] 
            {
               { true, true, true },
               { false, false, true },
               { true, true, true },
               { false, false, true },
               { true, true, true },
            });
        #endregion
        #region Four
        list.Add(new bool[,] 
            {
               { true, false, true },
               { true, false, true },
               { true, true, true },
               { false, false, true },
               { false, false, true },
            });
        #endregion
        #region Five
        list.Add(new bool[,] 
            {
               { true, true, true },
               { true, false, false },
               { true, true, true },
               { false, false, true },
               { true, true, true },
            });
        #endregion
        #region Six
        list.Add(new bool[,] 
            {
               { true, true, true },
               { true, false, false },
               { true, true, true },
               { true, false, true },
               { true, true, true },
            });
        #endregion
        #region Seven
        list.Add(new bool[,] 
            {
               { true, true, true },
               { false, false, true },
               { false, true, false },
               { false, true, false },
               { false, true, false },
            });
        #endregion
        #region Eight
        list.Add(new bool[,] 
            {
               { true, true, true },
               { true, false, true },
               { false, true, false },
               { true, false, true },
               { true, true, true },
            });
        #endregion
        #region Nine
        list.Add(new bool[,] 
            {
               { true, true, true },
               { true, false, true },
               { false, true, true },
               { false, false, true },
               { true, true, true },
            });
        #endregion
        return list;
    }

    static bool CheckPattern(bool[,] pattern, int digit, int checkRow, int checkCol)
    {
        for (int row = 0; row < pattern.GetLength(0); row++)
        {
            for (int col = 0; col < pattern.GetLength(1); col++)
            {
                if (pattern[row, col])
                {
                    if (digits[checkRow + row, checkCol + col] != digit)
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }
}