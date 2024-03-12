
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine(Solve(n, k));
        }

        static int Solve(int n, int k)
        {
            return BS(1, k, n, k);
        }

        static int BS(int start, int end, int n, int k)
        {
            if (start == end)
                return start;

            int mid = (start + end) / 2;

            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum += Math.Min(mid / i, n);
            }


            if (sum < k)
            {
                return BS(mid + 1, end, n, k);
            }
            else
            {
                return BS(start, mid, n, k);
            }
        }
    }
}                           