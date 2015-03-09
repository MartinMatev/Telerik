namespace Delegates
{
    using System;

    // these delegates will contain one method
    public delegate void SomeDelegate(int number);
    public delegate void SomeStringDelegate(string text);
    public delegate int ConvertStrings(string text);

    // this delegate will have more methods
    public delegate int MulticastDelegate(int first, int second);

    class DelegatesDemos
    {
        public static void SomeMethod(int nmb)
        {
            Console.WriteLine(nmb);
        }

        public static int Sum(int first, int second)
        {
            int result = first + second;
            Console.WriteLine("Sum: {0}", result);
            return result;
        }

        public static int Product(int first, int second)
        {
            int result = first * second;
            Console.WriteLine("Product: {0}", result);
            return result;
        }

        public static int Remainder(int first, int second)
        {
            int result = first % second;
            Console.WriteLine("Remainder: {0}",result);
            return result;
        }

        static void Main()
        {
            SomeDelegate dlg = new SomeDelegate(SomeMethod);
            dlg(1337);

            SomeStringDelegate otherDlg = new SomeStringDelegate(Console.WriteLine);
            otherDlg("I am ninja");

            ConvertStrings convertDlg = new ConvertStrings(int.Parse);
            int someNumber = convertDlg("100");

            Console.WriteLine("Output: {0}", someNumber);
            Console.WriteLine("Type: {0}", someNumber.GetType());

            // Наслагване на функции на един делегат: 
            MulticastDelegate multiFunctions = Sum;
            multiFunctions += Product;
            multiFunctions += Remainder;

            Console.WriteLine("Multifunction delegate below: ");
            multiFunctions(10, 6);

            SomeStringDelegate delegadur = delegate(string text)
            {
                text += " ";
                Console.WriteLine(text);
            };

            delegadur("Supp bae ;)~");
        }
    }
}
