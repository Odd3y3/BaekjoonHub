
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            bool[] visited = new bool[n + 1];
            List<int>[] list = new List<int>[n + 1];
            for(int i = 1; i <= n; i++)
                list[i] = new List<int>();

            for(int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                list[a].Add(b);
            }

            List<int> result = new List<int>();
            for(int i = 1; i <= n ; i++)
            {
                if (!visited[i])
                    DFS(i, list, result, visited);
            }
            result.Reverse();
            Console.WriteLine(string.Join(' ', result));
        }
        static void DFS(int x, List<int>[] list, List<int> result, bool[] visited)
        {
            foreach (var item in list[x])
            {
                if (!visited[item])
                    DFS(item, list, result, visited);
            }
            result.Add(x);
            visited[x] = true;
        }
    }
}