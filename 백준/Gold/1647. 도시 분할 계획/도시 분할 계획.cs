
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            List<(int, int)>[] graph = new List<(int, int)>[n + 1];
            for (int i = 1; i <= n; i++)
                graph[i] = new List<(int, int)>();

            for(int i = 0; i < m; i++)
            {
                int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[inputs[0]].Add((inputs[1], inputs[2]));
                graph[inputs[1]].Add((inputs[0], inputs[2]));
            }

            //progress
            int sum = 0;
            int maxValue = 0;
            bool[] visit = new bool[n + 1];
            PriorityQueue<(int, int), int> pq = new PriorityQueue<(int, int), int>();
            pq.Enqueue((1, 0), 0);
            while(pq.Count > 0)
            {
                int node;
                int dist;
                (node, dist) = pq.Dequeue();
                if (!visit[node])
                {
                    visit[node] = true;
                    sum += dist;
                    maxValue = Math.Max(maxValue, dist);
                    foreach (var edge in graph[node])
                    {
                        pq.Enqueue(edge, edge.Item2);
                    }
                }
            }
            Console.WriteLine(sum - maxValue);
        }
    }
}