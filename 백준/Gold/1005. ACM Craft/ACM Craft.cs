
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int test = 0; test < t; test++)
            {
                string[] input = Console.ReadLine().Split();
                int n = int.Parse(input[0]);
                int k = int.Parse(input[1]);
                int[] buildTime = Console.ReadLine().Split().Select(int.Parse).ToArray();
                List<int>[] graph = new List<int>[n];
                for (int i = 0; i < n; i++)
                    graph[i] = new List<int>();
                for(int i = 0; i < k; i++)
                {
                    input = Console.ReadLine().Split();
                    int a = int.Parse(input[0]) - 1;
                    int b = int.Parse(input[1]) - 1;
                    graph[b].Add(a);
                }
                int w = int.Parse(Console.ReadLine()) - 1;

                int[] visit = Enumerable.Repeat(-1, n).ToArray();
                Console.WriteLine(DFS(w, graph, visit, buildTime));
            }
        }
        static int DFS(int w, List<int>[] graph, int[] visit, int[] buildTime)
        {
            if (visit[w] != -1)
            {
                return visit[w];
            }
            else if (graph[w].Count == 0)
            {
                return buildTime[w];
            }
            else
            {
                int result = 0;
                foreach (var item in graph[w])
                {
                    result = Math.Max(DFS(item, graph, visit, buildTime), result);
                }
                visit[w] = result + buildTime[w];
                return visit[w];
            }
        }
    }
}