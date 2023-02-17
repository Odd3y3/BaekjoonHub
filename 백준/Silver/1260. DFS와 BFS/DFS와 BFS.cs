using System;
using System.Collections.Generic;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int v = int.Parse(input[2]);
            List<int>[] graph = new List<int>[n + 1];
            for (int i = 0; i < n + 1; i++)
                graph[i] = new List<int>();
            for(int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split();
                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);
                graph[x].Add(y);
                graph[y].Add(x);
            }

            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            List<int> dfs = new List<int>();
            List<int> bfs = new List<int>();

            bool[] checkDfs = new bool[n + 1];
            bool[] checkBfs = new bool[n + 1];
            //DFS
            stack.Push(v);
            while(stack.Count > 0)
            {
                int x = stack.Pop();
                if (!checkDfs[x])
                {
                    dfs.Add(x);
                    checkDfs[x] = true;
                    graph[x].Sort();
                    graph[x].Reverse();
                    foreach (int item in graph[x])
                    {
                        stack.Push(item);
                    }
                }
            }
            //BFS
            queue.Enqueue(v);
            while(queue.Count > 0)
            {
                int x = queue.Dequeue();
                if (!checkBfs[x])
                {
                    bfs.Add(x);
                    checkBfs[x] = true;
                    graph[x].Sort();
                    foreach (int item in graph[x])
                    {
                        queue.Enqueue(item);
                    }
                }
            }
            //결과 출력
            foreach (var item in dfs)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in bfs)
            {
                Console.Write(item + " ");
            }
        }
    }
}