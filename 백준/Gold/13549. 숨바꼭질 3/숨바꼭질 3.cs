
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            bool[] visit = new bool[k * 2 + 1];

            if(n > k)
                Console.WriteLine(n - k);
            else
            {
                Queue<(int, int)> queue = new Queue<(int, int)>();
                queue.Enqueue((n, 0));
                int result = -1;
                while (result == -1)
                {
                    int a, b;
                    (a, b) = queue.Dequeue();
                    result = Solve(a, k, b, visit, queue);
                }

                Console.WriteLine(result);
            }

        }

        static int Solve(int n, int k, int depth, bool[] visit, Queue<(int, int)> queue)
        {
            if (n < 0 || visit[n])
                return -1;
            else
                visit[n] = true;

            if (n == k)
                return depth;

            int temp = n * 2;
            while(temp < 2 * k && !visit[temp])
            {
                queue.Enqueue((temp, depth));
                temp *= 2;
            }

            queue.Enqueue((n - 1, depth + 1));
            queue.Enqueue((n + 1, depth + 1));

            return -1;
        }
    }
}