using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Day: ");
            int day = int.Parse(Console.ReadLine());

            string[] days = { "pon", "vt", "strqda", "chet", "pet", "sub", "ne" };
            for (int i = 0; i < days.Length; i++)
            {
                if (day==(i+1))
                {
                    Console.WriteLine(days[i]);
                }
                else
                {
                    Console.WriteLine("Invalid day");
                }
                
            }


        }
    }
}
