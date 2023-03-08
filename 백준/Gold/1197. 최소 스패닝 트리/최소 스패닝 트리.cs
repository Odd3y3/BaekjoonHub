
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split(' ');
            int v = int.Parse(input[0]);
            int e = int.Parse(input[1]);
            int a, b, c;
            List<(int, int)>[] graph = new List<(int, int)>[v + 1];
            for (int i = 1; i <= v; i++)
                graph[i] = new List<(int, int)>();
            for(int i = 0; i < e; i++)
            {
                input = sr.ReadLine().Split(' ');
                a = int.Parse(input[0]);
                b = int.Parse(input[1]);
                c = int.Parse(input[2]);
                graph[a].Add((b, c));
                graph[b].Add((a, c));
            }
            
            PriorityQueue<(int, int), int> pq = new PriorityQueue<(int, int), int>();
            bool[] checkNode = new bool[v + 1];
            int result = 0;
            pq.Enqueue((1, 0), 0);
            while(pq.Count > 0)
            {
                int node, weight;
                (node, weight) = pq.Dequeue();
                if (!checkNode[node])
                {
                    result += weight;
                    checkNode[node] = true;
                    foreach (var item in graph[node])
                    {
                        pq.Enqueue(item, item.Item2);
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}