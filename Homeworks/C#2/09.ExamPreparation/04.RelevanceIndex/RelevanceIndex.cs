using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class RelevanceIndex
{
    static string[] symbols = new string[] { " ", ",", ".", "(", ")", ";", "-", "!", "?" };
    static void Main()
    {
        string searchWord = Console.ReadLine();
        int numberParagraphs = int.Parse(Console.ReadLine());

        List<string> paragraph = new List<string>();
        List<int> indexes = new List<int>();
        
        for (int i = 0; i < numberParagraphs; i++)
        {
            string[] currentLineWords = Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries);

            int relevanceIndex = 0;
            for (int j = 0; j < currentLineWords.Length; j++)
            {
                string word = currentLineWords[j];

                if (word.ToLower() == searchWord.ToLower())
                {
                    relevanceIndex++;
                    currentLineWords[j] = word.ToUpper();
                }
            }

            paragraph.Add(string.Join(" ", currentLineWords));
            indexes.Add(relevanceIndex);
        }

        List<string> sortedParagraphs = new List<string>();

        while (sortedParagraphs.Count < paragraph.Count)
        {
            int maxIndex = 0;
            int maxParagraphIndex = 0;
            for (int index = 0; index < indexes.Count; index++)
			{
                if (maxIndex < indexes[index])
                {
                    maxIndex = indexes[index];
                    maxParagraphIndex = index;
                }
            }

            sortedParagraphs.Add(paragraph[maxParagraphIndex]);
            indexes[maxParagraphIndex] = -1;
        }
        
        Console.WriteLine(string.Join(Environment.NewLine, sortedParagraphs));
    }
}