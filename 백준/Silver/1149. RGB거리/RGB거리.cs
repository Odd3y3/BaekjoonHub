using System;
using System.Linq;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input;
            int[] prev = new int[3];
            int[] curr = new int[3];
            for(int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                curr[0] = Math.Min(prev[1], prev[2]) + int.Parse(input[0]);
                curr[1] = Math.Min(prev[0], prev[2]) + int.Parse(input[1]);
                curr[2] = Math.Min(prev[0], prev[1]) + int.Parse(input[2]);
                Array.Copy(curr, prev, 3);
            }

            Console.WriteLine(prev.Min());
        }
    }
}
