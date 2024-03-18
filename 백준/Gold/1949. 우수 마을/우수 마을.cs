
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int[] peopleCount = new int[n + 1];
            for(int i = 1; i <= n; i++)
            {
                peopleCount[i] = int.Parse(input[i - 1]);
            }

            List<int>[] canMove = new List<int>[n + 1];
            for (int i = 1; i <= n; i++)
                canMove[i] = new List<int>();
            for(int i = 0; i < n - 1; i++)
            {
                input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                canMove[a].Add(b);
                canMove[b].Add(a);
            }

            //progress
            bool[] visited = new bool[n + 1];
            int[,] dp = new int[n + 1, 2];
            Func(1, peopleCount, canMove, visited, dp);
            Console.WriteLine(Math.Max(dp[1, 0], dp[1, 1]));
        }

        static void Func(int n, int[] peopleCount, List<int>[] canMove, bool[] visited, int[,] dp)
        {
            visited[n] = true;

            List<int> children = new List<int>();
            foreach (int nextNode in canMove[n])
            {
                if (visited[nextNode])
                    continue;
                Func(nextNode, peopleCount, canMove, visited, dp);
                children.Add(nextNode);
            }

            dp[n, 0] = peopleCount[n];
            
            if (children.Count != 0)
            {
                foreach (int child in children)
                {
                    dp[n, 0] += dp[child, 1];
                    dp[n, 1] += Math.Max(dp[child, 0], dp[child, 1]);
                }

            }
        }
    }
}