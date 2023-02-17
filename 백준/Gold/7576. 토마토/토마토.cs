using System;
using System.Collections.Generic;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int[,] arr = new int[n, m];
            
            Queue<(int, int)> queue = new Queue<(int, int)>();

            for(int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                for(int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(input[j]);
                    if (arr[i, j] == 1)
                        queue.Enqueue((i, j));
                }
            }

            while(queue.Count > 0)
            {
                int x, y;
                (x, y) = queue.Dequeue();
                if(x > 0 && arr[x - 1, y] == 0)
                {
                    arr[x - 1, y] = arr[x, y] + 1;
                    queue.Enqueue((x - 1, y));
                }
                if (x + 1 < n && arr[x + 1, y] == 0)
                {
                    arr[x + 1, y] = arr[x, y] + 1;
                    queue.Enqueue((x + 1, y));
                }
                if (y > 0 && arr[x, y - 1] == 0)
                {
                    arr[x, y - 1] = arr[x, y] + 1;
                    queue.Enqueue((x, y - 1));
                }
                if (y + 1 < m && arr[x, y + 1] == 0)
                {
                    arr[x, y + 1] = arr[x, y] + 1;
                    queue.Enqueue((x, y + 1));
                }
            }
            bool isFail = false;
            int max = 0;

            foreach (int item in arr)
            {
                if(item == 0)
                {
                    isFail = true;
                    break;
                }
                max = Math.Max(max, item);
            }
            if (isFail)
                Console.WriteLine(-1);
            else
                Console.WriteLine(max - 1);
        }
    }
}