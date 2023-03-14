
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] isPrime = Enumerable.Repeat(true, 100001).ToArray(); //320 * 320 > 100001
            Eratos(isPrime);
            int[] dp = new int[100001];
            dp[0] = 1;
            for(int i = 2; i < 100001; i++)
            {
                if (isPrime[i])
                {
                    for(int j = i; j < 100001; j++)
                    {
                        dp[j] = (dp[j] + dp[j - i]) % 1000000007;
                    }
                }
            }


            int t = int.Parse(Console.ReadLine());
            int n;
            for(int i = 0; i < t; i++)
            {
                n = int.Parse(Console.ReadLine());
                Console.WriteLine(dp[n]);
            }
        }
        static void Eratos(bool[] isPrime)
        {
            isPrime[0] = false;
            isPrime[1] = false;
            for(int i = 2; i < 320; i++)
            {
                if (isPrime[i])
                {
                    int index = i;
                    for(int j = i + i; j < 100001; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }
        }
    }
    
}