﻿using System;

class Enigmation
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        bool brackets = false;
        bool isNumber = false;
        string operation = "add";
        string lastOperation = "add";
        double bracketsResult = 0.0;
        double result = 0.0;
        double curNumber = 0.0;
        int i = 0;
        while (input[i] != '=')
        {
            switch (input[i])
            {
                case '(':
                    brackets = true;
                    isNumber = false;
                    lastOperation = operation;
                    break;
                case ')':
                    brackets = false;
                    isNumber = false;
                    switch (lastOperation)
                    {
                        case "add":
                            result += bracketsResult;
                            break;
                        case "sub":
                            result -= bracketsResult;
                            break;
                        case "multiply":
                            result *= bracketsResult;
                            break;
                        case "module":
                            result %= bracketsResult;
                            break;
                    }
                    bracketsResult = 0;
                    if (input[i + 1] == '=')
                    {
                        i++;
                        continue;
                    }
                    break;
                case '+':
                    operation = "add";
                    isNumber = false;
                    break;
                case '-':
                    operation = "sub";
                    isNumber = false;
                    break;
                case '*':
                    operation = "multiply";
                    isNumber = false;
                    break;
                case '%':
                    operation = "module";
                    isNumber = false;
                    break;
                default:
                    curNumber = double.Parse(input[i].ToString());
                    isNumber = true;
                    break;
            }
            if (isNumber == false)
            {
                i++;
                continue;
            }
            if (brackets)
            {
                if (i > 0 && input[i - 1] == '(')
                {
                    bracketsResult = curNumber;
                    i++;
                    continue;
                }
                switch (operation)
                {
                    case "add":
                        bracketsResult += curNumber;
                        break;
                    case "sub":
                        bracketsResult -= curNumber;
                        break;
                    case "multiply":
                        bracketsResult *= curNumber;
                        break;
                    case "module":
                        bracketsResult %= curNumber;
                        break;
                }
            }
            else
            {
                switch (operation)
                {
                    case "add":
                        result += curNumber;
                        break;
                    case "sub":
                        result -= curNumber;
                        break;
                    case "multiply":
                        result *= curNumber;
                        break;
                    case "module":
                        result %= curNumber;
                        break;
                }
            }
            i++;
        }
        Console.WriteLine("{0:F3}", result);
    }
}