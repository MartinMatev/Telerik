namespace AlotOfFeatures
{
    using System;
    class ExtensionsDemo
    {
        static void Main()
        {
            string pesho = "Pesho";
            string agrPesho = pesho.AggregateWith(10);

            Console.WriteLine(agrPesho);

            agrPesho = pesho.AggregateWith(10, ',');

            Console.WriteLine(agrPesho);
        }
    }
}
