
using System.Security.Cryptography;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<(int, int)>[] graph = new List<(int, int)>[n + 1];
            for(int i = 0; i< n + 1; i++)
                graph[i] = new List<(int, int)>();
            for(int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int index = 1;
                while (true)
                {
                    if (input[index] == -1)
                        break;
                    graph[input[0]].Add((input[index], input[index + 1]));
                    index += 2;
                }
            }
            int maxResult = 0;
            Func(0, 1, graph, ref maxResult);
            Console.WriteLine(maxResult);

        }
        static int Func(int root, int node, List<(int, int)>[] graph, ref int maxResult)
        {
            List<int> list = new List<int>();
            foreach (var item in graph[node])
            {
                if(item.Item1 != root)
                    list.Add(Func(node, item.Item1, graph, ref maxResult) + item.Item2);
            }
            if (list.Count == 0)
                return 0;
            else if (list.Count == 1)
            {
                maxResult = Math.Max(maxResult, list[0]);
                return list[0];
            }
            else
            {
                list = list.OrderByDescending(x => x).ToList();
                maxResult = Math.Max(maxResult, list[0] + list[1]);
                return list[0];
            }
        }
    }
}