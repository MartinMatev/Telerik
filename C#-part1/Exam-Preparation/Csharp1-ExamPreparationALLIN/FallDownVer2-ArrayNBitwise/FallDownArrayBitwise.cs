using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallDownVer2_ArrayNBitwise
{
    class FallDownArrayBitwise
    {
        static void Main(string[] args)
        {

            // Version 2: Array AND Bitwise solution !!!

            // Input
            int[] nums = new int[8];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            // Solution
            // Grand PAPA cycle - прокарва битовете от горе до долу 
            for (int i = 0; i < 8; i++)
            {
                for (int line = nums.Length - 1; line > 0; line--)
                {
                    // Всеки for цикъл, прокарва битовете от един(гирния) ред на друг(долния)
                    for (int bitPosition = 0; bitPosition < 8; bitPosition++)
                    {
                        // Проверка дали долния бит е 0 и горния 1, за да им сменим позициите !
                        if ((nums[line] >> bitPosition & 1) == 0 &&
                            (nums[line - 1] >> bitPosition & 1) == 1)
                        {
                            nums[line] = nums[line] | (1 << bitPosition); // Сменяме долния бит на съответната позиция от 0 на 1 на долния ред!
                            nums[line - 1] = nums[line - 1] & ~(1 << bitPosition); // Сменяме горния бит на съответната позиция от 1 на 0 на горния ред!
                        }
                    }
                }

            }

            // Output
            foreach (int number in nums)
            {
                Console.WriteLine(number);
            }
        }
    }
}
