using System;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] stairs = new int[n + 1];
            for(int i = 1; i <= n; i++)
            {
                stairs[i] = int.Parse(Console.ReadLine());
            }
            int[] oxArr = new int[n + 1];
            int[] xoArr = new int[n + 1];
            oxArr[1] = stairs[1];
            xoArr[1] = stairs[1];
            for(int i = 2; i <= n; i++)
            {
                oxArr[i] = Math.Max(oxArr[i - 2], xoArr[i - 2]) + stairs[i];
                xoArr[i] = oxArr[i - 1] + stairs[i];
            }
            Console.WriteLine(Math.Max(oxArr[n], xoArr[n]));
        }
    }
}