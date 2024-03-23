
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int k = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int f = int.Parse(input[2]);

            bool[,] edges = new bool[n + 1, n + 1];

            for(int i = 0; i < f; i++)
            {
                input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                edges[a, b] = true;
                edges[b, a] = true;
            }

            Stack<int> stack = new Stack<int>();
            for(int i = 1; i <= n; i++)
            {
                stack.Clear();
                if (Solve(i, stack, k, edges))
                    break;
            }


            //output
            if (stack.Count < k)
                Console.WriteLine(-1);
            else
            {
                foreach (var item in stack.Reverse())
                {
                    Console.WriteLine(item);
                }
            }
        }

        static bool Solve(int n, Stack<int> stack, int k, bool[,] edges)
        {
            foreach (int num in stack)
            {
                if (!edges[num, n])
                    return false;
            }

            stack.Push(n);
            if (stack.Count == k)
                return true;

            for(int i = n + 1; i < edges.GetLength(0); i++)
            {
                if (Solve(i, stack, k, edges))
                    return true;
            }

            stack.Pop();

            return false;
        }
    }
}