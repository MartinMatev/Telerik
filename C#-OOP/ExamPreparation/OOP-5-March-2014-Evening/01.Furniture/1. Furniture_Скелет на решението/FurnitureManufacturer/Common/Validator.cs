namespace FurnitureManufacturer.Common
{
    using System;

    public static class Validator
    {
        public static void CheckIfNullOrEmpty(string text, string message = null)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void CheckIfValidValue(decimal value, string message = null)
        {
            if (value <= 0m)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }

        public static void CheckIfLessThanN(string text, int minLength, string message = null)
        {
            if (text.Length < minLength)
            {
                throw new ArgumentException(message);
            }
        }

        public static bool ContainsOnlyDigits(string text)
        {
            foreach (var ch in text)
            {
                if (!char.IsDigit(ch))
                {
                    return false;
                }              
            }
            return true;
        }
    }
}
