
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int x = int.Parse(input[2]);
            List<(int, int)>[] graph = new List<(int, int)>[n + 1];
            int[,] result = new int[n + 1, n + 1];
            for (int i = 0; i < n + 1; i++)
                graph[i] = new List<(int, int)>();

            for (int i = 0; i < m; i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[nums[0]].Add((nums[1], nums[2]));
            }

            for (int i = 1; i <= n; i++)
                Dijkstra(i, graph, result);

            //output
            int maxTime = 0;
            for(int i = 1; i <= n; i++)
            {
                maxTime = Math.Max(maxTime, result[i, x] + result[x, i]);
            }
            Console.WriteLine(maxTime);
        }
        static void Dijkstra(int start, List<(int, int)>[] graph, int[,] result)
        {
            int n = result.GetLength(0);
            bool[] visit = new bool[n + 1];
            for (int i = 1; i < n; i++)
            {
                result[start, i] = int.MaxValue;
            }
            PriorityQueue<(int, int), int> pq = new PriorityQueue<(int, int), int>();
            pq.Enqueue((start, 0), 0);
            result[start, start] = 0;
            while (pq.Count > 0)
            {
                int node;
                int distance;
                (node, distance) = pq.Dequeue();
                if (!visit[node])
                {
                    result[start, node] = distance;
                    visit[node] = true;
                    foreach (var item in graph[node])
                    {
                        pq.Enqueue((item.Item1, item.Item2 + distance), item.Item2 + distance);
                    }
                }

            }
        }
    }
}