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
            int h = int.Parse(input[2]);
            int[,,] arr = new int[h, n, m];
            
            Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
            for(int k = 0; k < h; k++)
            {
                for(int i = 0; i < n; i++)
                {
                    input = Console.ReadLine().Split(' ');
                    for(int j = 0; j < m; j++)
                    {
                        arr[k, i, j] = int.Parse(input[j]);
                        if (arr[k, i, j] == 1)
                            queue.Enqueue((k, i, j));
                    }
                }
            }

            while(queue.Count > 0)
            {
                int z, x, y;
                (z, x, y) = queue.Dequeue();
                if(x > 0 && arr[z, x - 1, y] == 0)
                {
                    arr[z, x - 1, y] = arr[z, x, y] + 1;
                    queue.Enqueue((z, x - 1, y));
                }
                if (x + 1 < n && arr[z, x + 1, y] == 0)
                {
                    arr[z, x + 1, y] = arr[z, x, y] + 1;
                    queue.Enqueue((z, x + 1, y));
                }
                if (y > 0 && arr[z, x, y - 1] == 0)
                {
                    arr[z, x, y - 1] = arr[z, x, y] + 1;
                    queue.Enqueue((z, x, y - 1));
                }
                if (y + 1 < m && arr[z, x, y + 1] == 0)
                {
                    arr[z, x, y + 1] = arr[z, x, y] + 1;
                    queue.Enqueue((z, x, y + 1));
                }
                if(z > 0 && arr[z - 1, x, y] == 0)
                {
                    arr[z - 1, x, y] = arr[z, x, y] + 1;
                    queue.Enqueue((z - 1, x, y));
                }
                if (z + 1 < h && arr[z + 1, x, y] == 0)
                {
                    arr[z + 1, x, y] = arr[z, x, y] + 1;
                    queue.Enqueue((z + 1, x, y));
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