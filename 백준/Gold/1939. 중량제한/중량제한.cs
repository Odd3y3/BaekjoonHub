
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            List<(int, int)>[] graph = new List<(int, int)>[n + 1];
            for (int i = 1; i <= n; i++)
                graph[i] = new List<(int, int)>();

            for (int i = 0; i < m; i++)
            {
                int[] intInput = sr.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                graph[intInput[0]].Add((intInput[1], intInput[2]));
                graph[intInput[1]].Add((intInput[0], intInput[2]));
            }
            input = sr.ReadLine().Split(' ');
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            int[] resultArr = new int[n + 1];

            PriorityQueue<(int, int), int> pq = new PriorityQueue<(int, int), int>(); //min힙이므로 max힙으로 이용하기위해 priority를 음수로
            bool[] checkNode = new bool[n + 1];
            resultArr[x] = int.MaxValue;
            pq.Enqueue((x, int.MaxValue), -int.MaxValue);
            while(pq.Count > 0)
            {
                int node, weight;
                (node, weight) = pq.Dequeue();
                if (checkNode[node])
                    continue;
                foreach (var item in graph[node])
                {
                    resultArr[item.Item1] = Math.Max(Math.Min(resultArr[node], item.Item2), resultArr[item.Item1]);
                    pq.Enqueue((item.Item1, item.Item2), -item.Item2);
                }
                checkNode[node] = true;
            }
            Console.WriteLine(resultArr[y]);
        }
    }
}