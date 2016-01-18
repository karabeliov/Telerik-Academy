using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FinalResultFromRPN
{
    public static List<char> operators = new List<char>() { '+', '-', '*', '/', '%' };

    public static List<char> brackets = new List<char>() { '(', ')' };

    public static List<string> functions = new List<string>() { "ln", "pow", "sqrt" };

    public static double FinalResult(Queue<string> queqe)
    {
        Stack<double> stack = new Stack<double>();

        while (queqe.Count != 0)
        {
            string currentToken = queqe.Dequeue();
            double number;
            if (double.TryParse(currentToken, out number))
            {
                stack.Push(number);
            }
            else if (operators.Contains(currentToken[0]) || functions.Contains(currentToken))
            {
                if (currentToken == "+")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression");
                    }
                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(firstValue + secondValue);
                }
                else if (currentToken == "-")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression");
                    }
                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(secondValue - firstValue);
                }
                else if (currentToken == "*")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression");
                    }
                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(firstValue * secondValue);
                }
                else if (currentToken == "/")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression");
                    }
                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(secondValue / firstValue);
                }
                else if (currentToken == "%")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression");
                    }
                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(secondValue % firstValue);
                }
                else if (currentToken == "pow")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression");
                    }
                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(Math.Pow(secondValue, firstValue));
                }
                if (currentToken == "sqrt")
                {
                    if (stack.Count < 1)
                    {
                        throw new ArgumentException("Invalid expression");
                    }
                    double value = stack.Pop();
                    stack.Push(Math.Sqrt(value));
                }
                else if (currentToken == "ln")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression");
                    }
                    double value = stack.Pop();


                    stack.Push(Math.Log(value));
                }
            }
        }
        if (stack.Count == 1)
        {
            return stack.Pop();
        }
        else
        {
            throw new ArgumentException("Invalin expression");
        }
    }
}