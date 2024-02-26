
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Dictionary<long, long> dict = new Dictionary<long, long>();
            Console.WriteLine(Func(n, dict));
        }

        static long Func(long n, Dictionary<long, long> dict)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else if (dict.ContainsKey(n))
                return dict[n];
            else if (n % 2 == 0)
            {
                // n 이 짝수
                long result = (Func(n / 2, dict) * (2 * Func(n / 2 - 1, dict) + Func(n / 2, dict)))% 1000000;
                dict.Add(n, result);
                return result;
            }
            else
            {
                // n 이 홀수
                long result = (Func(n / 2 + 1, dict) * Func(n / 2 + 1, dict) + Func(n / 2, dict) * Func(n / 2, dict)) % 1000000;
                dict.Add(n, result);
                return result;
            }
        }
    }
}