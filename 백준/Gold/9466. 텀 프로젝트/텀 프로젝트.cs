
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int test = 0; test < t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] graph = Console.ReadLine().Split().Select(x => int.Parse(x) - 1).ToArray();
                bool[] visit = new bool[n];
                List<int> list = new List<int>();
                int result = 0;
                for(int i = 0; i < n; i++)
                {
                    if (!visit[i])
                    {
                        list.Clear();
                        Func(i, list, graph, visit, ref result);
                    }
                }
                Console.WriteLine(result);
            }
        }
        static void Func(int num, List<int> list, int[] graph, bool[] visit, ref int result)
        {
            if (visit[num])
            {
                if (list.Contains(num))
                {
                    result += list.IndexOf(num);
                }
                else
                {
                    result += list.Count;
                }
            }
            else
            {
                visit[num] = true;
                list.Add(num);
                Func(graph[num], list, graph, visit, ref result);
            }
        }
    }
}