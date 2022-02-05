using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]}-> {word[i]-97}"  );
            }
        }
    }
}
