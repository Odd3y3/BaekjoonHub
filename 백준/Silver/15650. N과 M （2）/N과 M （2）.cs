using System;
using System.IO;

namespace MyTestingField
{
    class Program
    {
        static void Func(int start, int end, int recursive, string output)
        {
            if(recursive == 1)
            {
                for(int i = start; i <= end; i++)
                {
                    Console.WriteLine(output + i);
                }
            }
            else
            {
                for(int i = start; i <= end; i++)
                {
                    Func(i + 1, end, recursive - 1, output + i + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            Func(1, n, m, "");
        }
    }
}
