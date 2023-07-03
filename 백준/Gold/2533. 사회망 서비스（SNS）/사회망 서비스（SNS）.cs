
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int>[] graph = new List<int>[n + 1];
            for (int i = 1; i <= n; i++)
                graph[i] = new List<int>();

            for(int i = 0; i < n - 1; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[input[0]].Add(input[1]);
                graph[input[1]].Add(input[0]);
            }

            //progress
            bool[] visit = new bool[n + 1];
            bool[] result = new bool[n + 1];
            int result1, result2;
            (result1, result2) = Solve(1, 0, graph);

            //output
            Console.WriteLine(Math.Min(result1, result2));
        }

        static (int, int) Solve(int n, int parent, List<int>[] graph)
        {
            int result1 = 1;
            int result2 = 0;
            foreach (var item in graph[n])
            {
                if(item != parent)
                {
                    int a, b;
                    (a, b) = Solve(item, n, graph);
                    result1 += Math.Min(a, b);
                    result2 += a;
                }
            }
            

            return (result1, result2);
        }
    }
}