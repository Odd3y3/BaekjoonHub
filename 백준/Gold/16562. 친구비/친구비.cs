
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int k = int.Parse(input[2]);
            int[] friendTex = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool[] visit = new bool[n];
            List<int>[] graph = new List<int>[n];
            for (int i = 0; i < n; i++)
                graph[i] = new List<int>();

            for(int i = 0; i < m; i++)
            {
                int[] inputNum = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[inputNum[0] - 1].Add(inputNum[1] - 1);
                graph[inputNum[1] - 1].Add(inputNum[0] - 1);
            }

            //progress
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                if (!visit[i])
                {
                    visit[i] = true;
                    sum += Solve(i, friendTex, graph, visit);
                }
            }

            if (sum <= k)
                Console.WriteLine(sum);
            else
                Console.WriteLine("Oh no");
        }
        static int Solve(int i, int[] friendTex, List<int>[] graph, bool[] visit)
        {
            //i 부터 graph돌면서 visit 체크하고 최소값 반환.
            int value = friendTex[i];
            foreach (int item in graph[i])
            {
                if (!visit[item])
                {
                    visit[item] = true;
                    value = Math.Min(value, Solve(item, friendTex, graph, visit));
                }
            }
            return value;
        }

    }
}