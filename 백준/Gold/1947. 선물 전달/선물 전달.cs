namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            const int DIVIDER = 1000000000;
            long[] dp = new long[n + 2];
            dp[1] = 0;
            dp[2] = 1;
            for(int i = 3; i <= n; i++)
            {
                dp[i] = ((dp[i - 1] + dp[i - 2]) * (i - 1)) % DIVIDER;
            }
            Console.WriteLine(dp[n]);
        }
    }
}

