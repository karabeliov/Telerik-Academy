using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MagicWords
{
    static void Main()
    {
        // Input
        int n = int.Parse(Console.ReadLine());

        List<string> words = new List<string>(1005); // capacity

        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());
        }

        // Solution
        // Reorder
        for (int i = 0; i < n; i++)
        {
            var word = words[i];
            var newIndex = word.Length % (n + 1);

            words[i] = null;
            words.Insert(newIndex, word);
            words.Remove(null);
        }

        // Print
        StringBuilder result = new StringBuilder();
        for (int index = 0; index < words.Max(x => x.Length); index++) // index
        {
            foreach (var word in words) // word
            {
                if (word.Length > index)
                {
                    result.Append(word[index]);
                }        
            }
        }

        // Output
        Console.WriteLine(result);
    }
}