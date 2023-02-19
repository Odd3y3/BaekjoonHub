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
            int m = int.Parse(input[1]);
            int u, v;
            int count = 0;
            int index = 1;
            Queue<int> q = new Queue<int>();
            List<int>[] graph = new List<int>[n + 1];
            for (int i = 1; i <= n; i++)
                graph[i] = new List<int>();
            bool[] checkedNode = new bool[n + 1];
            for(int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split(' ');
                u = int.Parse(input[0]);
                v = int.Parse(input[1]);
                graph[u].Add(v);
                graph[v].Add(u);
            }

            while(index <= n)
            {
                if (!checkedNode[index])
                {
                    q.Enqueue(index);
                    while(q.Count > 0)
                    {
                        int presentNode = q.Dequeue();
                        if (!checkedNode[presentNode])
                        {
                            foreach (int item in graph[presentNode])
                            {
                                q.Enqueue(item);
                            }
                            checkedNode[presentNode] = true;
                        }
                    }
                    count++;
                }
                index++;
            }
            Console.WriteLine(count);
        }
    }
}