using System;
using System.Linq;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            bool ascending = true;
            bool descending = true;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] != i + 1)
                    ascending = false;
                if (input[i] != 8 - i) 
                    descending = false;
            }
            if (ascending) Console.WriteLine("ascending");
            else if (descending) Console.WriteLine("descending");
            else Console.WriteLine("mixed");
        }
    }
}