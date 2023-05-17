
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            int k = int.Parse(inputs[2]);

            List<(int, int)>[] graph = new List<(int, int)>[n + 1];
            for (int i = 1; i <= n; i++)
                graph[i] = new List<(int, int)>();

            for(int i = 0; i < k; i++) 
            {
                inputs = Console.ReadLine().Split();
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                int c = int.Parse(inputs[2]);
                if(a < b)
                    graph[a].Add((b, c));
            }

            //dp
            int[,] dp = new int[n + 1, m];
            for (int i = 0; i < n + 1; i++)
                for (int j = 0; j < m; j++)
                    dp[i, j] = -1;
            dp[1, 0] = 0;

            for(int i = 1; i < n; i++)
            {
                foreach (var node in graph[i])
                {
                    for(int j = 0; j < m - 1; j++)
                    {
                        if (dp[i, j] != -1)
                        {
                            dp[node.Item1, j + 1] = Math.Max(dp[node.Item1, j + 1], dp[i, j] + node.Item2);
                        }
                    }
                }
            }

            //result
            int max = 0;
            for(int i = 0; i < m; i++)
            {
                max = Math.Max(dp[n, i], max);
            }
            Console.WriteLine(max);
        }
    }
}

