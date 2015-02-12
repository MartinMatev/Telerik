using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpets
{
    class Carpets
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int lines = int.Parse(input);
            int elementsOnLines = lines;
            int center = elementsOnLines / 2;

            for (int i = 1; i <=lines / 2; i++)
            {
                int elementPos = 1;
                while (elementPos <= elementsOnLines)
                {
                    if ((elementPos <= center - i) || (elementPos > center + i))
                    {
                        Console.Write(".");
                        elementPos++;
                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write("/");
                                elementPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elementPos++;
                            }
                        }

                        for (int j = i; j > 0; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write("\\");
                                elementPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elementPos++;
                            }
                        }
                    }
                }
                Console.WriteLine();
            }

            for (int i = lines / 2; i > 0; i--)
            {
                int elementPos = 1;
                while (elementPos <= elementsOnLines)
                {
                    if ((elementPos <= center - i) || (elementPos > center + i))
                    {
                        Console.Write(".");
                        elementPos++;
                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write("\\");
                                elementPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elementPos++;
                            }
                        }

                        for (int j = i; j > 0; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write("/");
                                elementPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elementPos++;
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
