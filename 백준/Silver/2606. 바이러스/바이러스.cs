using System;
using System.Collections.Generic;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[] input;
            int count = 0;
            Queue<int> queue = new Queue<int>();
            bool[] checkNode = new bool[n + 1];
            List<int>[] graph = new List<int>[n + 1];
            for (int i = 1; i <= n; i++)
                graph[i] = new List<int>();

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split(' ');
                int u = int.Parse(input[0]);
                int v = int.Parse(input[1]);
                graph[u].Add(v);
                graph[v].Add(u);
            }
            queue.Enqueue(1);
            while(queue.Count > 0)
            {
                int presendNode = queue.Dequeue();
                if (!checkNode[presendNode])
                {
                    foreach (int item in graph[presendNode])
                    {
                        queue.Enqueue(item);
                    }
                    count++;
                    checkNode[presendNode] = true;
                }
            }
            Console.WriteLine(count - 1);
        }
    }
}