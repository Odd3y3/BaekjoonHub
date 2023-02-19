using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int x, y;
            int[] arr = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();
            int[] sum = new int[n + 1];
            sum[0] = 0;
            for(int i = 1; i <= n; i++)
                sum[i] = sum[i - 1] + arr[i - 1];
            for(int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split(' ');
                x = int.Parse(input[0]);
                y = int.Parse(input[1]);
                sb.AppendLine((sum[y] - sum[x - 1]).ToString());
            }
            Console.WriteLine(sb);
        }
    }
}