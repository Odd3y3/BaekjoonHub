using System;
using System.Linq;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int result = input[0] * input[1];
            if (result % 2 == 0)
                Console.WriteLine(result);
            else
                Console.WriteLine(result - 1);
        }
    }
}
