using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigmanation
{
    class Enigmanation
    {
        static void Main(string[] args)
        {
            int symbol = Console.Read();
            int sign = '+';
            int sum = 0;

            while (symbol != '=')
            {
                if (symbol == '(')
                {
                    symbol = Console.Read();
                    int innerSign = '+';
                    int innerSum = 0;

                    while (symbol != ')')
                    {
                        if (symbol - '0' >= 0 && symbol - '0' <= 9)
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
                                    innerSum *= symbol -'0';
                                    break;
                                case '%':
                                    innerSum %= symbol - '0';
                                    break;
                                default: 
                                    break;
                            }
                        }                        
                        else if (symbol == '+' || symbol == '-' ||
                            symbol == '*' || symbol == '%')
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
                        case '%':
                            sum %= innerSum;
                            break;
                        default:
                            break;
                    }
                }
                else if (symbol - '0' >= 0 && symbol - '0' <= 9)
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
                        case '%':
                            sum %= symbol - '0';
                            break;
                        default:
                            break;
                    }
                }
                else if (symbol == '+' || symbol == '-' ||
                    symbol == '*' || symbol == '%')
                {
                    sign = symbol;
                }
                symbol = Console.Read();
            }
            Console.WriteLine("{0:F3}", sum);
        }
    }
}
