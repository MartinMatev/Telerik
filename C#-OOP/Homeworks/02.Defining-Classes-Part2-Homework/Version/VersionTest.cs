namespace Version
{
    using System;

    [VersionAttribute("2.11")]
    public class VersionTest
    {
        static void Main()
        {

            var versionAttr = typeof(VersionTest).GetCustomAttributes(typeof(VersionAttribute), false); // returns array of objects

            foreach (var attr in versionAttr)
            {
                Console.WriteLine("ver. {0}", attr);
            }
        }
    }
}
