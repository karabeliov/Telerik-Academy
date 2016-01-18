using System;
/// <summary>
/// 
/// Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
/// The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
/// The card faces should start from 2 to A.
/// Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
/// 
/// </summary>
class PrintDeckOf52Cards
{
    static void Main()
    {
        char hearts = (char)3;
        char diamonds = (char)4;
        char spades = (char)5;
        char clubs = (char)6;

        for (int i = 2; i <= 10; i++)
        {
            Console.WriteLine("{0,2}{1} {0,2}{2} {0,2}{3} {0,2}{4}", i, spades, clubs, hearts, diamonds);
            if (i == 10)
            {
                for (int j = 0; j < 4; j++)
                {
                    switch (j)
                    {
                        case 0: Console.WriteLine(" J{0,1}  J{1,1}  J{2,1}  J{3,1}", spades, clubs, hearts, diamonds);
                            break;
                        case 1: Console.WriteLine(" Q{0,1}  Q{1,1}  Q{2,1}  Q{3,1}", spades, clubs, hearts, diamonds);
                            break;
                        case 2: Console.WriteLine(" K{0,1}  K{1,1}  K{2,1}  K{3,1}", spades, clubs, hearts, diamonds);
                            break;
                        case 3: Console.WriteLine(" A{0,1}  A{1,1}  A{2,1}  A{3,1}", spades, clubs, hearts, diamonds);
                            break;
                    }
                }
            }
        }
    }
}