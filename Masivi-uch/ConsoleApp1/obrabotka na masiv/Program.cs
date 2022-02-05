using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrabotka_na_masiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mas = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(Console.ReadLine());

            while (n>0)
            {
                var cmd = Console.ReadLine().Split().ToArray();
                switch (cmd[0])
                {
                    case "Reverse": mas = mas.Reverse().ToArray();break;
                    case "Disting": mas = mas.Distinct().ToArray();break;
                    case "Replace": mas[int.Parse(cmd[1])] = cmd[2];break;
                        
                }
                n--;
            }
            Console.WriteLine(String.Join(" ",mas));
        }
    }
}
