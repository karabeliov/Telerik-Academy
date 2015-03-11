using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CSharpBrackets
{
    static StringBuilder sb = new StringBuilder();
    static string tabSymbol;
    static int countTags = 0;
    static bool printNewLine = false;
    static bool isFirstSymbol = true;
    static void Main()
    {
        int nLines = int.Parse(Console.ReadLine());

        tabSymbol = Console.ReadLine();

        for (int i = 0; i < nLines; i++)
        {
            string line = Console.ReadLine().Trim();

            HandleLine(line);
        }

        Console.WriteLine(sb);
    }

    private static void HandleLine(string line)
    {
        for (int ch = 0; ch < line.Length; ch++)
        {
            char currentChar = line[ch];

            if (printNewLine && char.IsWhiteSpace(currentChar))
            {
                continue;
            }

            if (printNewLine)
            {
                sb.AppendLine();
                printNewLine = false;
                isFirstSymbol = true;
            }

            if (currentChar == '{')
            {
                if (!printNewLine)
                {
                    if (!isFirstSymbol)
                    {
                        if (sb.Length > 0 && char.IsWhiteSpace(sb[sb.Length - 1]))
                        {
                            sb.Remove(sb.Length - 1, 1);
                        }

                        sb.AppendLine();
                    }
                }

                AppendTabs();
                sb.Append(currentChar);
                countTags++;
                printNewLine = true;
            }
            else if (currentChar == '}')
            {
                countTags--;

                if (!printNewLine)
                {
                    if (!isFirstSymbol)
                    {
                        if (sb.Length > 0 && char.IsWhiteSpace(sb[sb.Length - 1]))
                        {
                            sb.Remove(sb.Length - 1, 1);
                        }

                        sb.AppendLine();
                    }
                }

                AppendTabs();
                sb.Append(currentChar);
                printNewLine = true;
            }
            else
            {
                if (isFirstSymbol)
                {
                    AppendTabs();
                }

                if (!(isFirstSymbol && char.IsWhiteSpace(currentChar)))
                {
                    if (!(ch < line.Length - 1 && char.IsWhiteSpace(line[ch]) && char.IsWhiteSpace(line[ch + 1])))
                    {
                        if (!(ch == line.Length - 1 && char.IsWhiteSpace(currentChar)))
                        {
                            sb.Append(currentChar);
                        }
                    }
                }
                
                isFirstSymbol = false;
            }
        }

        printNewLine = true;
        isFirstSymbol = true;
    }

    private static void AppendTabs()
    {
        for (int i = 0; i < countTags; i++)
        {
            sb.Append(tabSymbol);
        }
    }
}