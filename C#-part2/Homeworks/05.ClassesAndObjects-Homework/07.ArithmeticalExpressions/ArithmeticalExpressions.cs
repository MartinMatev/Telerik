﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

/*
 * Write a program that calculates the value of given arithmetical expression.
 * The expression can contain the following elements only:
 * Real numbers, e.g. 5, 18.33, 3.14159, 12.6
 * Arithmetic operators: +, -, *, / (standard priorities)
 * Mathematical functions: ln(x), sqrt(x), pow(x,y)
 * Brackets (for changing the default priorities): (, )

 * Examples:

 * input	                                                output
 * (3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)	                ~10.6
 * pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)	    ~21.22
 */
class ArithmeticalExpressions
{
    public static List<char> arithmeticOperations = new List<char>() { '+', '-', '*', '/' };
    public static List<char> brackets = new List<char>() { '(', ')' };
    public static List<string> functions = new List<string>() { "pow", "sqrt", "ln" };

    static void Main()
    {
        InvariantCulture();

        try
        {
            string input = GetExpression().Trim();
            var separatedTokens = SeparateTokens(input);
            var reversePolishNotation = ConvertToReversePolishNotation(separatedTokens);
            var finalResult = GetResultFromRPN(reversePolishNotation);
            PrintResult(finalResult);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void PrintResult(double finalResult)
    {
        Console.WriteLine("The answer is: {0:F2}", finalResult);
    }

    public static double GetResultFromRPN(Queue<string> queue)
    {
        var stack = new Stack<double>();

        while (queue.Count != 0)
        {
            // Take a token out of the queue
            string currentToken = queue.Dequeue();
            double number;

            if (double.TryParse(currentToken, out number))
            {
                stack.Push(number);
            }
            else if (arithmeticOperations.Contains(currentToken[0]) || functions.Contains(currentToken))
            {
                // A check for all the possible operators, 1 by 1 is needed, because we do calculations differently with every single one :/
                // Stack.Count checks, because operetors need a certain amount of numbers to be valid
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

                    stack.Push(secondValue * firstValue);
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
                else if (currentToken == "sqrt")
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
                    if (stack.Count < 1)
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
            throw new ArgumentException("Invalid expression");
        }
    }
    
    public static int Precedence(string arithmeticOperator)
    {
        if (arithmeticOperator == "+" || arithmeticOperator == "-")
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }

    public static Queue<string> ConvertToReversePolishNotation(List<string> tokens)
    {
        // Take the LIST of tokens and separate them, adding numbers to the QUEUE and operators/signs to the STACK
        var stack = new Stack<string>();
        var queue = new Queue<string>();

        for (int i = 0; i < tokens.Count; i++)
        {
            var currentToken = tokens[i];
            double number;

            if (double.TryParse(currentToken,out number))
            {
                queue.Enqueue(currentToken);
            }
            else if (functions.Contains(currentToken))
            {
                stack.Push(currentToken);
            }
            else if (currentToken == ",")
            {
                if (!stack.Contains("(") || stack.Count == 0)
                {
                    throw new ArgumentException("Invalid brackets or function separator");
                }

                while (stack.Peek() != "(")
                {
                    // Take it from the stack (the last element) and add it to the queue
                    queue.Enqueue(stack.Pop());
                }
            }
            else if (arithmeticOperations.Contains(currentToken[0]))
            {
                while (stack.Count != 0 && arithmeticOperations.Contains(stack.Peek()[0]) && Precedence(currentToken) <= Precedence(stack.Peek()))
                {
                    queue.Enqueue(stack.Pop());
                }

                stack.Push(currentToken);
            }
            else if (currentToken == "(")
            {
                stack.Push("(");
            }
            else if (currentToken == ")")
            {
                if (!stack.Contains("(") || stack.Count == 0)
                {
                    throw new ArgumentException("Invalid brackets");
                }

                while (stack.Peek() != "(")
                {
                    queue.Enqueue(stack.Pop());
                }

                stack.Pop();

                // If there is a function ontop of the STACK
                if (stack.Count != 0 && functions.Contains(stack.Peek()))
                {
                    queue.Enqueue(stack.Pop());
                }
            }
        }

        while (stack.Count != 0)
        {
            if (brackets.Contains(stack.Peek()[0]))
            {
                throw new ArgumentException("Invalid brackets position");
            }
            queue.Enqueue(stack.Pop());
        }

        return queue;
    }

    static List<string> SeparateTokens(string input)
    {
        var result = new List<string>();
        var number = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '-' && (i == 0 || input[i - 1] == ',' || input[i - 1] == '('))
            {
                number.Append('-');
            }
            else if(char.IsDigit(input[i]) || input[i] == '.')
            {
                number.Append(input[i]);
            }
            else if (!char.IsDigit(input[i]) && input[i] != '.' && number.Length != 0)
            {
                result.Add(number.ToString());
                number.Clear();
                i--;
            }
            else if (brackets.Contains(input[i])) // IF checks to find all the symbols, operators and math expressions, and add them to a LIST of strings
            {
                result.Add(input[i].ToString());
            }
            else if (arithmeticOperations.Contains(input[i]))
            {
                result.Add(input[i].ToString());
            }
            else if (input[i] == ',')
            {
                result.Add(",");
            }
            else if (i + 1 < input.Length && input.Substring(i, 2).ToLower() == "ln")
            {
                result.Add("ln");
                // up the counter by 1, because we are taking 2 symbols, instread of 1
                i++;
            }
            else if (i + 2 < input.Length && input.Substring(i, 3).ToLower() == "pow")
            {
                result.Add("pow");
                i += 2;
            }
            else if (i + 3 < input.Length && input.Substring(i, 4).ToLower() == "sqrt")
            {
                result.Add("sqrt");
                i += 3;
            }
            else
            {
                throw new ArgumentException("Invalid expression");
            }
        }

        if (number.Length != 0)
        {
            result.Add(number.ToString());
        }

        return result;
    }
    private static string GetExpression()
    {
        Console.WriteLine("Enter expression below:");
        Console.Write(">> ");
        return Console.ReadLine().Replace(" ", "");
    }

    public static void InvariantCulture()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
    }
}
