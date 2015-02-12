using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Xexpression
{
    class Xexpression
    {
        static void Main(string[] args)
        {
            int symbol = Console.Read();
            decimal sum = 0;
            int sign = '+';

            while (symbol != '=')
            {
                if (symbol == '(')
                {
                    decimal innerSum = 0;
                    int innerSign = '+';
                    symbol = Console.Read();

                    while (symbol != ')')
                    {
                        if (0 <= symbol - '0' && symbol - '0' <= 9)
                        {
                            switch (innerSign)
                            {
                                case '+':
                                    innerSum += symbol - '0';
                                    break;
                                case '-':
                                    innerSum -= symbol - '0';
                                    break;
                                case '*':
                                    innerSum *= symbol - '0';
                                    break;
                                case '/':
                                    innerSum /= symbol - '0';
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
                        {
                            innerSign = symbol;
                        }
                        symbol = Console.Read();
                    }
                    switch (sign)
                    {
                        case '+':
                            sum += innerSum;
                            break;
                        case '-':
                            sum -= innerSum;
                            break;
                        case '*':
                            sum *= innerSum;
                            break;
                        case '/':
                            sum /= innerSum;
                            break;
                        default:
                            break;
                    }
                }
                else if (0 <= symbol - '0' && symbol - '0' <= 9)
                {
                    switch (sign)
                    {
                        case '+':
                            sum += symbol - '0';
                            break;
                        case '-':
                            sum -= symbol - '0';
                            break;
                        case '*':
                            sum *= symbol - '0';
                            break;
                        case '/':
                            sum /= symbol - '0';
                            break;
                        default:
                            break;
                    }
                }
                else if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
                {
                    sign = symbol;
                }
                symbol = Console.Read();
            }
            Console.WriteLine("{0:F2}", sum);
        }
    }
}
