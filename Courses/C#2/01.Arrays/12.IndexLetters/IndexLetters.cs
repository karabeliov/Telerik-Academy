using System;

class IndexLetters
{
    static void Main()
    {
        string[] alphabet = new string[] 
        {         
            "A", "B", "C", "D", "E", "F",
            "G", "H", "I", "J", "K", "L",
            "M", "N", "O", "P", "Q", "R",
            "S", "T", "U", "V", "W", "X",
            "Y", "Z", 
        };

        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        word = word.ToUpper(); // make all letters Upper
        int index = 0;
        for (int i = 0; i < word.Length; i++)
        {
            index = Array.BinarySearch(alphabet, word[i].ToString()); // find index 

            if (i != word.Length - 1) // remove last coma
            {
                Console.Write("{0}, ", index);
            }
            else
            {
                Console.Write("{0}", index);
            }
            
        }

        Console.WriteLine();
    }
}