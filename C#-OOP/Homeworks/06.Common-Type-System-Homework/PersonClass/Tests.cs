using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Tests
    {
        static void Main()
        {
            Person dudeWithAge = new Person("Strahil", 25);
            Person agelessDude = new Person("Grandpa");

            Console.WriteLine(dudeWithAge);
            Console.WriteLine(agelessDude);
        }
    }
}
