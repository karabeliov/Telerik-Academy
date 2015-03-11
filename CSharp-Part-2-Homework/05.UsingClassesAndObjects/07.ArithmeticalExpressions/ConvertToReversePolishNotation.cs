using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertToReversePolishNotation
{
    public static List<char> operators = new List<char>() { '+', '-', '*', '/', '%' };

    public static List<char> brackets = new List<char>() { '(', ')' };

    public static List<string> functions = new List<string>() { "ln", "pow", "sqrt" };

    public static Queue<string> ConvertToReverse(List<string> tokens)
    {
        Stack<string> stack = new Stack<string>();
        Queue<string> queque = new Queue<string>();

        for (int i = 0; i < tokens.Count; i++)
        {
            var currentToken = tokens[i];
            double number;
            if (double.TryParse(currentToken, out number))
            {
                queque.Enqueue(currentToken);
            }
            else if (functions.Contains(currentToken))
            {
                stack.Push(currentToken);
            }
            else if (currentToken == ",")
            {
                if (!stack.Contains("(") || stack.Count == 0)
                {
                    throw new ArgumentException("Invalid brackets or function separator!");
                }
                while (stack.Peek() != "(")
                {
                    queque.Enqueue(stack.Pop());
                }
            }
            else if (operators.Contains(currentToken[0]))
            {
                while (stack.Count != 0 && operators.Contains(stack.Peek()[0]) && Precedence.Prec(currentToken) <= Precedence.Prec(stack.Peek()))
                {
                    queque.Enqueue(stack.Pop());
                }
                stack.Push(currentToken);
            }
            else if (currentToken == "(")
            {
                stack.Push("(");
            }
            else if (currentToken == ")")
            {
                if (!stack.Contains("("))
                {
                    throw new ArgumentException("Invalid brackets");
                }
                while (stack.Peek() != "(")
                {
                    queque.Enqueue(stack.Pop());
                }
                stack.Pop();
                if (stack.Count != 0 && functions.Contains(stack.Peek()))
                {
                    queque.Enqueue(stack.Pop());
                }
            }
        }
        while (stack.Count != 0)
        {
            if (brackets.Contains(stack.Peek()[0]))
            {
                throw new ArgumentException("Invalid brackets position! ");
            }
            queque.Enqueue(stack.Pop());
        }

        return queque;
    }
}