using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavartisuberi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rowleft = nums.Length / 4;
            int rowright = nums.Length / 4;
            int rowmiddle = nums.Length / 2;

            int[] numsleft = new int[rowleft];
            int[] numsright = new int[rowright];
            int[] numsmiddle = new int[rowmiddle];

            for (int i = 0; i < numsleft.Length; i++)
            {
                numsleft[i] = nums[i];
            }

            for (int i = 0; i < numsmiddle.Length; i++)
            {
                numsmiddle[i] = nums[i + rowleft];
            }

            for (int i = 0; i < numsright.Length; i++)
            {
                numsright[i] = nums[i + rowleft + rowmiddle];
            }

            Array.Reverse(numsleft);
            Array.Reverse(numsright);

            int[] finalNums = new int[rowmiddle];
            for (int i = 0; i < rowmiddle; i++)
            {
                if (i<rowleft)
                {
                    finalNums[i] = numsleft[i] + numsmiddle[i];
                }

                if (i>=rowleft&&i<rowmiddle)
                {
                    finalNums[i] = numsmiddle[i] + numsright[i - (rowright / 2 + 1)];
                }
            }

            Console.WriteLine(String.Join(" ",finalNums));


            //Console.WriteLine(String.Join(" ",numsleft));
            //Console.WriteLine(String.Join(" ", numsmiddle));
            //Console.WriteLine(String.Join(" ", numsright));
        }
    }
}
