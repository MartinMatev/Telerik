using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaBabaMiSmetalnika
{
    class NaBabaMiSmetalnika
    {
        static void Main(string[] args)
        {

            // Input
            int width = int.Parse(Console.ReadLine());

            long row0 = long.Parse(Console.ReadLine());
            long row1 = long.Parse(Console.ReadLine());
            long row2 = long.Parse(Console.ReadLine());
            long row3 = long.Parse(Console.ReadLine());
            long row4 = long.Parse(Console.ReadLine());
            long row5 = long.Parse(Console.ReadLine());
            long row6 = long.Parse(Console.ReadLine());
            long row7 = long.Parse(Console.ReadLine());

            // Logic
            int row = 0;
            int col = 0;
            int mask = 0;
            long bits = 0;
            long newBits = 0;
            int bitsCount = 0;
            bool proceed = true;
            while (proceed)
            {
                // Read commands
                string command = Console.ReadLine();

                switch (command)
                {
                    case "right":
                        row = int.Parse(Console.ReadLine());
                        col = int.Parse(Console.ReadLine());
                        if (col < 0)
                        {
                            col *= 0;
                        }
                        if (col > width)
                        {
                            col = width - 1;
                        }

                        // mask and bit extraction
                        mask = 0;
                        for (int i = 0; i < width - col; i++)
                        {
                            mask |= 1 << i;
                        }

                        // empty row part
                        switch (row)
	                    {
                            case 0:
                                bits = row0 & mask; 
                                row0 &= ~mask;
                                break;
                            case 1:
                                bits = row1 & mask;
                                row1 &= ~mask;
                                break;
                            case 2:
                                bits = row2 & mask;
                                row2 &= ~mask;
                                break;
                            case 3:
                                bits = row3 & mask;
                                row3 &= ~mask;
                                break;
                            case 4:
                                bits = row4 & mask;
                                row4 &= ~mask;
                                break;
                            case 5:
                                bits = row5 & mask;
                                row5 &= ~mask;
                                break;
                            case 6:
                                bits = row6 & mask;
                                row6 &= ~mask;
                                break;
                            case 7:
                                bits = row7 & mask;
                                row7 &= ~mask;
                                break;
                            default:
                                break;
	                    }

                        // count bits in extracted
                        bitsCount = 0;
                        while (bits > 0)
                        {
                            if ((bits & 1) == 0)
                            {
                                bitsCount++;
                            }
                            bits >>= 1;
                        }

                        // new bits
                        newBits = 0;
                        for (int i = 0; i < bitsCount; i++)
                        {
                            newBits |= (1 << i);
                        }

                        // apply new bits to row
                        switch (row)
                        {
                            case 0:
                                row0 |= newBits;
                                break;
                            case 1: 
                                row1 |= newBits;
                                break;
                            case 2:
                                row2 |= newBits;
                                break;
                            case 3:
                                row3 |= newBits;
                                break;
                            case 4:
                                row4 |= newBits;
                                break;
                            case 5:
                                row5 |= newBits;
                                break;
                            case 6:
                                row6 |= newBits;
                                break;
                            case 7:
                                row7 |= newBits;
                                break;
                            default:
                                break;
                        }

                        break;
                    case "left":
                        row = int.Parse(Console.ReadLine());
                        col = int.Parse(Console.ReadLine());
                        if (col < 0)
                        {
                            col *= 0;
                        }
                        if (col > width)
                        {
                            col = width -1;
                        }

                        // mask and bit extraction
                        mask = 0;
                        for (int i = width - col - 1; i < width; i++)
                        {
                            mask |= 1 << i;
                        }

                        // empty row part
                        switch (row)
                        {
                            case 0:
                                bits = row0 & mask;
                                row0 &= ~mask;
                                break;
                            case 1:
                                bits = row1 & mask;
                                row1 &= ~mask;
                                break;
                            case 2:
                                bits = row2 & mask;
                                row2 &= ~mask;
                                break;
                            case 3:
                                bits = row3 & mask;
                                row3 &= ~mask;
                                break;
                            case 4:
                                bits = row4 & mask;
                                row4 &= ~mask;
                                break;
                            case 5:
                                bits = row5 & mask;
                                row5 &= ~mask;
                                break;
                            case 6:
                                bits = row6 & mask;
                                row6 &= ~mask;
                                break;
                            case 7:
                                bits = row7 & mask;
                                row7 &= ~mask;
                                break;
                            default:
                                break;
                        }

                        // count bits in extracted
                        bitsCount = 0;
                        while (bits > 0)
                        {
                            if ((bits & 1) == 0)
                            {
                                bitsCount++;
                            }
                            bits >>= 1;
                        }

                        // new bits
                        newBits = 0;
                        for (int i = width - 1; i >= width - bitsCount; i--)
                        {
                            newBits |= (1 << i);
                        }

                        // apply new bits to row
                        switch (row)
                        {
                            case 0:
                                row0 |= newBits;
                                break;
                            case 1:
                                row1 |= newBits;
                                break;
                            case 2:
                                row2 |= newBits;
                                break;
                            case 3:
                                row3 |= newBits;
                                break;
                            case 4:
                                row4 |= newBits;
                                break;
                            case 5:
                                row5 |= newBits;
                                break;
                            case 6:
                                row6 |= newBits;
                                break;
                            case 7:
                                row7 |= newBits;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "reset":
                        // mask and bit extraction
                        mask = 0;
                        for (int i = 0; i < width - col; i++)
                        {
                            mask |= 1 << i;
                        }
                        // count bits in extracted
                        bitsCount = 0;
                        while (bits > 0)
                        {
                            if ((bits & 1) == 0)
                            {
                                bitsCount++;
                            }
                            bits >>= 1;
                        }

                        // new bits
                        newBits = 0;
                        for (int i = width - 1; i >= width - bitsCount; i--)
                        {
                            newBits |= (1 << i);
                        }
                        break;
                    case "stop":
                        proceed = false;
                        break;
                    default:
                        break;
                }
            }

            // Calculations
            long sum = row0 + row1 + row2 + row3 + row4 + row5 + row6 + row7;
            int zeroColCOunt = 0;
            long colSum = row0 | row1 | row2 | row3 | row4 | row5 | row6 | row7;
            for (int i = 0; i < width; i++)
            {
                if ((colSum & (1 << i)) == 0)
                {
                    zeroColCOunt++;
                }
            }

            //Output
            Console.WriteLine(sum * zeroColCOunt);
        }
    }
}
