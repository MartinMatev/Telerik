using System;
using System.Collections;
using System.Collections.Generic;

namespace BitArray
{
    public class BitArray64 : IEnumerable<int>
    {

        public BitArray64(ulong number)
        {
            this.Number = number;
        }
        
        public ulong Number { get; set; }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentOutOfRangeException("Index must be between 0 and 63 inclusive");
                }

                // Gets the bit and the wanted position
                int bit = (int)(this.Number >> index) & 1;
                return bit;
            }
            set
            {
                // Set the bit at the given "index" position to either 1 or 0. Check for wrong input data.
                if (index < 0 || index > 63)
                {
                    throw new ArgumentOutOfRangeException("Index must be between 0 and 63 inclusive");
                }

                if (value == 0)
                {
                    int mask = ~(1 << index);
                    ulong modifiedNum = this.Number & (ulong)mask;

                    this.Number = modifiedNum;
                }
                else if (value == 1)
                {
                    int mask = 1 << index;
                    // The casting to a lower type first: https://msdn.microsoft.com/en-us/library/wdc6717a(v=vs.71).aspx
                    ulong modifiedNum = this.Number | (ulong)(long)mask;

                    this.Number = modifiedNum;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Bit value can only be 1 or 0");
                }
            }
        }

        public override string ToString()
        {
            return this.Number.ToString();
        }

        // Overriding Equals (not much work needed since Equals on primitive types is used)
        public override bool Equals(object obj)
        {
            return this.Number.Equals((obj as BitArray64).Number);
        }

        // Overriding GetHashCode
        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        // Overriding the == and != operators
        public static bool operator ==(BitArray64 firstNum, BitArray64 secondNum)
        {
            return firstNum.Equals(secondNum);
        }

        public static bool operator !=(BitArray64 firstNum, BitArray64 secondNum)
        {
            return !(firstNum.Equals(secondNum));
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
