using System;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int count = 0;
            int[] coins = new int[n];
            for (int i = 0; i < n; i++)
            {
                coins[i] = int.Parse(Console.ReadLine());
            }
            for(int i = n - 1; i >= 0; i--)
            {
                count += k / coins[i];
                k %= coins[i];
            }
            Console.WriteLine(count);
        }
    }
}