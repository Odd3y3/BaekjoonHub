using System;
using System.Collections.Generic;
using System.Linq;

namespace MyTestingField
{
    class Program
    {
        class MinHeap
        {
            private (int, int)[] arr;
            public int Count;
            public MinHeap()
            {
                arr = new (int, int)[100001];
                Count = 0;
            }
            public void Push(int end, int value)
            {
                Count++;
                arr[Count] = (end, value);
                int index = Count;
                while (index > 1 && arr[index / 2].Item2 > arr[index].Item2)
                {
                    (int, int) temp = arr[index / 2];
                    arr[index / 2] = arr[index];
                    arr[index] = temp;
                    index /= 2;
                }
            }
            public (int, int) Pop()
            {
                if (Count == 0)
                    return (-1, -1);
                (int, int) returnValue = arr[1];
                arr[1] = arr[Count];
                Count--;
                int index = 1;
                while (index * 2 <= Count)
                {
                    int minIndex = 0;
                    if (index * 2 == Count)
                        minIndex = index * 2;
                    else
                        minIndex = arr[index * 2].Item2 > arr[index * 2 + 1].Item2 ? index * 2 + 1 : index * 2;
                    if (arr[index].Item2 > arr[minIndex].Item2)
                    {
                        (int, int) temp = arr[index];
                        arr[index] = arr[minIndex];
                        arr[minIndex] = temp;
                        index = minIndex;
                    }
                    else break;
                }

                return returnValue;
            }
        }
        static int Dijkstra(int start, int end, int n, List<(int, int)>[] graph)
        {
            MinHeap minHeap = new MinHeap();
            bool[] check = new bool[n + 1];
            int[] maxResult = Enumerable.Repeat(int.MaxValue, n + 1).ToArray();
            minHeap.Push(start, 0);
            maxResult[start] = 0;
            while(minHeap.Count > 0)
            {
                int b, w;
                (b, w) = minHeap.Pop();
                if (!check[b])
                {
                    check[b] = true;
                    foreach (var item in graph[b])
                    {
                        maxResult[item.Item1] = Math.Min(w + item.Item2, maxResult[item.Item1]);
                        minHeap.Push(item.Item1, w + item.Item2);
                    }
                }
            }

            return maxResult[end];
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[] input;
            int a, b, w;
            List<(int, int)>[] graph = new List<(int, int)>[n + 1];
            for (int i = 0; i < n + 1; i++)
                graph[i] = new List<(int, int)>();
            for(int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split(' ');
                a = int.Parse(input[0]);
                b = int.Parse(input[1]);
                w = int.Parse(input[2]);
                graph[a].Add((b, w));
            }
            input = Console.ReadLine().Split(' ');
            int start = int.Parse(input[0]);
            int end = int.Parse(input[1]);
            
            Console.WriteLine(Dijkstra(start, end, n, graph));
        }
    }
}
