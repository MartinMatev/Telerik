using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExtendingSubstring
{
    public static class ExtensionBuilder
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder result = new StringBuilder();

            ValidationCheck(sb, index, length);

            for (int i = index; i < index + length; i++)
            {
                result.Append(sb[i]);
            }

            return result;
        }

        private static void ValidationCheck(StringBuilder sb, int index, int length)
        {
            if (index < 0 || index > sb.Length)
            {
                throw new ArgumentOutOfRangeException("Starting index cannot be less than 0 OR bigger than the length of the input!");
            }

            if (index + length >= sb.Length)
            {
                throw new ArgumentOutOfRangeException("The Substring exceeds the input range!");
            }

            if (length < 0)
            {
                throw new ArgumentException("The length of the substring cannot be a negative number!");
            }
        }
    }
}
