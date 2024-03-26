
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(x => long.Parse(x)).ToArray();
            Console.WriteLine(GetSum(input[1]) - GetSum(input[0] - 1));
        }

        static long GetSum(long value)
        {
            long result = 0;
            long temp = 0;

            // i == 자리 수
            for(int i = value.ToString().Length - 1; i >= 0; i--)
            {
                long n = value / (long)Math.Pow(10, i);
                n %= 10;
                Func(i, n, ref temp, ref result);
            }

            return result;
        }

        static void Func(int i, long n, ref long temp, ref long result)
        {
            if (i == 0)
            {
                result += Sum(n);
                result += (n + 1) * temp;
            }
            else
            {
                result += 45 * (long)Math.Pow(10, i - 1) * i * n;
                result += (long)Math.Pow(10, i) * Sum(n - 1);
                result += temp * n * (long)Math.Pow(10, i);
            }
            temp += n;
        }

        static int Sum(long n)
        {
            int result = 0;
            for(int i = 0; i <= n; i++)
            {
                result += i;
            }
            return result;
        }
    }
}