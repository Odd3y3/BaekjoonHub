
using System.Text;

namespace TestingField
{
    internal class Program
    {
        struct Node
        {
            public int num;
            public int p;
            public Node(int num, int p)
            {
                this.num = num;
                this.p = p;
            }
        }
        static void Main(string[] args)
        {
            //input
            int n = int.Parse(Console.ReadLine());
            List<int>[] edges = new List<int>[n + 1];
            for (int i = 1; i <= n; i++)
                edges[i] = new List<int>();
            int[] input;
            for(int i = 0; i < n - 1; i++)
            {
                input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                edges[input[0]].Add(input[1]);
                edges[input[1]].Add(input[0]);
            }

            //init Tree
            List<int>[] dp = new List<int>[n + 1];
            for(int i = 0; i <= n; i++)
                dp[i] = new List<int>();
            bool[] visited = new bool[n + 1];
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(new Node(1, 0));
            Dictionary<int, int> depth = new Dictionary<int, int>();
            depth.Add(1, 0);
            while(queue.Count > 0)
            {
                Node node = queue.Dequeue();
                if (visited[node.num])
                    continue;
                
                visited[node.num] = true;

                //dp
                if(node.p != 0)
                {
                    dp[node.num].Add(node.p);
                    depth.Add(node.num, depth[node.p] + 1);
                }
                int temp = 0;
                int curNum = node.p;
                while(dp[curNum].Count > temp)
                {
                    dp[node.num].Add(dp[curNum][temp]);
                    curNum = dp[curNum][temp];
                    temp++;
                }

                foreach (int nextNode in edges[node.num])
                {
                    queue.Enqueue(new Node(nextNode, node.num));
                }
            }


            //output
            StringBuilder sb = new StringBuilder();
            int m = int.Parse(Console.ReadLine());
            for(int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                sb.AppendLine(Solve(input[0], input[1], dp, depth).ToString());
            }

            Console.WriteLine(sb.ToString());
        }

        static int Solve(int a, int b, List<int>[] dp, Dictionary<int, int> depth)
        {
            if (a == b)
                return a;

            if (depth[a] == depth[b])
            {
                return Solve2(a, b, dp);
            }

            int upperNum = depth[a] > depth[b] ? b : a;
            int lowerNum = depth[a] > depth[b] ? a : b;
            for(int i = dp[lowerNum].Count - 1; i >= 0; i--)
            {
                if (depth[lowerNum] - (int)Math.Pow(2, i) >= depth[upperNum])
                    return Solve(dp[lowerNum][i], upperNum, dp, depth);
            }

            return -1;
        }

        static int Solve2(int a, int b, List<int>[] dp)
        {
            if (dp[a][0] == dp[b][0])
                return dp[a][0];

            int prevA = a;
            int prevB = b;
            for(int i = 0; i < dp[a].Count; i++)
            {
                if (dp[a][i] == dp[b][i])
                    return Solve2(prevA, prevB, dp);
                prevA = dp[a][i];
                prevB = dp[b][i];
            }
            return Solve2(prevA, prevB, dp);
        }
    }
}