using System;
using System.Collections.Generic;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int a, b;
            int result = int.MaxValue;
            bool[] check = new bool[100001];
            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((n, 0));
            while(queue.Count > 0)
            {
                (a, b) = queue.Dequeue();
                check[a] = true;
                if(a == k)
                {
                    result = Math.Min(result, b);
                    break;
                }
                else if(a > k)
                {
                    result = Math.Min(result, a - k + b);
                    continue;
                }
                else
                {
                    if (a - 1 >= 0 && !check[a - 1])
                        queue.Enqueue((a - 1, b + 1));
                    if (a + 1 <= 100000 && !check[a + 1])
                        queue.Enqueue((a + 1, b + 1));
                    if (a * 2 <= 100000 && !check[a * 2])
                        queue.Enqueue((a * 2, b + 1));
                }
                
            }
            Console.WriteLine(result);
        }
    }
}
