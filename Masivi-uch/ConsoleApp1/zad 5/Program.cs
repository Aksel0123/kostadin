using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] b = new int[a.Length + 1];
            int placed = 0;

            a = a.OrderBy(x => x).ToArray();
            for (int i = 0; i < b.Length; i++)
            {
                if (n>=a[i-placed]|| placed==1)
                {
                    b[i]=a[i-placed]
                }
                else
                {
                    b[i] = n;
                    placed = 1;
                }
            }

            Console.WriteLine(String.Join(" ",b));
        }
    }
}
