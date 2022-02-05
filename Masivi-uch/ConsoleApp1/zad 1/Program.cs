using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine($"Min={num.Min()}");
            Console.WriteLine($"Max={num.Max()}");
            Console.WriteLine($"Sum={num.Sum()}");
            Console.WriteLine($"Average={num.Average()}");


        }
    }
}
