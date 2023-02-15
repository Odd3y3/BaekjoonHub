using System;
using System.Collections.Generic;
using System.Linq;

namespace MyTestingField
{
    class PriorityQueue
    {
        private (int, int)[] pq;
        private int index;
        public int Length {  get { return index - 1; } }
        public PriorityQueue()
        {
            pq = new (int, int)[300001];
            this.index = 1;
        }
        
        public void Push((int, int) edge)
        {
            pq[this.index] = edge;
            int tempIndex = index;
            while (tempIndex > 1)
            {
                if (pq[tempIndex / 2].Item2 > pq[tempIndex].Item2)
                {
                    var temp = pq[tempIndex / 2];
                    pq[tempIndex / 2] = pq[tempIndex];
                    pq[tempIndex] = temp;
                    tempIndex /= 2;
                }
                else
                    break;
            }
            index++;
        }
        public (int b, int w) Pop()
        {
            (int, int) returnValue = pq[1];
            pq[1] = pq[this.index - 1];
            this.index--;
            int tempIndex = 1;
            while (tempIndex * 2 < this.index)
            {
                int minIndex = 0;
                if (tempIndex * 2 == this.index - 1)
                    minIndex = tempIndex * 2;
                else
                    minIndex = pq[tempIndex * 2].Item2 <= pq[tempIndex * 2 + 1].Item2 ? tempIndex * 2 : tempIndex * 2 + 1;
                
                if (pq[minIndex].Item2 < pq[tempIndex].Item2)
                {
                    var temp = pq[tempIndex];
                    pq[tempIndex] = pq[minIndex];
                    pq[minIndex] = temp;
                    tempIndex = minIndex;
                }
                else
                    break;
            }
            return returnValue;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // 입력
            int v = int.Parse(input[0]);
            int e = int.Parse(input[1]);
            int k = int.Parse(Console.ReadLine());

            List<(int, int)>[] graph = new List<(int, int)>[v + 1]; // 그래프 생성
            for (int i = 0; i < graph.Length; i++)
                graph[i] = new List<(int, int)>();

            bool[] visit = new bool[v + 1]; // 방문 했는지 체크하는 배열
            int[] result = Enumerable.Repeat(int.MaxValue, v + 1).ToArray(); // Dajikstra 결과 배열

            PriorityQueue pq = new PriorityQueue();

            for (int i = 0; i < e; i++) // 그래프 입력 & 초기화
            {
                input = Console.ReadLine().Split(' ');
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int w = int.Parse(input[2]);
                graph[a].Add((b, w));
            }

            int dist = 0;
            int presentNode = k;
            pq.Push((k, dist));
            while (pq.Length > 0)
            {
                (int, int) pop = pq.Pop();
                int b = pop.Item1;
                int w = pop.Item2;
                if (!visit[b])
                {
                    visit[b] = true;
                    result[b] = w;
                    presentNode = b;
                    dist = w;
                    foreach (var item in graph[b])
                    {
                        pq.Push((item.Item1, item.Item2 + dist));
                    }
                }
            }

            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] == int.MaxValue)
                    Console.WriteLine("INF");
                else
                    Console.WriteLine(result[i]);
            }

        }
    }
}